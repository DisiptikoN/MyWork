

namespace DZ_SkillBox_11.Model
{
    public class Supervisor
    {
        

        string name;
        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Supervisor(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;           
        }

        public Supervisor()
        {
            this.Name = Name;

        }


        public override string ToString()
        {
            return $"{Name}";
        }


    }
}
