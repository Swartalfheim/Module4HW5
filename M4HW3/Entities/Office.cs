namespace M4HW3.Configurats
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
