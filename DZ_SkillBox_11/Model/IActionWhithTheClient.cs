using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_SkillBox_11.Model
{
    internal interface IActionWhithTheClient
    {
        void AddClient(string name,
                                     string lastName,
                                     string patronymic,
                                     string numberPassport,
                                     string seriesPassport,
                                     string numberPhone,
                                        int DpId,
                                        int WorkerId);
        void RemoveClient();
        void EditClient(string name, string lastName, string patronymic, string numberPassport, string seriesPassport, string numberPhone, int DpId, int WorkerId);
    }
}
