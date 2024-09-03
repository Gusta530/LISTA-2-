/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
* Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
* Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
* Mana maior que 30.
* Vida do inimigo menor que 50%.
* Nível do jogador maior que 5.


@Lista: 02 - Condicionais
@Autor: Luís Gustavo Serafim de Souza 
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        int qm, qva, snv;
        
        Console.WriteLine ("Informe a quantidade de mana:");
        int.TryParse(Console.ReadLine(), out qm);
        
        Console.WriteLine ("Informe a quantidade de vida do adversario:");
        int.TryParse(Console.ReadLine(), out qva);
        
        Console.WriteLine ("Informe o seu nível:");
        int.TryParse(Console.ReadLine(), out snv);
        
        if(qm > 30 && qva < 50 && snv > 5)
        {
            Console.WriteLine("Ataque Especial realizado");
        }
         if(qm < 30 && qva < 50 && snv > 5)
        {
            Console.WriteLine("Mana insuficiente");
        }
         if(qm > 30 && qva > 50 && snv > 5)
        {
            Console.WriteLine("Vida do inimigo muito alta");
        }
         if(qm > 30 && qva < 50 && snv < 5)
        {
            Console.WriteLine("Nível insuficiente");
        }
      
    }
}