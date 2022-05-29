using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DZ_SkillBox_11.Model
{
    public class Repository
    {
        static Random r;

        static Repository() { r = new Random(); }



        public static List<Worker> workers = new List<Worker>();
        public static List<Department> departments = new List<Department>();
        public static List<Supervisor> supervisors = new List<Supervisor>();

        private Repository() { }

        /// <summary>
        /// Создание сотрудников
        /// </summary>
        /// <param name="CountWorker"></param>
        /// <param name="CountDepartments"></param>
        private Repository(int CountWorker, int CountDepartments)
        {


            workers = new List<Worker>();
            departments = new List<Department>();

            if (workers != null)
            {
                for (int i = 0; i < CountWorker; i++)
                {
                    workers.Add(new Worker($"Name{i + 1}",
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
        public static List<Supervisor> RepositorySupervisor()  /// РАЗОБРАТЬ
        {
           List<Supervisor> supervisors = new List<Supervisor>();

            supervisors.Add(new Manager("Менеджер", 1));
            supervisors.Add(new Consultant("Консультант", 2));

            return supervisors;

        }

        public static Repository CreateRepository(int CountWorker = 50, int CountDepartments = 10)
        {
            return new Repository(CountWorker, CountDepartments);
        }   
    }
}
