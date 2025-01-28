//8. Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0. O programa deve calcular o total de minutos atendidos, utilizando while, do while e for.


using System.ComponentModel;

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