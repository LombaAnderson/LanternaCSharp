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
        Console.WriteLine(" \n Status da Lanterna : Desligada " + Lanterna.Status);
        Console.WriteLine(" \n Botão Liga/Desliga");
        Console.WriteLine(" \n Status da Bateria : 100% Carregada");
        Console.WriteLine("------------------------------");

        Console.ReadLine();
    }

    

    public static void TrocarBateria() { /* altera a carga da bateria para 100 */ }
}












    















