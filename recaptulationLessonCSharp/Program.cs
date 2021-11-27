﻿using System;
using System.Globalization;

class Program
{
    ContaBancaria account;
    static void Main(string[] args)
    {
        Console.Write("Entre com o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre com o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char resp = char.Parse(Console.ReadLine());

        if (resp == 's' || resp == 'S')
        {
            Console.Write("Entre com o valor de depósito inicial: ");
            double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account = new ContaBancaria(numero, titular, initialDeposit);
        }
        else
        {
            account = new ContaBancaria(numero, titular);
        }

        // Console.WriteLine();

        // Console.WriteLine("Dados da conta: ");
        // Console.Write("Conta: " + account);

        // Console.WriteLine();

        // Console.Write("Entre um valor para depósito: ");
        // account.deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Console.WriteLine("Dados atualizados:");
        // Console.Write("Conta " + account);

        // Console.Write("Entre um valor para saque: ");
        // account.withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
}