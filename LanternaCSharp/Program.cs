using LanternaCSharp.Models;
using System.Runtime.Intrinsics.X86;

Lanterna lanterna1 = new Lanterna();
Bateria bateria1 = new Bateria();



Console.Clear();
Console.WriteLine(" \n Status da Lanterna : Desligada ");
Console.WriteLine(" \n Botão Liga/Desliga");
Console.WriteLine(" \n Status da Bateria : 100% Carregada");
Console.WriteLine("------------------------------");


Console.WriteLine($"1 = botão liga  \n" + lanterna1.LigaLanterna());

string ligada = Console.ReadLine("Lanterna ligada"));
Console.WriteLine($"2 = botão desliga  \n" + lanterna1.DesligaLanterna());
Console.WriteLine("Lanterna desligada");



Console.ReadLine();
    















