namespace Polyclinic.Entity
{
    public class Account
    {
        public Account(int id, string name, string email, string password, int role_id)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            this.role_id = role_id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int role_id { get; set; }

    }
}