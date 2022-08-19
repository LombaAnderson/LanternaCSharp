using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanternaCSharp.Models
{
    public class Bateria
    { 

     public int Carga { get; set; }


     public static int AoLigar(int carga)
        {
            int cargaCorrente = 0;

            while (cargaCorrente != carga)
            {
                Console.Clear();
                cargaCorrente--;
                Console.WriteLine(cargaCorrente);
                Thread.Sleep(1000);
                return cargaCorrente;   
            }

            Console.Clear();
            Console.WriteLine("Bateria descarregada...troque por outra no menu principal");
            Thread.Sleep(2500);

        }


    }


}
