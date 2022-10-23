using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TeDoen {
    // De generische klasse FouteRij 
    internal class FouteRij<T> {
        // De interne (private) container is gebaseerd op een generische List
        private List<T> container = new List<T>();
        // Het interne (private) "Huidig" is het object (of de index van het object) waar je op dit ogenblik mee werkt
        private T huidig;
        // public bool IsLeeg : een publieke read-only eigenschap die True is als er niets in de rij zit
        public bool Isleeg = true;
        // public int Count:  een publieke read-only eigenschap die het aantal elementen in de lijst bevat
        public int count;
        // generische public T HuidigElement:  een publieke read-only eigenschap die het huidige object geeft
        public T huidigElement;

        // iets Toevoegen(iets) :
        public T Toevoegen(T iets){
            //als de rij leeg was, zet dan Huidig op iets
            if (container.Count == null){
                huidig = iets;
            }

            //zet het(generisch) object iets achteraan in de rij;
            container.Add(iets);

            //return Huidig
            return huidig;
        }

        //iets Verwijderen() :
        public T Verwijderen(){
            //verwijder het Huidig object
            container.Remove(huidig);

            //Huidig wordt het eerste object in de rij
            if (container.Count != 0){
                huidig = container[0];
            }

            //return dat object Huidig
            return huidig;
        }

        // iets Volgende(): 
        public T Volgende() {
            // Maak Huidig het volgende generische object in de rij (hetgeen op "Huidig" volgt)
            int huidigeIndex = container.IndexOf(huidig);
            huidig = container[huidigeIndex + 1];

            // als Huidig het laatste object was, dan wordt "Huidig" het eerste object
            if (container.IndexOf(huidig) == -1) {
                huidig = container[0];
            }

            // return Huidig
            return huidig;
        }

        // void Leegmaken() :
        public void Leegmaken() {
            // verwijder alles uit de rij
            container.Clear();

            // Huidige wordt een default-object
            huidig = default;
        }

        //iets ZetAchteraan() :
        public T ZetAchteraan() {
            //Zet "Huidig" achteraan in de lijst;
            //Huidig wordt het eerste element van de lijst
            int huidigeIndex = container.Count - 1;
            container[huidigeIndex] = this.huidig;

            //return Huidig
            return this.huidig;
        }

        // string ToString() :
        public override string ToString(){
            // Toon alle items in de rij, telkens op een nieuwe lijn, gebruikmakend van de ToString() van het generische type
            string containerTostring = string.Join("\n", container);
            return containerTostring;
        }

        // Rij Copy() : kopieert een rij naar een nieuwe rij
        public FouteRij<T> Copy(){
            FouteRij<T> copy = (FouteRij<T>)this.MemberwiseClone();
            return copy;
        }
    }
}
