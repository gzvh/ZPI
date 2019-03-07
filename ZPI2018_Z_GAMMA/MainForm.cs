using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPI2018_Z_GAMMA
{
   

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string WybranaOperacja = "";
        string WalutaA = "";
        string WalutaB = "";
        string CzasZakres = "";
        string IloscDni = "0";
        List<Funkcje.Waluta> walutaALista;
        List<Funkcje.Waluta> walutaBLista;

        private void ProcessChoice()
        {

            Funkcje funkcje = new Funkcje();

            if (CzasZakres == "")
            {
                 MessageBox.Show("Wybierz zakres czasu",
                 "Wybierz Parametry",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
                return;
            }

            if (WybranaOperacja == "")
            {
                MessageBox.Show("Wybierz operacje do wykonania",
                "Wybierz Parametry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (WybranaOperacja != "ROZKLAD" && WalutaA == "")
            {
                MessageBox.Show("Wybierz walutę",
                "Wybierz Parametry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                Waluta.BackColor = Color.Red;
                return;
            }

            if (WybranaOperacja == "ROZKLAD" && (WalutaA=="" || WalutaB==""))
            {
                MessageBox.Show("Wybierz dwie waluty",
                "Wybierz Parametry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (WybranaOperacja == "ROZKLAD" && CzasZakres != "Kwartał" && CzasZakres != "Miesiąc")
            {
                MessageBox.Show("Statystyka wykonuje obliczenia dla przedziałow czasu kwartał lub miesiac",
                "Wybierz Parametry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (CzasZakres == "Tydzień")
            {
                IloscDni = "5";
            } else if (CzasZakres == "Dwa Tygodnie")
            {
                IloscDni = "10";
            }
            else if (CzasZakres == "Miesiąc")
            {
                IloscDni = "21";
            }
            else if (CzasZakres == "Kwartał")
            {
                IloscDni = "84";
            }

            else if (CzasZakres == "Kwartał")
            {
                IloscDni = "84";
            }

            else if (CzasZakres == "Pół Roku")
            {
                IloscDni = "126";
            }

            else if (CzasZakres == "Rok")
            {
                IloscDni = "254";
            }




         
            walutaALista = funkcje.getData(WalutaA, IloscDni);
            if(walutaALista.Count() > 0)


            if(WybranaOperacja == "ROZKLAD")
            {

                walutaBLista = funkcje.getData(WalutaB, IloscDni);
               
            }

            if (WybranaOperacja == "SESJE")
                funkcje.IloscSesji(WalutaA, walutaALista);

            if (WybranaOperacja == "MEDIANA")
                funkcje.Mediana(WalutaA, walutaALista);

            if(WybranaOperacja == "DOMINATA")
            {
                funkcje.Dominata(WalutaA, walutaALista);
            }

            if (WybranaOperacja == "ODCHYLENIESTD")
            {
                funkcje.OdchylenieStd(WalutaA, walutaALista);
            }

            if (WybranaOperacja == "WSPOLZMIEN")
            {
                funkcje.WspZm(WalutaA, walutaALista);
            }

            if (WybranaOperacja == "WSPOLZMIEN")
            {
                funkcje.WspZm(WalutaA, walutaALista);
            }

            if (WybranaOperacja == "ROZKLAD")
            {
                funkcje.RozkadZmian(WalutaA, WalutaB, walutaALista, walutaBLista);
            }

            return;


            
        }

        private void Mediana_CheckedChanged(object sender, EventArgs e)
        {
            if (Mediana.Checked)
                WybranaOperacja = "MEDIANA";
        }

        private void Dominata_CheckedChanged(object sender, EventArgs e)
        {
            if(Dominata.Checked)
                WybranaOperacja = "DOMINATA"; 

        }

        private void Sesje_CheckedChanged(object sender, EventArgs e)
        {
            if (Sesje.Checked)
                WybranaOperacja = "SESJE";
        }

        private void OdchylenieStd_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieStd.Checked)
                WybranaOperacja = "ODCHYLENIESTD";
        }

        private void WspolczynnikZmiennosci_CheckedChanged(object sender, EventArgs e)
        {
            if (WspolczynnikZmiennosci.Checked)
                WybranaOperacja = "WSPOLZMIEN";
        }

        private void RozkladCzestosci_CheckedChanged(object sender, EventArgs e)
        {
            if (RozkladCzestosci.Checked)
                WybranaOperacja = "ROZKLAD";
        }
        private void Waluta_SelectedIndexChanged(object sender, EventArgs e)
        {
             WalutaA = Waluta.GetItemText(Waluta.SelectedItem);
        }

        private void Waluta2_SelectedIndexChanged(object sender, EventArgs e)
        {
             WalutaB = Waluta2.GetItemText(Waluta2.SelectedItem);
        }

        private void Czas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CzasZakres = Czas.GetItemText(Czas.SelectedItem);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ProcessChoice();
    
        }

        private void Waluta_MouseClick(object sender, MouseEventArgs e)
        {
            Waluta.BackColor = Color.White;
        }
    }
}
