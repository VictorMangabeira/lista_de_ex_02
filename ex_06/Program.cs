//6. Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0. O programa deve contar quantos votos cada candidato recebeu, implementando a solução com while, do while e for


using System.ComponentModel;

Ex6
6. Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao
Usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele
Digite 0. O programa deve contar quantos votos cada candidato recebeu,
Implementando a solução com while, do while e for.
While
Int votosA = 0;
Int votosB = 0;
Int voto;

Console.WriteLine(“Digite os votos: (1 para candidato A e 2 para candidado B e 0 para sair)”);
While(true)
        {
    Voto = Convert.ToInt32(Console.ReadLine());
    If(voto == 0) break;
    If(voto == 1) votosA++;
    Else if (voto == 2) votosB++;

}
Console.WriteLine($”Candidado A: { votosA}
votos, Candidado B: { votosB}
votos”);
Do while
Int votosA = 0;
Int votosB = 0;
Int voto;

Do
        {
            Console.WriteLine(“Digite os votos: (Digite 1 para candidato A, 2 para candidato B e 0 para sair)”);
Voto = Convert.ToInt32(Console.ReadLine());
If(voto == 1) votosA++;
Else if (voto == 2) votosB++;
        } while (voto != 0) ;
Console.WriteLine($”Candidato A: { votosA}
votos, Candidato B {votosB}”);
For
Int votosA = 0;
Int votosB = 0;
Int voto;

For(; ;)
        {
    Console.WriteLine(“Digite os votos: (1 para candidato A, 2 para candidato B e 0 para sair)”);
    Voto = Convert.ToInt32(Console.ReadLine());

    If(voto == 0) break;
    If(voto == 1) votosA++;
    Else if (voto == 2) votosB++;

}
Console.WriteLine($”Candidato A: { votosA}
votos, Candidado B: { votosB}
votos”);