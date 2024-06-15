namespace Polyclinic.Entity
{
    public class Doctor
    {
        public Doctor(int id, string name, string salary, int position_id, string ward)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Position = position_id;
            Ward = ward;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public int Position { get; set; }
        public string Ward { get; set; }
    }
}