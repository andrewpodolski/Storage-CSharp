using System.Collections.Generic;
using Storage.Source.Entity.Users;

namespace Storage.Source
{
    partial class Model
    {
        public List<User> GetAllUsers()
        {
            return db.users;
        }

        public List<User> GetAllClients()
        {
            return db.users.FindAll(x => x is ClientManager);
        }
    }
}
