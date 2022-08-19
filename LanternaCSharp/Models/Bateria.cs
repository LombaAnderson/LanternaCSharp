using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LanternaCSharp.Models
{
    public class Bateria
    {
        private int carga = 100;
        

        public int ObterCarga()
        {
            return carga;

        }

        public void AlterarCarga(int novaCarga)
        {
            carga = novaCarga;
        }

    }
}


