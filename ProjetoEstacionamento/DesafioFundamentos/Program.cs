﻿using DesafioFundamentos.Models;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("---------------------------------");
Console.WriteLine("$$$  BEM-VINDO AO ESTACIONAMENTO $$$");
Console.WriteLine("---------------------------------");
Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

void Menu()
    {
    Console.Clear();
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.WriteLine("\n");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("$$$  SISTEMA DE ESTACIONAMENTO  $$$");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("--------------Menu---------------");
    Console.WriteLine("| 1 |  Cadastrar veículo        |");
    Console.WriteLine("| 2 |  Remover veículo          |");
    Console.WriteLine("| 3 |  Listar veículos          |");
    Console.WriteLine("| 4 |  Encerrar                 |");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Digite a opção desejada:");
    string opcao = Console.ReadLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"||          Opção: {opcao}         ||");
    Console.WriteLine();

    switch (opcao)
        {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            Console.Write("Saindo");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine("\nObrigado por usar o sistema!");
            Thread.Sleep(1000);
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
        }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
    Menu();
    }

Menu();
