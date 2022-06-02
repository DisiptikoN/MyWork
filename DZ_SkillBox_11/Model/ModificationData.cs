using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_SkillBox_11.Model;
using DZ_SkillBox_11.View;

namespace DZ_SkillBox_11.Model
{
    internal struct ModificationData
    {

        // дата и время изменения записи;
        // какие данные изменены;
        // тип изменений;
        // кто изменил данные(консультант или менеджер).

        public void ChangedWorker(Worker worker, DateTime dateTime, string DataChanged, Supervisor supervisor)
        {
            worker.Name = worker.Name;


        }
    }
}
