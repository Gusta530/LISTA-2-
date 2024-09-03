/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.

@Lista: 02 - Condicionais
@Autor: Luís Gustavo Serafim de Souza 
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
            string clj, poc;
            int qtp, rsd;
            double total;
            
        Console.WriteLine ("Informe a classe do jogador:(guerreiro, mago, paladino)");
        clj = Console.ReadLine();
        
        Console.WriteLine ("Informe a porção que deseja comprar:(Vida, Mana, Resistência)");
        poc = Console.ReadLine();
        
        Console.WriteLine ("Informe a quantidade de porção:");
        int.TryParse(Console.ReadLine(), out qtp);
        
        if(poc == "vida")
        {
            rsd = 10 * qtp;
            Console.WriteLine($"Resultado sem desconto:{rsd}");
        }
        if(poc == "mana")
        {
        rsd = 15 * qtp;
        Console.WriteLine($"Resultado sem desconto:{rsd}");
        }
         if(poc == "resistencia")
        {
        rsd = 20 * qtp;
        Console.WriteLine($"Resultado sem desconto :{rsd}");
        }
        if(clj == "guerreiro" && poc == "vida")
        {
            rsd = (10 * qtp);
            total = rsd - (rsd * 0.1);
            Console.WriteLine($"O resultado sem desconto:{rsd}");
            Console.WriteLine($"Resultado com descoonto:{total}");
        }
        if(clj == "mago" && poc == "mana")
        {
            rsd = (15 * qtp);
            total = rsd - (rsd * 0.15);
             Console.WriteLine($"O resultado sem desconto:{rsd}");
            Console.WriteLine($"Resultado com descoonto:{total}");
        }
        if(clj == "paladino" && poc == "resistencia")
        {
            rsd = (20 * qtp);
           total = rsd - (rsd * 0.2);
             Console.WriteLine($"O resultado sem desconto:{rsd}");
           Console.WriteLine($"Resultado com desconto:{total}");
        }
     }
        
}