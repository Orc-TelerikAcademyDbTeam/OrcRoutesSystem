namespace RoutesSystem.Model.SQLiteModels
{
    public class DriverInfo
    {
        public long Id { get; set; }

        public string StartTown { get; set; }

        public string EndTown { get; set; }

        public string DriverFirstName { get; set; }

        public string DriverLastName { get; set; }
    }
}
