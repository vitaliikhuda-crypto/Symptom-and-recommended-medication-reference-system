namespace MedSearchWPF.Models
{
    public class Symptom
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Symptom(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
