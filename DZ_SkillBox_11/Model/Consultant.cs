namespace DZ_SkillBox_11.Model
{
    public class Consultant : Worker
    {
       public Consultant(string Name, int Id): base (Name, Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
        
    }
}
