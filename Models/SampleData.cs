namespace Day1.Models
{
    public class SampleData
    {
        public static List<Employee> employees = new List<Employee>();
        static SampleData()
        {
            employees.Add(new Employee() { id = 1, name = "ahmed", salary = 5000, imgUrl = "4.png" });
            employees.Add(new Employee() { id = 2, name = "mahmoud", salary = 3000, imgUrl = "2.png" });
            employees.Add(new Employee() { id = 3, name = "ali", salary = 6000, imgUrl = "3.png" });
            employees.Add(new Employee() { id = 4, name = "abdallah", salary = 4500, imgUrl = "4.png" });
            employees.Add(new Employee() { id = 5, name = "yasser", salary = 8000, imgUrl = "1.jpg" });
        }
        public static List<Employee> GetAll()
        {
            return employees;
        }
        public static Employee GetByID(int id)
        {
            return employees.FirstOrDefault(a => a.id == id);
        }
    }
}
