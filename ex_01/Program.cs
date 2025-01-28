/* Ex_01
 * Um funcionario deseja contar quantos dias de trabalho ele leva em um mês. Para isso, ele deve inserir os dias trabalhandos (de 1 a 31) até que digite 0, que indica que terminou de informa os dias. O Aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for.
 */


using System.ComponentModel;
using System.Security.Cryptography;

Ex - 1
Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. Para
Isso, ele deve inserir os dias trabalhados (de 1 a 31) até que digite 0, que indica que
Terminou de informar os dias. O aluno deve implementar essa contagem utilizando
As estruturas de repetição while, do while e for.
While-
Int diasTrabalhados = 0;
Int dia;
Console.WriteLine(“Digite os dias trabalhados: (0 para sair)”);
While(true){
    Dia = Convert.ToInt32(Console.ReadLine());
    If(dia == 0) break;
    diasTrabalhados++;
}
Console.WriteLine($”Total de dias trabalhados: { diasTrabalhados}”);
DO WHILE
Int diasTrabalhados = 0;
Int dia;

Do{
           Console.WriteLine(“Digite os dias trabalhados (0 para sair)”);
Dia = Convert.ToInt32(Console.ReadLine());
If(dia != 0)
           diasTrabalhados++;
       } while (dia != 0) ;
Console.WriteLine($”Total de dias trabalhados: { diasTrabalhados}”);
For
Int diasTrabalhados = 0;
Int dia;

For(; ;){
    Console.WriteLine(“Digite os dias trabalhados: (0 para sair)”);
    Dia = Convert.ToInt32(Console.ReadLine());
    If(dia == 0) break;
    diasTrabalhados++;
}
Console.WriteLine($”Total de dias trabalhados: { diasTrabalhados}”);

