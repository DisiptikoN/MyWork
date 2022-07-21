namespace DZ_SkillBox_11.Model
{


    public class Worker 
    {


        string name;
        public int Id { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Worker(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }

        public Worker()
        {
            this.Name = Name;

        }
       

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
