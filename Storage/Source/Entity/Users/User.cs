using Storage.Source.Interfaces;

namespace Storage.Source.Entity.Users
{
    abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Country { get; }
        public string Address { get; }
        public int BankNum { get; }
        public string BankName { get; }
        public string OwnerName { get; }
        public int Phone { get; }
        public string Email { get; }
        public string ManagerName { get; }

        public User(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("Id: {0} ; Имя: {1};",
                Id,
                Name);
        }
    }
}
