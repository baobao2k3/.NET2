namespace LearningArr.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public void EnterData()
        {
            System.Console.WriteLine("FullName = ");
            FullName = Console.ReadLine();
            System.Console.WriteLine("ID = ");
            Id = Console.ReadLine();
            System.Console.WriteLine("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine(Id, '-', FullName, "- ", Age);
        }
    }
}