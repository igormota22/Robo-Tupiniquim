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

    public static void Main(string[] args)
    {

        int indice = -1;

        ExibirCabecalho();
        var (x, y, c, d) = Robo.LerDadosDeEntrada();

        char[] direcoes = Robo.ExecutarComandos(x, y, c, d, indice);

    }


  private  static void ExibirCabecalho()
    {
        System.Console.WriteLine("---------------------");
        System.Console.WriteLine("ROBO TUPINIQUIM");
        System.Console.WriteLine("---------------------");
    }





}