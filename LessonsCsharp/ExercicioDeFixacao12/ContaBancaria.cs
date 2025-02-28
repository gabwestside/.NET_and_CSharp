﻿using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao12 {
    class ContaBancaria {
        public int number { get; private set; }
        public string name { get; set; }
        public double balance { get; private set; }

        public ContaBancaria(int Number, string Name) {
            number = Number;
            name = Name;
        }
        public ContaBancaria(int Number, string Name, double initalDeposit) : this(Number, Name) {
            Deposito(initalDeposit);
        }

        public void Deposito(double deposit) {
            balance += deposit;
        }

        public void Saque(double withdraw) {
            balance -= withdraw + 5.0;
        }

        public override string ToString() {
            return number
                + ", Titular: "
                + name
                + ", "
                + balance.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}
