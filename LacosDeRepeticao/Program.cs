int n1 = 0, max = 0, contador = 0, aux = 0;

Console.WriteLine("Digite um número:");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um número incrementador");
max = int.Parse(Console.ReadLine());

aux = n1;

Console.WriteLine("Aqui é o do");
do
{
    Console.WriteLine(aux);
    aux++;
    contador++;
   
} while (contador <= max);

Console.WriteLine("Aqui éo while");
contador = 0;
aux = n1;
Console.WriteLine(aux);
while (contador < max)
{
    aux++;
    Console.WriteLine(aux);
    contador++;
}

Console.WriteLine("Aqui é o for");
aux = n1;
for (contador = 0; contador <= max; contador++)
{
    Console.WriteLine(aux);
    aux++;
}