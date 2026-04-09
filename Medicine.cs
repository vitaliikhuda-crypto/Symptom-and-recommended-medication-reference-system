namespace MedSearchWPF.Models
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Dose { get; set; }

        public Medicine(string name, string description, string dose)
        {
            Name = name;
            Description = description;
            Dose = dose;
        }
    }
}
