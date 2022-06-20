using DZ_SkillBox_11.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace DZ_SkillBox_11.Model
{
    public class BankClient
    {

        /// <summary>
        /// Индетификатор департамента клиента
        /// </summary>
        private int departmentId;

        /// <summary>
        /// Имя клиента
        /// </summary>
        private string name;

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        private string lastname;

        /// <summary>
        /// Отчество клиента
        /// </summary>
        private string patronymic;

        /// <summary>
        /// Номер телефона клиента
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Серия паспорта клиента
        /// </summary>
        private string seriesPassport;

        /// <summary>
        /// Номер паспорта клиента
        /// </summary>
        private string numberPassport;

        /// <summary>
        /// Время изминения данных
        /// </summary>
        ///
        public DateTime dateTime { get; set; }

        /// <summary>
        ///  Индетификатор  клиента
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Кто изменял данные
        /// </summary>
        public string WhoChanged { get; set; }

        public int DepartmentId
        {
            get
            {
                return departmentId;
            }

            set
            {
                departmentId = value;
            }

        }

        public string SeriesPassport
        {

            get
            {
                if (MainWindow.CombWiw == 0)
                {
                    return seriesPassport;
                }
                if (MainWindow.CombWiw == 1)
                {
                    return "******";
                }
                return seriesPassport;
            }
            set
            {
                seriesPassport = value;
            }
        }



        public string NumberPassport
        {

            get
            {

                if (MainWindow.CombWiw == 0)
                {
                    return numberPassport;
                }
                if (MainWindow.CombWiw == 1)
                {
                    return "******";
                }
                return "*";

            }
            set
            {
                numberPassport = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (MainWindow.CombWiw == 0)
                {
                    name = value;
                }
                if (MainWindow.CombWiw == 1)
                {
                    name = value;
                }
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
            }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        public static List<ModificationData> EditHistory = new List<ModificationData>();


        public BankClient()
        {

        }

        public BankClient(string Name, string Lastname, string Patronymic, string NumberPhone, string SeriesPassport, string NumberPassport, int DpId, int ClientId)
        {
            this.DepartmentId = DpId;
            this.Name = Name;
            this.Lastname = Lastname;
            this.Patronymic = Patronymic;
            this.PhoneNumber = NumberPhone;
            this.SeriesPassport = SeriesPassport;
            this.NumberPassport = NumberPassport;
            this.ClientId = ClientId;
            this.dateTime = DateTime.Now;

        }

        

        public override string ToString()
        {
            return $"{Name,7} {Lastname,15} {Patronymic,15} {PhoneNumber,10} {SeriesPassport,10} {NumberPassport,5}";
        }
    }

    
}
