int f, n, c;
n = 0;
f = 1;
Console.WriteLine("Informe o valor a ser fatorado: ");
n = int.Parse(Console.ReadLine());
if (n<0)
{
    Console.WriteLine("Numero inválido. Apenas numeros maiores ou iguais a zero.");
}
else if((n==0)|| (n==1))
{
    Console.WriteLine("Fatorial de {0} é 1", n);
}
else
{
    for(c = n; c >= 1; c-- )
    {
        f*= c;
    }
    Console.WriteLine("Fatorial de {0} é {1} ", n, f);
}
Console.ReadKey();