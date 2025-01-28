// 9. Um cliente deseja saber o total de suas compras em um supermercado. O aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A soma dos valores das compras deve ser implementada usando as três estruturas de repetição.


using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;

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