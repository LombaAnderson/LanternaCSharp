using LanternaCSharp.Models;
using System;

public class Program
{
    Bateria bateria = new Bateria();
    Lanterna lanterna = new Lanterna();


    
   
    public static void Main()
    {
        // exibir o status inicial de bateria.Carga e lanterna.Status

        Console.Clear();
        Console.WriteLine($" \n Status da Lanterna : " + lanterna.Status);
        Console.WriteLine($" \n Status da Bateria :  " + bateria.Carga);

        Console.ReadLine();
     
    }

    public static void LigarLanterna(bool status)
    {
        /* altera a lanterna*/
        int carga = 100;
        int cargaCorrente = 0;

        while (cargaCorrente != carga)
        {
            Console.Clear();
            cargaCorrente--;
            Console.WriteLine(cargaCorrente);
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




}




























