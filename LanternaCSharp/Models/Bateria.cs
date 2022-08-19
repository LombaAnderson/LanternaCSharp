

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


