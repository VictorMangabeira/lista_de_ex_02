/* 2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário que insira suas despesas até que ele digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while e for.
 * 
 * 
 * 
 * Ex2
2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar
Ao usuário que insira suas despesas até que ele digite um valor negativo,
Sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total,
Utilizando while, do while e for.
While
Double despesas = 0;
        Double despesa;
        Console.WriteLine(“Digite suas despesas: (valor negativo pasa sair)”);
        While (true){
            Despesa = Convert.ToDouble(Console.ReadLine());
            If (despesa < 0) break;
            Despesas += despesa;
        }
        Console.WriteLine($”Total de despesas: {despesas}”);
Do while
Double despesas = 0;
       Double despesa;
        Do {
            Console.WriteLine(“Digite suas despesas: (valor negativo para sair)”);
            Despesa = Convert.ToDouble(Console.ReadLine());
            If(despesa >= 0) despesas += despesa;
        } while (despesa >= 0);
        Console.WriteLine($”Total de despesas: {despesas}”);
For
Double despesas = 0;
       Double despesa;
       For (;;)
       {
           Console.WriteLine(“Digite suas despesas: (valor negativo para sair)”);
           Despesa = Convert.ToDouble(Console.ReadLine());
           If (despesa < 0) break;
           Despesas += despesa;
       }
       Console.WriteLine($”Total de despesas: {despesas}”);