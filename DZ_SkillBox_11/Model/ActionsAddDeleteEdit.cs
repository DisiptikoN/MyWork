using DZ_SkillBox_11.View;
using System.Collections.Generic;
using System.Linq;

namespace DZ_SkillBox_11.Model
{

    public class ActionsAddDeleteEdit : MainWindow
    {
        

        public static MainWindow mainWindow;
        public static Worker workers;
        public static List<Worker> worker;

        /// <summary>
        /// Добавление сотрудника 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="patronymic"></param>
        /// <param name="numberPassport"></param>
        /// <param name="seriesPassport"></param>
        /// <param name="numberPhone"></param>
        /// <param name="DpId"></param>
        /// <param name="WorkerId"></param>
        public static void AddWorker(string name, 
                                     string lastName, 
                                     string patronymic, 
                                     string numberPassport, 
                                     string seriesPassport, 
                                     string numberPhone, 
                                        int DpId, 
                                        int WorkerId)
        {         
            Repository.workers.Add(new Worker(name, lastName, patronymic, numberPhone, seriesPassport, numberPassport, DpId, WorkerId));            
        }
       
        /// <summary>
        /// Редактирование сотрудника
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="patronymic"></param>
        /// <param name="numberPassport"></param>
        /// <param name="seriesPassport"></param>
        /// <param name="numberPhone"></param>
        /// <param name="DpId"></param>
        /// <param name="WorkerId"></param>
        public static void EddWorker(string name, string lastName, string patronymic, string numberPassport, string seriesPassport, string numberPhone, int DpId, int WorkerId)
        {
            Repository.workers.Add(new Worker(name, lastName, patronymic, numberPhone, seriesPassport, numberPassport, DpId, WorkerId));
        }

           
        public static void TestCommit()
        {

        }
        
    }
}
