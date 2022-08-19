using LanternaCSharp.Models;
using System;

public class Program
{


    public static void Main()
    {

        Lanterna lanterna = new Lanterna();
        Bateria bateria = new Bateria();

        Menu(lanterna, bateria);

    }

    public static void Menu(Lanterna lanterna, Bateria bateria)
    {
        Console.Clear();

        var status = lanterna.ObterStatus();

        Console.WriteLine("-------------- INFORMAÇÕES --------------");


        Console.WriteLine($" \n A lanterna está: " + (status ? "Ligada" : "Desligada"));

        Console.WriteLine($" \n Caraga da Bateria :  " + bateria.ObterCarga());

        Console.WriteLine("-----------------------------------------");


        Console.WriteLine("=============== MENU ==================");

        if (status)
        {
            Console.WriteLine("1 - Desligar lanterna");
        }
        else
        {
            Console.WriteLine("1 - Ligar lanterna");
        }

        Console.WriteLine("2 - Trocar bateria");
        Console.WriteLine("3 - Sair");

        var opcao = Console.ReadLine();

        if (opcao == "1")
        {
            if (status)
            {
                lanterna.DesLigar();
            }
            else
            {
                lanterna.Ligar();

                LigarLanterna(bateria, lanterna);
            }
        }
        else if (opcao == "2")
        {
            bateria.AlterarCarga(100);
        }
        else if (opcao == "3")
        {
            Environment.Exit(0);
        }

        Console.WriteLine("=================================");

    }

    public static void LigarLanterna(Bateria bateria, Lanterna lanterna)
    {
        while (lanterna.ObterStatus())
        {
            int c = bateria.ObterCarga();

            Console.WriteLine("Bateria: " + c);
            if (c == 0)
            {
                break;
            }
            bateria.AlterarCarga(--c);

            Thread.Sleep(5000);

        }
    }

}











