using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Seja Bem Vindo! :)");


void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para calcular a soma dos números de 1 a 10");
    Console.WriteLine("Digite 2 para calcular o IMC");
    Console.WriteLine("Digite 3 para acessar a calculadora");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: SomaDeNumeros();
            break;
        case 2: CalculoImc();
            break;
        case 3: Calculadora();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void SomaDeNumeros()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Soma de Números");
    Console.WriteLine("**********************\n");

    int soma = 0;
    for (int i = 1; i <= 10; i++)
    {
        soma += i;
        Console.WriteLine($"Resultado: {soma}");
    }

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void CalculoImc()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Calculo de IMC");
    Console.WriteLine("**********************\n");

    Console.Write("Informe seu peso(KG): ");
    float peso = float.Parse(Console.ReadLine());

    Console.Write("\nInforme sua altura(M): ");
    float altura = float.Parse(Console.ReadLine());

    float imc = peso / (altura * altura);

    if (imc < 18.5)
    {
        Console.WriteLine($"\nO seu IMC  é {imc}\nVocê está abaixo do peso."); 
    }

    else if (imc > 18.5 & imc < 25)
    {
        Console.WriteLine($"\nO seu IMC  é {imc.ToString("N2")} \n Seu peso está normal.");
    }

    else if (imc > 18.5 & imc < 24.99)
    { Console.WriteLine("\n\nPeso Ideal"); }

    else if (imc > 25 & imc < 29.99)
    {
        Console.WriteLine($"\nO seu IMC  é {imc.ToString("N2")}\nVocê está acima do peso.");
    }

    else if (imc > 30 & imc < 34.49)
    {
        Console.WriteLine($"\nO seu IMC  é {imc.ToString("N2")}\nVocê está obeso.");
    }

    else if (imc > 35 & imc < 39.99)
    {
        Console.WriteLine($"\nO seu IMC  é {imc.ToString("N2")}\nVocê está com obesidade severa.");
    }

    else if (imc > 40)
    {
        Console.WriteLine($"\nO seu IMC  é {imc.ToString("N2")}\nVocê está com obesidade morbida.");
    }

    else
    {
        Console.WriteLine("\n\nNão Reconhecido");
    }

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void Calculadora()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Calculadora");
    Console.WriteLine("**********************\n");

    Console.Write("\nDigite o primeiro numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nDigite o segundo numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escolha uma das operacoes abaixo: ");
    Console.WriteLine("----------------------");
    Console.WriteLine("[1]. SOMA");
    Console.WriteLine("[2]. SUBTRACAO");
    Console.WriteLine("[3]. MULTIPLICACAO");
    Console.WriteLine("[4]. DIVISAO");
    Console.Write("Escolha = ");
    int op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            int result1 = num1 + num2;
            Console.WriteLine($"A soma entre {num1} e {num2} é igual = {result1}");
            break;
        case 2:
            int result2 = num1 - num2;
            Console.WriteLine($"A subtracao entre {num1} e {num2} é igual = {result2}");
            break;
        case 3:
            int result3 = num1 * num2;
            Console.WriteLine($"A multiplicao entre {num1} e {num2} é igual = {result3}");
            break;
        case 4:
            int result4 = num1 / num2;
            Console.WriteLine($"A divisao entre {num1} e {num2} é igual = {result4}");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.Write("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

ExibirOpcoesDoMenu();
