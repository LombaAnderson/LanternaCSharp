using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LanternaCSharp.Models
{
    public class Lanterna
    {

       public int Status { get; set; }
       public string Ligada { get; set; }
       public string Desligada { get; set; }


        public string LigaLanterna ()
        {
            return Ligada;
     
        }

      public string DesligaLanterna()
        {
            return Desligada;
        }
       

      public void TrocaBateria()
        {

        }
      

    }
}
