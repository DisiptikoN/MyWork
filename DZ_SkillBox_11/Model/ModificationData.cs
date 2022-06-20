using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_SkillBox_11.Model;
using DZ_SkillBox_11.View;

namespace DZ_SkillBox_11.Model
{
    public struct ModificationData
    {


        public string EditorName; // редактированное имя
        public string EditorType; // как изменили добавление/редактирование
        public DateTime EditData; // дата изминения
        public string PrevDataState; // данные изминения 
        public int WorkerId; // идентификатор работника  

        public void EditClientData(BankClient bankClient, string WhoChangeds, string TypeEdit)
        {
            ModificationData mod = new ModificationData();
            mod.EditorName = WhoChangeds;
            mod.EditorType = TypeEdit;
            mod.PrevDataState = bankClient.Name;
            mod.EditData = DateTime.Now;
            mod.WorkerId = bankClient.ClientId;
            BankClient.EditHistory.Add(mod);
           
        }


    }
}
