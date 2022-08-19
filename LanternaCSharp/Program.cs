using LanternaCSharp.Models;
using System;

public class Program
{

    
    public static void Main()
    {

        Lanterna lanterna = new Lanterna();
        Bateria bateria = new Bateria();

       

        // exibir o status inicial de bateria.Carga e lanterna.Status

        Console.Clear();
        Console.WriteLine($" \n Status da Lanterna : " + lanterna.ObterStatus());

        Console.WriteLine($" \n Status da Bateria :  " + bateria.ObterCarga());
        Console.WriteLine("Opções :");
        Console.WriteLine("1- Ligar lanterna");
        var opcao = Console.ReadLine();
        if(opcao =="1")
        {
            lanterna.ObterStatus(ligado)
            LigarLanterna(bateria, lanterna);
        }
        Console.ReadLine();



    }

    public static void LigarLanterna( Bateria bateria, Lanterna lanterna)
    {
        /* altera a lanterna*/
       
       
        while ( lanterna.ObterStatus())
        {
            int c = bateria.ObterCarga();
            if (c == 0)
            {

                break;
            }
            bateria.AlterarCarga(c--);

            Thread.Sleep(1000);

        }

        Console.Clear();
        Console.WriteLine("Bateria descarregada...");
        Thread.Sleep(2500);

      
        TrocarBateria();
    }


     public static void TrocarBateria()
     {

        /* altera a carga da bateria para 100 */

     }


    public static void SubtrairBateria(bool ligado, Bateria bateria)
    {
        
    }




}




























