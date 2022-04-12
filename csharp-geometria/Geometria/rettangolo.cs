using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    //------- classe rettangolo -------
    internal class rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        // ----Costruttori-----

        public rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        // ---- metodo 1 paramentro rettangolo ----

        public int calcoloArea()
        {
            int risultato = baseRettangolo * altezzaRettangolo;
            return risultato;
        }

        public int calcoloPerimetro() 
        {
            int risultato = (baseRettangolo + altezzaRettangolo) * 2;
            return risultato;
        }

        public void stampaRettangolo()
            { 
             Console.WriteLine("Base del rettangolo: " + baseRettangolo);
             Console.WriteLine("Altezza del rettangolo è " + altezzaRettangolo);
             Console.WriteLine("L'area del rettangolo è " + calcoloArea());
             Console.WriteLine("Il perimetro del rettangolo è " + calcoloPerimetro());
            }



    }

    









}
