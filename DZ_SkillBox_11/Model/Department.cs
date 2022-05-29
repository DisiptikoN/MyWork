using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_SkillBox_11.Model
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }

        public Department(string Name, int Id)
        {
            DepartmentName = Name;
            DepartmentId = Id;
        }

        public Department()
        {

        }

        //public override string ToString()
        //{
        //    return $"{DepartmentName,15} {DepartmentId,3}";        
        //}
    }
}
