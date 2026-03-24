/*
Robô Tupiniquim

Especificação
A Agência Espacial Brasileira (AEB) contratou a Academia do Programador para
desenvolver o software de guia do Robô Tupiniquim I, que fará análises em Marte. O robô
explorará uma área retangular dividida em um grid.
Sobre o Sistema
● Posição e Orientação: A posição do robô é dada por coordenadas (X, Y) e uma
letra que representa a direção para onde ele está olhando (Norte, Sul, Leste, Oeste).
● Comandos: A AEB envia strings de comando simples (E, D, M):
1. E (Esquerda) e D (Direita) fazem o robô virar 90 graus, sem sair do lugar.
2. M (Mover) move o robô uma posição no grid para frente, mantendo a direção.

Exemplo

Input:
Digite a posição inicial: 1 2 N
Digite a sequência de comandos: EMEMEMEMM

Output Esperado:
Posição alcançada: 1 3 N

O programa receberá os comandos de exploração em duas partes para o robô:
1. A posição inicial, dada por 2 inteiros (X e Y) e uma letra (Orientação), separados
por espaços.
2. Uma série de instruções (E, D, M) que o robô deve seguir.
Após mover o robô, o programa deve retornar sua posição final (X Y) e sua orientação.
*/

public class Program
{

    static void ExibirCabecalho()
    {
        System.Console.WriteLine("---------------------");
        System.Console.WriteLine("ROBO TUPINIQUIM");
        System.Console.WriteLine("---------------------");
    }

    static char[] ExecutarComandos(int x, int y, char c, string d, int indice)
    {
       char[] direcoes = ['N','L','S','O'];
       
        for (int i = 0; i < direcoes.Length; i++)
        {
            if (direcoes[i] == c)
            {
                indice = i;
                break;
            }
        }

        
        for (int i = 0; i < d.Length; i++)
        {
            char comandos = d[i];

            if (comandos == 'E')
            {
                indice = (indice - 1 + 4) % 4;
            }
            else if (comandos == 'D')
            {
                indice = (indice + 1) % 4;
            }
            else if (comandos == 'M')
            {
                if (direcoes[indice] == 'N') y++;
                if (direcoes[indice] == 'S') y--;
                if (direcoes[indice] == 'L') x++;
                if (direcoes[indice] == 'O') x--;
                
            }
            
        }
        System.Console.WriteLine($"Posição final: {x},{y},{direcoes[indice]}");
        return direcoes;
        
    }

    public static void Main(string[] args)
    {

        int x, y; //cordenadas
        char c; //direção (norte = N, sul = s, oeste = O, leste = L)
        string? d; //comandos do robo (e = esquerda, d = direita, m = mover)
        int indice = -1;


        ExibirCabecalho();
        System.Console.Write("Informe a posição inicial (x,y) e a direção que o robo esta (c): ");
        var input = Console.ReadLine()?.Split(' ');
        x = int.Parse(input[0]);
        y = int.Parse(input[1]);
        c = char.Parse(input[2].ToUpper());

        /*
        Cria uma variavel para ler a linha inteira e usa .Split para retornar um array de 
        substrings com base no caracter (' ') permitindo ler os valores numa mesma linha
        e os acessando com os indices (x = int.Parse(input[0])) e assim por diante
        */

        System.Console.Write("Informe os comandos do robo:");
        d = Console.ReadLine()?.ToUpper();

        Console.Clear();
        System.Console.WriteLine($"Posição Inicial: {x},{y},{c}");

        /*
        crie um vetor com as direcoes possiveis (N,L,O,S) e o fiz percorrer um loop
        para sempre preencher o inicio dele com a direção informada pelo usuario na variavel "c"
        o - 1 é para caso o valor nao esteja dentro das opcoes de direcao
        */
      char[] direcoes = ExecutarComandos(x,y,c,d,indice);
        /*
        criei outro loop do tamanho da string dos comandos e dentro dele crie outro vetor char
        para que cada letra seja interpretada como um comando diferente.
        no caso do comando ser E o calculo faz que a direcao sempre volte um ou seja, N vai para O e assim por diante.
        no caso de de ser D faz o calculo para sempre avançar uma direcao, entao N vira L e assim segue.
        no caso de M as posicoes X e Y sao incrementadas ou decrementadas de acordo com a direcao que o robo esta
        */

       

}
}