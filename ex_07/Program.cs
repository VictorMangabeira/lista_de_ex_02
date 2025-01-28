// 7. Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor negativo seja digitado. A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de repetição.


using System.ComponentModel;
using System.Drawing;

Ex7
7. Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve
Solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor
Negativo seja digitado. A soma das distâncias deve ser calculada e exibida
Utilizando as três estruturas de repetição.
While
Double distanciaTotal = 0;
Double distancia;
Console.WriteLine(“Digite as distancias percorridas: (valor negativo para sair)”);

While(true)
        {
    Distancia = Convert.ToInt32(Console.ReadLine());
    If(distancia < 0) break;
    distanciaTotal += distancia;

}
Console.WriteLine($”Distacia total percorrida { distanciaTotal}
km”);
Do while
Double distanciaTotal = 0;
Double distancia;

Do
    {
        Console.WriteLine(“Digite as distancias percorridas (valor negativo para sair)”);
Distancia = Convert.ToInt32(Console.ReadLine());
If(distancia >= 0) distanciaTotal += distancia;
    } while (distancia >= 0) ;
Console.WriteLine($”Distancia percorrida: { distanciaTotal}
km”);
For
Double distanciaTotal = 0;
Double distancia;


For
Double distanciaTotal = 0;
Double distancia;

For(; ;)
{
    Console.WriteLine(“Digite as distancia percorrida(valor negativo para sair)”);
    Distancia = Convert.ToInt32(Console.ReadLine());
    If(distancia < 0) break;
    distanciaTotal += distancia;
}
Console.WriteLine($”A distancia total percorrida { distanciaTotal}
km”);