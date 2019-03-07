using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ZPI2018_Z_GAMMA
{
    public class Funkcje
    {
        public int IloscSesji(string wal, List<Waluta> dane)
        {
            int sSpad = 0;
            int sBezZmian = 0;
            int sWzrost = 0;
            float tmpVal = 0;

            for (int a = 0; a < dane.Count(); a++)
            {

                if (a == 0)
                {
                    tmpVal = dane[a].Wartosc;
                    continue;
                }
                else
                {
                    if (tmpVal == dane[a].Wartosc)
                        sBezZmian++;
                    if (tmpVal < dane[a].Wartosc)
                        sWzrost++;
                    if (tmpVal > dane[a].Wartosc)
                        sSpad++;
                    tmpVal = dane[a].Wartosc;
                }
            }

            if (dane.Count() < 2)
            {
                //MessageBox.Show("Zbyt mała ilośc danych do obliczenia sesji",
                //"Ważne",
                //MessageBoxButtons.OK,
                //MessageBoxIcon.Exclamation,
                //MessageBoxDefaultButton.Button1);
                return 0;
            }

            //MessageBox.Show("Ilość notowań: " + dane.Count() + " Sesje rosnące: " + sWzrost + " sesje malejące " + sSpad + " sesje bez zmian " + sBezZmian,
            //"Wynik",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information,
            //MessageBoxDefaultButton.Button1);

            return dane.Count();
        }

        public float Mediana(string wal, List<Waluta> dane)
        {
            float r = 0;
            //dane.Sort;
            r = dane[(dane.Count / 2)].Wartosc;
            //MessageBox.Show("Ilość notowań: " + dane.Count() + " Mediana " + r,
            //   "Wynik",
            //   MessageBoxButtons.OK,
            //   MessageBoxIcon.Information,
            //   MessageBoxDefaultButton.Button1);
            return r;

        }

        public float Dominata(string wal, List<Waluta> dane)
        {
            float[] L = { };
            //tablica liczby wystapien
            float[] W = { };
            float[] tab = { 1 };// Wiecej niz 300 nie ma danych dla roku ilosc notowan
            //loat[] tab = { 2, 2, 4, 4, 1, 3, 4, 2, 5, 1, 3, 1, 4, 4 };
            Array.Resize(ref tab, dane.Count());

            //Przepisanie danych
            for (int x = 0; x < dane.Count(); x++)
            {
                tab[x] = dane[x].Wartosc;
            }

            //zlicz wystepowanie poszczegolnych liczb w tablicy tab
            for (int i = 0; i < tab.Length; i++)
            {
                //zapytanie czy zawiera - można też zrobić w pętli
                if (L.Contains(tab[i]))
                {
                    int index = Array.IndexOf(L, tab[i]);
                    W[index] += 1;
                }
                else
                {
                    int l = L.Length + 1;
                    int w = W.Length + 1;
                    Array.Resize(ref L, l); //zmiana wielkości tablicy
                    Array.Resize(ref W, w);
                    L[l - 1] = tab[i];      //dodanie nowej wartości
                    W[w - 1] = 1;
                }
            }

            //poszukaj liczbe najczesciej wystepujaca
            float max = 0;
            int indexmax = 0;
            for (int i = 0; i < W.Length; i++)
            {
                if (W[i] > max)
                {
                    max = W[i];
                    indexmax = i;
                }
            }

            //MessageBox.Show("Ilość notowań: " + dane.Count() + " Dominata dla waluty: " + wal + ": " + L[indexmax],
            //"Wynik",
            //   MessageBoxButtons.OK,
            //   MessageBoxIcon.Information,
            //   MessageBoxDefaultButton.Button1);

            return L[indexmax];
        }

        public float OdchylenieStd(string wal, List<Waluta> dane)
        {

            float[] tab = { 1 };// Wiecej niz 300 nie ma danych dla roku ilosc notowan
            Array.Resize(ref tab, dane.Count());
            float tmp = 0;
            //Przepisanie danych
            for (int x = 0; x < dane.Count(); x++)
            {
                tab[x] = dane[x].Wartosc;
            }
            float average = tab.Average();
            float sumOfDerivation = 0;
            for (int u = 0; u < tab.Length; u++)
            {
                tmp = tab[u];
                sumOfDerivation = sumOfDerivation + (tmp * tmp);
            }
            float sumOfDerivationAverage = sumOfDerivation / (dane.Count() - 1);
            float avg2 = (average * average);
            float finalF = sumOfDerivationAverage - avg2;

            decimal decimalValue = System.Convert.ToDecimal(finalF);
            double doubleValue = System.Convert.ToDouble(decimalValue);
            doubleValue = Math.Sqrt(doubleValue);
            float newValue = Convert.ToSingle(doubleValue);

            //  MessageBox.Show("Ilość notowań: " + dane.Count() + " Odchylenie std. dla waluty: " + wal + ": " + newValue,
            //"Wynik",
            //   MessageBoxButtons.OK,
            //   MessageBoxIcon.Information,
            //   MessageBoxDefaultButton.Button1);

            return newValue;
        }

        public int WspZm(string wal, List<Waluta> dane)
        {

            int sZmiany = 0;
            float tmpVal = 0;
            int dc = dane.Count();
            for (int a = 0; a < dane.Count(); a++)
            {

                if (a == 0)
                {
                    tmpVal = dane[a].Wartosc;
                    continue;
                }
                else
                {
                    if (tmpVal < dane[a].Wartosc)
                        sZmiany++;
                    if (tmpVal > dane[a].Wartosc)
                        sZmiany++;
                    tmpVal = dane[a].Wartosc;
                }
            }

            if (dane.Count() < 2)
            {
                //MessageBox.Show("Zbyt mała ilośc danych do obliczenia sesji",
                //"Ważne",
                //MessageBoxButtons.OK,
                //MessageBoxIcon.Exclamation,
                //MessageBoxDefaultButton.Button1);
                return 0;
            }

            float wspZ = sZmiany / dc;

            //MessageBox.Show("Ilość notowań: " + dane.Count() + " Współczynnik zmian: " + sZmiany + " / " + dc,
            //"Wynik",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information,
            //MessageBoxDefaultButton.Button1);
            return dane.Count();
        }


        public int RozkadZmian(string wal1, string wal2, List<Waluta> dane, List<Waluta> dane2)
        {


            int zm = 0;
            float tmpVal = 0;

            for (int a = 0; a < dane.Count(); a++)
            {

                if (a == 0)
                {
                    tmpVal = dane[a].Wartosc - dane2[a].Wartosc;
                    continue;
                }
                else
                {

                    if (tmpVal < dane[a].Wartosc - dane2[a].Wartosc)
                        zm++;
                    if (tmpVal > dane[a].Wartosc - dane2[a].Wartosc)
                        zm++;
                    tmpVal = dane[a].Wartosc - dane2[a].Wartosc;
                }
            }

            if (dane.Count() < 2)
            {
                //MessageBox.Show("Zbyt mała ilośc danych do obliczenia sesji",
                //"Ważne",
                //MessageBoxButtons.OK,
                //MessageBoxIcon.Exclamation,
                //MessageBoxDefaultButton.Button1);
                return 0;
            }

            //MessageBox.Show("Ilość notowań: " + dane.Count() + " Ilość zmian dla walut : " + wal1 + " / " + wal2 + " " + zm,
            //"Wynik",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information,
            //MessageBoxDefaultButton.Button1);
            return dane.Count();
        }

        public class Waluta
        {
            public float Wartosc;
        }

        public List<Waluta> getData(string wal, string dni)
        {
            List<Waluta> list = new List<Waluta>();
            try
            {
                string link = "http://api.nbp.pl/api/exchangerates/rates/A/" + wal + "/last/" + dni + "?format=xml";


                XDocument xDoc = XDocument.Load(link);
                list = xDoc.Descendants("Rate")
                            .Select(o => new Waluta
                            {
                                Wartosc = (float)o.Element("Mid"),
                            })
                            .ToList();
                int lc = list.Count();
                string str = lc.ToString();


            }
            catch
            {
                //MessageBox.Show("Nie mozna wygenerować danych",
                //" ",
                //MessageBoxButtons.OK,
                //MessageBoxIcon.Exclamation,
                //MessageBoxDefaultButton.Button1);
            }
            return list;
        }

    }
}
