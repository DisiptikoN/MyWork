using DZ_SkillBox_11.View;
using System;


namespace DZ_SkillBox_11.Model
{

    public class ActionsAddDeleteEdit : MainWindow
    {

        /// <summary>
        /// Добавление клиента 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="patronymic"></param>
        /// <param name="numberPassport"></param>
        /// <param name="seriesPassport"></param>
        /// <param name="numberPhone"></param>
        /// <param name="DpId"></param>
        /// <param name="WorkerId"></param>
        public static void AddClient(string name,
                                     string lastName,
                                     string patronymic,
                                     string numberPassport,
                                     string seriesPassport,
                                     string numberPhone,
                                        int DpId,
                                        int WorkerId)
        {
            Repository.bankClients.Add(new BankClient(name, lastName, patronymic, numberPhone, seriesPassport, numberPassport, DpId, WorkerId));
        }

        /// <summary>
        /// Редактирование клиента
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="patronymic"></param>
        /// <param name="numberPassport"></param>
        /// <param name="seriesPassport"></param>
        /// <param name="numberPhone"></param>
        /// <param name="DpId"></param>
        /// <param name="WorkerId"></param>
        public static void EddClient(string name, string lastName, string patronymic, string numberPassport, string seriesPassport, string numberPhone, int DpId, int WorkerId)
        {
            foreach (var item in Repository.bankClients)
            {
                if (WorkerId == item.ClientId)
                {
                    item.Name = name;
                    item.Lastname = lastName;
                    item.Patronymic = patronymic;
                    item.NumberPassport = numberPassport;
                    item.SeriesPassport = seriesPassport;
                    item.PhoneNumber = numberPhone;
                    item.DepartmentId = DpId;
                    item.dateTime = DateTime.Now;

                }


            }

        }
    }
}
