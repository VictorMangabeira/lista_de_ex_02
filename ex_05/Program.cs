// 5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0. Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição.



using System.ComponentModel;

Ex5
2
5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve
Solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até
Que ele digite 0. Depois disso, o programa deve calcular a quantidade total de
Produtos em estoque, utilizando as três estruturas de repetição.
While
Int totalEstoque = 0;
Int recebidos, vendidos;

Console.WriteLine(“Digite a quantidade de produtos recebidos e vendidos(digite 0 para sair)”);
While(true)
       {
    Console.Write(“Recebidos: “);
    Recebidos = Convert.ToInt32(Console.ReadLine());
    If(recebidos == 0) break;
    Console.Write(“Vendidos: “);
    Vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos – vendidos;
}
Console.WriteLine($”Total de produtos em estoque: { totalEstoque}”);
Do while
Int totalEstoque = 0;
Int recebidos, vendidos;

Do
       {
           Console.WriteLine(“Digite a quantidade de produtos recebidos e vendidos: (digite 0 para saie)”);
Console.Write(“recebidos: “);
Recebidos = Convert.ToInt32(Console.ReadLine());
Console.Write(“vendidos: “);
If(recebidos == 0) break;
Vendidos = Convert.ToInt32(Console.ReadLine());
totalEstoque += recebidos – vendidos;
           
       } while (true) ;
Console.WriteLine($”Total em estoque: { totalEstoque}”);
For
Int totalEstoque = 0;
Int recebidos, vendidos;

For(; ;)
   {
    Console.WriteLine(“Digite os produtos recebidos e vendidos: “);
    Console.Write(“recebidos: “);
    Recebidos = Convert.ToInt32(Console.ReadLine());
    If(recebidos == 0) break;
    Console.Write(“vendidos: “);
    Vendidos = Convert.ToInt32(Console.ReadLine());
    totalEstoque += recebidos – vendidos;
}
Console.WriteLine($”Total em estoque: { totalEstoque}”);