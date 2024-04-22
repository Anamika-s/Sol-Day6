namespace Generics_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //   student.Id= 1; // here set method will be called
            //   Console.WriteLine(student.Id); // get method will be called


            // How do we initialize object
            //Employee emp = new Employee();
            //emp.Id = 10;
            //emp.Name = "Deepak";
            //emp.Dept = "Accts";
            //emp.Manager = "Sagar";
            //emp.JoiningDate = DateTime.Now;

            // Object Initializer
            Employee emp = new Employee()
            { Id = 1, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() };

            // How do we initialize List
            //List<Employee> employees = new List<Employee>();

            //Employee emp1= new Employee() { Id = 1, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() };
            //employees.Add(emp1);
            //Employee emp2 = new Employee() { Id = 1, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() };
            //employees.Add(emp2);
            //Employee emp3 = new Employee() { Id = 1, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() };
            //employees.Add(emp3);

            // List Initializer
            List<Employee> employees = new List<Employee>()
                {
                new Employee() { Id = 1, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() },
                new Employee() { Id = 2, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() },
                new Employee() { Id = 3, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() },
                new Employee() { Id = 4, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() },
                new Employee() { Id = 5, Name = "Ajay", Dept = "HR", Manager = "Sagar", JoiningDate = new DateTime() }

                };

            SwapDemp swap = new SwapDemp();
            swap.Swap<int>(10, 20);
            swap.Swap<char>('a', 'b');
            swap.Swap<string>("ajay", "kumar");

        }
    }
}