// 4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A solução deve ser implementada usando while, do while e for./


using System.ComponentModel;

Ex4
4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve
Pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A
Solução deve ser implementada usando while, do while e for.
While
Double somaIdades = 0;
Int contador = 0;
Int idade;

Console.WriteLine(“Digite as idades (digite 0 para sair”);
While(true) {
    Idade = Convert.ToInt32(Console.ReadLine());
    If(idade == 0) break;
    somaIdades += idade;
    contador++;
}
Double mediaIdades = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($”Medias das idades: { mediaIdades}”);
Do while
Int somaIdades = 0;
Int contador = 0;
Int idade;

Do
        {
            Console.WriteLine(“Digite as idades: (Digite 0 para sair)”);
Idade = Convert.ToInt32(Console.ReadLine());
If(idade != 0)
            {
    somaIdades += idade;
    contador++;
}
        } while (idade != 0) ;
somaIdades = contador > 0 ? somaIdades / contador : 0;
Console.WriteLine($”A media das idades: { somaIdades}”);
For
Int mediaIdade = 0;
Int contador = 0;
Int idade;

For(; ;)
      {
    Console.WriteLine(“Digite as idades: (0 para sair)”);
    Idade = Convert.ToInt32(Console.ReadLine());
    If(idade == 0) break;
    mediaIdade += idade;
    contador++;
}
mediaIdade = contador > 0 ? mediaIdade / contador : 0;
Console.WriteLine($”Media das idades: { mediaIdade}”);