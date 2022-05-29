using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZ_SkillBox_11;
using DZ_SkillBox_11.Model;
using DZ_SkillBox_11.View;

namespace DZ_SkillBox_11.Model
{
    internal class ChangeProperties
    {
        public List<Supervisor> Changed(int Supervisor)
        {

            var name = Repository.RepositorySupervisor();

            if (Supervisor == 0)
            {
                 name = Repository.RepositorySupervisor();
            }
            else if (Supervisor == 1)
            {
                 name = Repository.RepositorySupervisor();
            }

           return name;
        }

        public void ChangedOut()
        {

        }
    }
}
