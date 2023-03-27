using System;

namespace DZ_SkillBox_11.Model
{
    public class Manager : Worker, IActionWhithTheClient
    {
        public Manager(string Name, int Id) : base(Name, Id)
        {
            this.Name = Name;
            this.Id = Id;
        }

        public Manager()
        {

        }



        void IActionWhithTheClient.AddClient(string name,
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


        public void EditClient(string name,
                               string lastName,
                               string patronymic,
                               string numberPassport,
                               string seriesPassport,
                               string numberPhone,
                               int DpId,
                               int WorkerId)
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

        public void RemoveClient()
        {
            throw new System.NotImplementedException();
        }
    }
}
