/* Ex_01
 * Um funcionario deseja contar quantos dias de trabalho ele leva em um mês. Para isso, ele deve inserir os dias trabalhandos (de 1 a 31) até que digite 0, que indica que terminou de informa os dias. O Aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for.
 */

/*int diasTrabalhados = 0;
int dias;

Console.WriteLine("Digite os dias trabalhados (0 para sair):");

while (true)
{
    dias = Convert.ToInt32(Console.ReadLine());
    if ( dias == 0 ) break;
    diasTrabalhados++;

}
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");*/

int diasTrabalhados = 0;
int dias;

do
{
    Console.WriteLine("Digite os dias trabalhados ( 0 para sair):");
    dias = Convert.ToInt32(Console.ReadLine());
    if (dias != 0 ) diasTrabalhados++;
}
while (dias != 0);
