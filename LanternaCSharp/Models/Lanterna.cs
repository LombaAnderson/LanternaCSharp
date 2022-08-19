
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




