using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TeDoen {
    internal class TeDoen {
        // int Id:  Deze krijgt automatisch een volgnummer
        public int id;
        // DateTime Tijdstip:  Bevat het tijdstip waarop het object moet "uitgevoerd" worden.
        // Dit tijdstip is null als er geen specifiek tijdstip is. Anders moet het groter zijn dan "DateTime.Now".
        public DateTime? tijdStip;
        // string Titel:  Bevat de korte titel / omschrijving van het TeDoen object
        public string titel { get; set; }
        // string[] Informatie:  Bevat (indien gewenst) uitgebreidere informatie betreffende dit TeDoen object
        public string[] informatie { get; set; }
        // event meedelen 
        Boolean dringend;

        public TeDoen(){}

        public TeDoen(string titel, string[] informatie) {
            int id = +1;
            this.titel = titel;
            this.informatie = informatie;

            if (tijdStip == DateTime.MinValue) {
                tijdStip = null;
            }
        }

        public TeDoen(DateTime? tijdStip, string titel, string[] informatie) {
            if (tijdStip == DateTime.MinValue || tijdStip == null) {
                tijdStip = null;
                dringend = true;
            }
            tijdStip = new DateTime();
            int id = +1;
            this.titel = titel;
            this.informatie = informatie;

            
        }

        // event Meedelen:  Dit event wordt opgeroepen telkens als een object getoond wordt en heeft drie parameters
        // (titel , inhoud, dringend) waarbij de boolean dringend True is als Tijdstip null is;
        public void Meedelen(string titel, string[] inhoud, Boolean dringend){
            if (tijdStip == null) {
                dringend = true;
            }  else dringend = false;
        }

        // override ToString()
        public override string ToString() {
            string inf = " ";
            foreach(string info in informatie){
                inf += info;
            }
           Meedelen(titel, informatie, dringend);
           return titel + " " + inf + " " + tijdStip;
        }
    }
}
