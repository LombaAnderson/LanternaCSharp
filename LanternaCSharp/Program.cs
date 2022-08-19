using LanternaCSharp.Models;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;

Lanterna lanterna1 = new Lanterna();
Bateria bateria1 = new Bateria();
string Ligada ;


Console.Clear();
Console.WriteLine(" \n Status da Lanterna : Desligada ");
Console.WriteLine(" \n Botão Liga/Desliga");
Console.WriteLine(" \n Status da Bateria : 100% Carregada");
Console.WriteLine("------------------------------");


Console.WriteLine($" Clique qualquer tecla para ligar a lanterna"  );
 Ligada = Console.ReadLine();

Console.WriteLine(string.Format("\n Status da Lanterna: Ligada")); 



//Console.WriteLine($"2 = Desliga lanterna  \n" + lanterna1.DesligaLanterna());

//Console.WriteLine("Lanterna desligada");



Console.ReadLine();
    















