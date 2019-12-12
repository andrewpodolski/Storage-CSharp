namespace Storage.Source
{
    partial class Model
    {
        DataBase db;
        LogsDB logs;

        public Model()
        {
            db = new DataBase();
            logs = new LogsDB();
        }
    }
}
