using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static TeDoen.TeDoen;

namespace TeDoen {
    public partial class Form1 : Form {
        // Voorzie een FouteRij<TeDoen> Taken
        FouteRij<TeDoen> Taken = new FouteRij<TeDoen>();
        // Zaken die nodig zijn voor de event
        public delegate void MeeDelen(string titel, string inhoud, Boolean dringend);
        public MeeDelen tdelen;
        public event MeeDelen delen = null;
        Boolean dringend;

        public Form1() {
            InitializeComponent();
        }

        // Bij het laden van de form is het automatisch uit 
        // daarom zet ik het al op rood
        private void Form1_Load(object sender, EventArgs e) {
            btnFunc1.BackColor = Color.Red;
            btnFunc2.BackColor = Color.Red;
            btnFunc3.BackColor = Color.Red;
        }

        // als de checkbox uitgevinkt is, wordt er geen tijd-veld getoond, en zal de overeenkomstige tijd null zijn
        private void cbTijd_CheckedChanged(object sender, EventArgs e) {
            if (cbTijd.Checked) {
                txtTijd.Visible = true;
            } else {
                txtTijd.Visible = false;
                txtTijd = null;
                dringend = true;
            }
        }

        //Voorzie een knop "Taak Toevoegen".
        private void btnTaakToevoegen_Click(object sender, EventArgs e) {
            //Een object zonder tijdstip(Tijdstip = null) wordt toegevoegd aan een FouteRij
            if (cbTijd.Checked == false) {
                Taken.Toevoegen(new TeDoen(txtTitel.Text, txtInformatie.Lines));
            }
            else {
                //Een object met tijdstip(Tijdstip != null) asynchroon wordt gestart om op het juiste moment getoond te worden.
                //Dit object wordt niet in de FouteRij gezet
                Asychroon asychroon = new Asychroon(int.Parse(txtTijd.Text));
                asychroon.wait();
            }
        }

        // Voorzie een knop "Volgende taak" die de volgende taak "Meedeelt"
        private void btnVolgendeTaak_Click(object sender, EventArgs e) {
            Taken.Volgende();
        }

        // Voorzie een knop "Taak is afgewerkt" die deze (huidige) taak uit de rij haalt
        private void btnTaakIsAfgewerkt_Click(object sender, EventArgs e) {
            Taken.Verwijderen();
        }

        // Voorzie een knop "Zet achteraan" die de (huidige) taak achteraan in de rij plaatst
        private void btnZetAchteraan_Click(object sender, EventArgs e) {
            Taken.ZetAchteraan();
        }

        // Voorzie een event "Meedelen" dat een TeDoen object 
        // (onverschillig of het in de rij zit, of geprogrammeerd is om asynchroon uitgevoerd te worden) "Meedeelt"
        private void btnDelen_Click(object sender, EventArgs e) {
            TeDoen td = new TeDoen(txtTitel.Text, txtInformatie.Lines);
            txtOutput.Text = td.ToString();
        }

        public void Func1(string titel, string inhoud, Boolean dringend){
            TeDoen td = new TeDoen(txtTitel.Text, txtInformatie.Lines);
            txtOutput.Text = td.ToString();
        }

        public void Func2(string titel, string inhoud, Boolean dringend){
            TeDoen td = new TeDoen(txtTitel.Text, txtInformatie.Lines);
            var txtOutput = td.ToString();
            MessageBox.Show(txtOutput);
        }
        public void Func3(string titel, string inhoud, Boolean dringend) {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\thele\Downloads\mixkit-alarm-clock-beep-988.wav");
            soundPlayer.Play();
        }

        private void ClickOpDeJuisteButton(object sender, EventArgs e) {
            // Alles "Meedelen" in een multi-line textveld op je scherm aan of uit zet(de knop is groen als dit aanstaat, 
            // rood als dit uitstaat)
            if (sender == btnFunc1) {
                if (btnFunc1.BackColor == Color.Red) {
                    delen -= new MeeDelen(Func1);
                    btnFunc1.BackColor = Color.Green;
                } else if(btnFunc1.BackColor == Color.Green) {
                    delen += new MeeDelen(Func1);
                    btnFunc1.BackColor = Color.Red;
                }
            }
            // Alles "Meedelen" in een MessageBox(ook aan/uit met rood/groen)
            if (sender == btnFunc2) {
                if (btnFunc2.BackColor == Color.Red) {
                    delen -= new MeeDelen(Func2);
                    btnFunc2.BackColor = Color.Green;
                } else if (btnFunc2.BackColor == Color.Green) {
                    delen += new MeeDelen(Func2);
                    btnFunc2.BackColor = Color.Red;
                };
            }
            // Een biep laat horen(ook aan/uit met rood/groen)
            if (sender == btnFunc3) {
                if (btnFunc3.BackColor == Color.Red) {
                    delen -= new MeeDelen(Func3);
                    btnFunc3.BackColor = Color.Green;
                } else if (btnFunc3.BackColor == Color.Green) {
                    delen += new MeeDelen(Func3);
                    btnFunc3.BackColor = Color.Red;
                }
            }
        }

        
    }
}