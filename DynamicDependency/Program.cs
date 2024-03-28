namespace DynamicDependency
{
    public class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter A or B:");
            string s = Console.ReadLine();
            bool serviceA;
            if(s == "A")
            {
                serviceA = false;
            }
            else
            {
                serviceA = true;
            }
            IService service = serviceA ? new ServiceB() : new ServiceA();
            var Execute = new Execution(service);
            Execute.CallPrint();
        }
    }
}