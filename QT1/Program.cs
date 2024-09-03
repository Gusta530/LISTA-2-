/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
* Contextualização: Em um jogo de RPG, o jogador precisa inserir
as informações básicas do personagem antes de começar a aventura.
* Comando: Crie um programa que receba o nome, idade, nível inicial,
classe, e raça do personagem e exiba esses dados no console.

@Lista: 02 - Condicionais
@Autor: Luís Gustavo Serafim de Souza
@Data: 24/08/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
string icp;
int ivd, ipa;

Console.WriteLine("Informe a classe do personagem: ");
icp = Console.ReadLine();

Console.WriteLine("Informe o valor da defesa: ");
int.TryParse(Console.ReadLine(), out ivd);

Console.WriteLine("Informe a penalidade de agilidade: ");
int.TryParse(Console.ReadLine(), out ipa);

if (icp == "guerreiro")
{
    if (ivd > 50 && ipa < 20)
    {
        Console.WriteLine("Armadura adequada");
    }
}
    if (icp == "arqueiro")
    {
        if (ivd > 30 && ipa < 10)
        {
            Console.WriteLine("Armadura adequada");
        }
    }
    if (icp == "mago")
    {
        if (ivd > 20 && ipa < 40)
        {
            Console.WriteLine("Armadura adequada");
        }
    }
        else
        {
            Console.WriteLine("Armadura inadequada");
        }
    }
}