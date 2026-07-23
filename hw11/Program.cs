namespace hw11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "John";
            person.Age = 25;
            person.Password = "123456";


            MySerializer serializer = new MySerializer();

            string result = serializer.Serialize(person);

            Console.WriteLine(result);
        }
    }
}
