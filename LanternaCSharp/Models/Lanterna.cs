using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LanternaCSharp.Models
{
   
        public class Lanterna
        {
            public bool Status { get; set; }
        }


    public static void LigarLanterna(bool status)
    { 
        /* altera a lanterna*/ 
    
    
    }


    public void Ligar(int carga)
        {
            int cargaCorrente = 0;

            while (cargaCorrente != carga)
            {
                Console.Clear();
                cargaCorrente--;
                Console.WriteLine(cargaCorrente);
                Thread.Sleep(1000);

            }

            Console.Clear();
            Console.WriteLine("Bateria descarregada...clique qualquer tecla para recarregar");
            Thread.Sleep(2500);

            RecarregaBateria(); 

        }

        public void RecarregaBateria()
        {

        }
    }
}
