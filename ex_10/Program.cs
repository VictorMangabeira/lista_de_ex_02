// 10. Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até que ele digite um valor negativo. O total de passagens vendidas deve ser calculado e apresentado utilizando while, do while e for.


using System.ComponentModel;
using System.Drawing;



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

Ex8.
8.Um atendente de suporte técnico deseja contar quantas chamadas atendeu em 

Um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada 

Chamada em minutos até que ele digite 0. O programa deve calcular o total de 

Minutos atendidos, utilizando while, do while e for.
While 

Int TotalChamadas = 0;
Int duraçao = 0;

Console.WriteLine(“Digite a duraçao das chamadas em minutos: (0 para sair)”);

While(true)
        {
    Duraçao = Convert.ToInt32(Console.ReadLine());
    If(duraçao == 0) break;
    TotalChamadas += duraçao;
}
Console.WriteLine($”Total de minutos atendidos: { TotalChamadas}
minutos”);


Do while

Int TotalChamadas = 0;
Int duraçao = 0;



Do
       { 
        Console.WriteLine(“Digite a duraçao das chamadas em minutos: (0 para sair)”);

Duraçao = Convert.ToInt32(Console.ReadLine());
If(duraçao != 0)
            TotalChamadas += duraçao;
            
        } while (duraçao != 0) ;
Console.WriteLine($”Total de minutos atendidos: { TotalChamadas}
minutos”);

For


Int TotalChamadas = 0;
Int duraçao = 0;



For(; ;)
       {
    Console.WriteLine(“Digite a duraçao das chamadas em minutos: (0 para sair)”);

    Duraçao = Convert.ToInt32(Console.ReadLine());
    If(duraçao == 0) break;
    TotalChamadas += duraçao;
}
Console.WriteLine($”Total de minutos atendidos: { TotalChamadas}
minutos”);

Ex9.

9.Um cliente deseja saber o total de suas compras em um supermercado. O aluno 

Deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A 

Soma dos valores das compras deve ser implementada usando as três estruturas 

De repetição.


While 

Double TotalCompras = 0;
Double ValorCompra;
Console.WriteLine(“Digite o valor das compras: (0 para sair)”);

While(true)
      {
    ValorCompra = Convert.ToDouble(Console.ReadLine());
    If(ValorCompra == 0) break;
    TotalCompras += ValorCompra;
}
Console.WriteLine($”Valor total da compra: { TotalCompras}”);


Do while

Double totalCompras = 0;
Double valorCompra;


Do

{

Console.WriteLine(“Digite o valor das compras (0 para sair):”);

valorCompra = Convert.ToDouble(Console.ReadLine());

if (valorCompra != 0) totalCompras += valorCompra;

} while (valorCompra != 0) ;

Console.WriteLine($”Total de compras: { totalCompras}”);


For


Double TotalCompras = 0;
Double ValorCompra;


Do
      {
      
       Console.WriteLine(“Digite o valor das compras: (0 para sair)”);


ValorCompra = Convert.ToDouble(Console.ReadLine());
If(ValorCompra != 0)
          TotalCompras += ValorCompra;
      } while (ValorCompra != 0) ;
Console.WriteLine($”Valor total da compra: { TotalCompras}”);

Ex10.

10.Um vendedor de passagens deseja saber quantas passagens ele vendeu em um 

Dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até 

Que ele digite um valor negativo. O total de passagens vendidas deve ser calculado 

E apresentado utilizando while, do while e for.
While

Int TotalPassagem = 0;
Double ValorPassagens;
Console.WriteLine(“Digite o valor das passagens vendidas: (valor negativo para sair)”);
While(true)
      {


    ValorPassagens = Convert.ToDouble(Console.ReadLine());
    If(ValorPassagens <= 0) break;
    TotalPassagem++;
}
Console.WriteLine($”Total de passagems vendidas { TotalPassagem}”);


Do while



Int TotalPassagem = 0;
Double ValorPassagens;


Do
      {
      
      Console.WriteLine(“Digite o valor das passagens vendidas:  (valor negativo para sair)”);


ValorPassagens = Convert.ToDouble(Console.ReadLine());
If(ValorPassagens >= 0)
          TotalPassagem++;
          
      } while (ValorPassagens >= 0) ;
Console.WriteLine($”Total de passagems vendidas { TotalPassagem}”);


For
Int TotalPassagem = 0;
Double ValorPassagens;
For(; ;)
      {
    Console.WriteLine(“Digite o valor das passagens vendidas: (valor negativo para sair)”);
    ValorPassagens = Convert.ToDouble(Console.ReadLine());
    If(ValorPassagens < 0) break;
    TotalPassagem++;

}
Console.WriteLine($”Total de passagems vendidas { TotalPassagem}”);
