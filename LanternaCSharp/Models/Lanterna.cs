using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LanternaCSharp.Models
{

    public class Lanterna
    {
        private bool status;



        public bool ObterStatus()
        {
            return status;

        }

        public void Ligar()
        {
            status = true;
        }

        public void DesLigar()
        {
            status = false;
        }

    }



}




