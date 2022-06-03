using DZ_SkillBox_11.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DZ_SkillBox_11.Model
{


    public class Worker
    { 


        /// <summary>
        /// Индетификатор сотрудника
        /// </summary>
        private int departmentId;

        /// <summary>
        /// Имя сотрдуника
        /// </summary>
        private string name;

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        private string lastname;

        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        private string patronymic;

        /// <summary>
        /// Номер телефона сотрудника
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Серия паспорта сотрудника
        /// </summary>
        private string seriesPassport;

        /// <summary>
        /// Номер паспорта сотрудника
        /// </summary>
        private string numberPassport;

        /// <summary>
        /// Время изминения данных
        /// </summary>
        public DateTime dateTime { get; set; }

        public int WorkerId { get; set ; }


   

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

        public string WhoChanged { get;set; }

        
        public Worker()
        {

        }

        public Worker(string Name, string Lastname, string Patronymic, string NumberPhone, string SeriesPassport, string NumberPassport, int DpId, int WorkerId)
        {
            this.DepartmentId = DpId;
            this.Name = Name;
            this.Lastname = Lastname;
            this.Patronymic = Patronymic;
            this.PhoneNumber = NumberPhone;
            this.SeriesPassport = SeriesPassport;
            this.NumberPassport = NumberPassport;
            this.WorkerId = WorkerId;
            this.dateTime = DateTime.Now;
            
        }

        public List<ModificationData> EditHistory = new List<ModificationData>();
        public override string ToString()
        {
            return $"{Name,7} {Lastname,15} {Patronymic,15} {PhoneNumber,10} {SeriesPassport,10} {NumberPassport,5}";
        }
    }
}
