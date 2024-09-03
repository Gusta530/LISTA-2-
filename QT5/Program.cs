/*-------------------------------------------------------------------
Questão 5: Resgate no Labirinto
* Contextualização: Em uma missão de resgate em um jogo, o jogador deve decidir se continua
em frente para resgatar um aliado ou recua, considerando a vida restante, o número de
armadilhas conhecidas no caminho e a distância do aliado.
* Comando: Crie um programa que receba a porcentagem de vida do jogador, o número de
armadilhas conhecidas no caminho e a distância do aliado em metros. O programa deve decidir
se o jogador deve seguir em frente, tentar um resgate rápido, ou recuar, conforme as seguintes
condições:
* Se a vida for maior que 50% e as armadilhas forem menores que 3, seguir em frente.
* Se a vida for menor que 50%, as armadilhas forem menores que 2, e a distância do aliado for
menor que 10m, tentar resgate rápido.
* Caso contrário, recuar.


@Lista: 02 - Condicionais
@Autor: Luís Gustavo Serafim de Souza
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{       //se o jogador deve seguir em frente, tentar um resgate //rápido, ou recuar
    public static void Main(string[] args)
    {
            int pvida, acc, dam;
           Console.WriteLine("porcentagem de vida");
           int.TryParse(Console.ReadLine(), out pvida);
            Console.WriteLine("o número de armadilhas conhecidas no caminho");
            int.TryParse(Console.ReadLine(), out acc);
           Console.WriteLine("a distância do aliado em metros.");
           int.TryParse(Console.ReadLine(), out dam);
           
           if(pvida > 50 && acc < 3)
           {
               Console.WriteLine("Seguir em frente");
              
           }
           if(pvida < 50 && acc < 2 && dam < 10)
           {
               Console.WriteLine("Tentar resgate rápido");
           }
           else{
               Console.WriteLine("Recuar");
           }
    }
        
}