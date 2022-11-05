namespace ProgramsForNUnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programs for NUnit Testing problems");
            bool flag = true;
            Console.WriteLine(" 1.VendingMachine");
            int check = Convert.ToInt32(Console.ReadLine());
            while (flag)
            {
                switch (check)
                {
                    case 1:
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.Notes(8);
                        vendingMachine.Print();
                        break;
                }
                break;
            }
        }
    }
}