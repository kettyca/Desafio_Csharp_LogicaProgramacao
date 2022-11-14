int i = 0, a = 1, quantidade;
double media = 0, soma = 0, notaMaxima, notas; 
string condicao = "";
bool verificaMax = true, verificaQntd = true, verificaNota = true, verificaSeCont = true;


Console.WriteLine("\n                          . . . . . . . . . . . .");
Console.WriteLine("\n Preencha as seguintes informações para fazer as médias trimestrais: ");

do {
    /*           ****** Verifica qual o valor máximo da nota ******            */
    do {
        Console.Write("\n -> Escolha um valor para a nota máxima da avaliação (10 ou 100): ");
        notaMaxima = Convert.ToDouble(Console.ReadLine());

        if (notaMaxima != 10 && notaMaxima != 100) {
            verificaMax = false;
            Console.WriteLine("\n    Está opção não é válida. Por favor, tente novemente!");
        } else 
            verificaMax = true;

    } while (verificaMax != true);

    Console.WriteLine("\n . . . . . . . .");
    Console.Write($" Aluno(a) {a}\n");

    do {
        Console.Write("\n    Quantidade de avaliações aplicadas: ");
        quantidade = Convert.ToInt32(Console.ReadLine());
        
        if (quantidade > 10) {
            verificaQntd = false;
            Console.WriteLine("\n\tA quantidade máxima de avaliações é 10. Por favor, tente novemente!");
        } else 
            verificaQntd = true;

    } while (verificaQntd != true);

    /*                 ****** Faz a média do aluno(a) ******                   */
    for (i = 1; i <= quantidade; i++ ) {
        do {
            Console.Write($"\n\tNota {i}: ");
            notas = Convert.ToDouble(Console.ReadLine());

            if(notas > notaMaxima) {
                verificaNota = false;
                Console.WriteLine($"\n    A nota máxima de uma avaliação é {notaMaxima}. Por favor, digite um número entre 0 e {notaMaxima}!");
            } else    
                verificaNota = true;
        } while (verificaNota != true);

        soma =  soma + notas;
        media = soma / quantidade; 
    } 
    
    Console.Write($"\n    >>> Média do aluno(a) {a}: " + media.ToString("0.00") + "\n");
    
    /*          ****** Verifica se o aluno(a) passou na matéria ******         */
    if (notaMaxima == 10)  {
        if (media >= 6)
            Console.WriteLine("\n    O aluno(a) passou na matéria!! :)");
        else
            Console.WriteLine("\n    O aluno(a) precisará fazer o Exame final! :|");
    } else
        if (media >= 60)
            Console.WriteLine("\n    O aluno(a) passou na matéria!! :)");
        else
            Console.WriteLine("\n    O aluno(a) precisará fazer o Exame final! :|");

    /*      ****** Verifica se o(a) professor(a) deseja continuar ******       */
    do {
        Console.Write("\n\n -> Deseja fazer a média de OUTRO(A) aluno(a)? [s/n]: ");
        condicao = Console.ReadLine();

        if (condicao != "s" && condicao != "S" && condicao != "n" && condicao != "N") {
            verificaSeCont = false;
            Console.WriteLine("\n    Opção não válida. Por favor, tente novamente!"); 
        } else 
            verificaSeCont = true;

    } while (verificaSeCont != true);
   
    if (condicao == "s" || condicao == "S")
        a++;
    else if (condicao != "n" || condicao != "N") {
        Console.WriteLine("\n O programa será encerrado. \n\tObrigada por utilizá-lo! :)");
        Console.WriteLine("\n                          . . . . . . . . . . . .\n\n");
    }

} while (condicao == "s" || condicao == "S");

