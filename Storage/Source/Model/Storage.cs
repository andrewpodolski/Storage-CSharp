using System.Collections.Generic;

namespace Storage.Source
{
    partial class Model
    {
        public List<Entity.Storage> GetAllStorages()
        {
            return db.storages;
        }

        public Entity.Storage GetStorageById (int id)
        {
            return db.storages.Find(x => x.Id == id);
        }
    }
}
