namespace Storage.Source.Interfaces
{
    interface IUser
    {
        int Id { get; set; }

        string Name { get; }

        string Country { get; }
        string Address { get; }

        int BankNum { get; }
        string BankName { get; }

        string OwnerName { get; }

        int Phone { get; }
        string Email { get; }

        string ManagerName { get; }
    }
}
