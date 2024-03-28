namespace TestDapper
{
    //we have the dept class so when we hit the database it will map the data
    //to the dept object
    public class Department
    {
        public Department() { }

        //here we are using this class to map each department to this object
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }
}


