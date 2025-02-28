﻿using SolvedExerciseAboutEnum.Entities.Enums;
using System.Collections.Generic;

namespace SolvedExerciseAboutEnum.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Departament { get; set; }
        public List<HourContract> Contracts { get; set; }


        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department dept)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = dept;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mouth)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if ( contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
