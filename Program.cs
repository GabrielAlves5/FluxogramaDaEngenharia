Console.WriteLine("Fluxograma da Engenharia");
Console.WriteLine("A coisa está se movendo? [s] [n]");
string escolha = Console.ReadLine()!.ToLower();
if (escolha == "s")
{
Console.WriteLine("Deveria?");
escolha = Console.ReadLine()!.ToLower();
if (escolha == "s")
{
  Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Ótimo");
    Console.ResetColor();
}else
{
    Console.WriteLine("Usa Fita isolante");
}
}else if (escolha == "n")
{
  Console.WriteLine("Deveria?");
escolha = Console.ReadLine()!.ToLower();
if (escolha == "s")
Console.WriteLine("Usa WD-40");
else{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Ótimo");
    Console.ResetColor();
}
}else
return;