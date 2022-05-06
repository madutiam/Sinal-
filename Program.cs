int numeroDigitado;

Console.Write("Digite um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado == 0)
{
    Console.WriteLine("Zero");
}
else
{
    if (numeroDigitado < 0)
    {
        Console.WriteLine("Negativo");
    }
    else
    {
        Console.WriteLine("positivo");
    }
}
