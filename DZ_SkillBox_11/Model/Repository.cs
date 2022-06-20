using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DZ_SkillBox_11.Model
{
    public class Repository
    {
        static Random r;

        static Repository() { r = new Random(); }



        public static List<BankClient> bankClients = new List<BankClient>();
        public static List<Department> departments = new List<Department>();
        public static List<Worker> workers = new List<Worker>();

        private Repository() { }

        /// <summary>
        /// Создание сотрудников
        /// </summary>
        /// <param name="CountClient"></param>
        /// <param name="CountDepartments"></param>
        private Repository(int CountClient, int CountDepartments)
        {


            bankClients = new List<BankClient>();
            departments = new List<Department>();

            if (bankClients != null)
            {
                for (int i = 0; i < CountClient; i++)
                {
                    bankClients.Add(new BankClient($"Name{i + 1}",
                        $"LastName{i + 2}",
                        $"Patronymic{i + 2}",
                        "89131233212",
                        $"{r.Next(1000, 10000)}",
                        $"{r.Next(1000, 10000)}",
                        r.Next(1, 11),
                        i));
                }
            }



           
           
            if (departments != null)
            {
                for (int i = 0; i < CountDepartments; i++)
                {
                    departments.Add(new Department($"Department_{i + 1}", i));
                }
            }
        }

        /// <summary>
        /// Создание руководителей
        /// </summary>
        public static List<Worker> RepositorySupervisor() 
        {
           List<Worker> workers = new List<Worker>();

            workers.Add(new Manager("Менеджер", 1));
            workers.Add(new Consultant("Консультант", 2));

            return workers;

        }

        public static Repository CreateRepository(int CountClient = 50, int CountDepartments = 10)
        {
            return new Repository(CountClient, CountDepartments);
        }   
    }
}
