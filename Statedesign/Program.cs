using Statedesign.Context;

namespace Statedesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            VendingMachine machine = new VendingMachine();
            machine.SelectProduct();
            machine.InsertMoney();
            machine.InsertMoney();
            machine.SelectProduct();
            machine.InsertMoney();
            machine.SelectProduct();

            machine.Reset();

            machine.SelectProduct();
            machine.InsertMoney();
        }
    }
}
