using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IAtmDeposit
    {
        void ShowDeposit();
        double GetDepositAmount();
    }
    public class AtmDeposit:IAtmDeposit
    {
        private string AtmAccountNumber;
        private Nullable<DateTime> Date;
        private double DepositAmount;

        public AtmDeposit()
        {
            AtmAccountNumber = "";
            Date = null;
            DepositAmount = 0.0;
        }
        public AtmDeposit(string a,DateTime b,double c)
        {
            this.AtmAccountNumber = a;
            this.Date = b;
            this.DepositAmount = c;
        }
        public double GetDepositAmount()
        {
            return DepositAmount;
        }

        public void ShowDeposit()
        {
            Console.WriteLine("Atm Account Number: {0}", AtmAccountNumber);
            Console.WriteLine("Date Deposited:{0}", Date);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Account Number");
            string value1=Console.ReadLine();
            Console.WriteLine("Please enter Today's Date");
            DateTime value2 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter the Amount you would like to deposit to your account");
            double value3 = Convert.ToDouble(Console.ReadLine());
            AtmDeposit atmde = new AtmDeposit(value1,value2,value3);
            atmde.ShowDeposit();
            Console.WriteLine("The Amount {0} has Deposited to your Account Number {1}", value3, value1);
            Console.Read();
        }
    }
}
