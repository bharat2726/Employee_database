namespace Employee_Database
{
    internal class Records
    {
        public Records()
        {
            Name = "";
            Department = "";
            Position = "";
            IdNumber = 0;
        }

        public Records(string name, int id, string dep, string position)
        {
            Name = name;
            Department = dep;
            Position = position;
            IdNumber = id;
        }
            
        public Records(string name, int id)
        {
            Name = name;
            Department = "";
            Position = "";
            IdNumber = id;
        }

        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return "Employee Id = " + IdNumber.ToString();
        }

    }
}
