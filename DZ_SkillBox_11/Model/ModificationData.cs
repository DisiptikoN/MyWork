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

        public void EditClientData(Worker worker)
        {
            ModificationData mod = new ModificationData();
            mod.EditorName = worker.Name;
            mod.PrevDataState = worker.Name;
            mod.EditData = DateTime.Now;
            worker.EditHistory.Add(mod);
        }


    }
}
