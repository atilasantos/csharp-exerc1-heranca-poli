using Exercicio1HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio1HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int quantityEmployees = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantityEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");

                Console.Write("Outsourced? true/false: ");
                bool terceiro = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
             
                Employee employee;

                if (terceiro)
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employee = new OutsourcedEmployee(nome, hours, valuePerHour, additionalCharge);
                }
                else
                {
                    employee = new Employee(nome, hours, valuePerHour);
                }

                listEmployees.Add(employee);
            }

            Console.WriteLine("PAYMENTS:");
            foreach (var employee in listEmployees)
            {
                Console.WriteLine(employee);
            }

        }
    }
}
