/*3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao digitar -1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram nota maior ou
 * igual a 6, utilizando as três estruturas de repetição.
 * 
 */

using System.ComponentModel;
using System.Net;

Ex3
3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O
Aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao
Digitar -1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram
Nota maior ou igual a 6, utilizando as três estruturas de repetição.
While
Int alunosAprovados = 0;
Double nota;

Console.WriteLine(“Digite as notas dos alunos: (Digite - 1 para sair) “);
While(true)
       {
    Nota = Convert.ToDouble(Console.ReadLine());
    If(nota == -1) break;
    If(nota >= 6) alunosAprovados++;
}
Console.WriteLine($”Total de alunos aprovados: { alunosAprovados}”);
Do while
Int alunosAprovados = 0;
Double nota;

Do{
           Console.WriteLine(“Digite as notas dos alunos: (digite - 1 para sair) “);
Nota = Convert.ToDouble(Console.ReadLine());
If(nota >= 6 && nota != -1) alunosAprovados++;
           
       } while (nota != -1) ;
Console.WriteLine($”Total de alunos aprovados: { alunosAprovados}”);
For
Int alunosAprovados = 0;
Double nota;

For(; ;){
    Console.WriteLine(“Digite as notas dos alunos: (digite - 1 para sair)”);
    Nota = Convert.ToDouble(Console.ReadLine());
    If(nota == -1) break;
    If(nota >= 6) alunosAprovados++;
}
Console.WriteLine($”Total de alunos aprovados: { alunosAprovados}”);