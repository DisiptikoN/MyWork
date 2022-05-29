namespace DZ_SkillBox_11.Model
{
    public class Consultant : Supervisor
    {
       public Consultant(string Name, int Id): base (Name, Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
        
    }
}
