int numero = 0;

do
{
    Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar)....:");
    int entrada;

    if (!int.TryParse(Console.ReadLine(), out entrada))
    {
        Console.WriteLine("Entrada Inválida. Tente novamente. \n");
        continue;
    }
    if (entrada == 0)
    {
        Console.WriteLine("\nOperação cancelada. \n\nVolte Sempre!");
        break;
    }
    if (entrada >= 1 && entrada <= 9)
    {
        numero = entrada;
        break;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Tente novamente. \n ");
    }
}
while (true);

if (numero != 0)
{
    Console.WriteLine($"\nNúmero selecionado = {numero}\n\nVolte sempre!");
}
