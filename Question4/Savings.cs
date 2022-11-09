using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Question4
{

    public class SavingsOrCurrent
    {
      
        string name;
        string accNo;
        int accBallance;
        string accType;
        int adharNo;

        public SavingsOrCurrent(string name, string accNo,string accType, int accBallance)
        {
            this.name = name;
            this.accNo = accNo;
            this.accType=accType;
            this.accBallance = accBallance;
        }
        public SavingsOrCurrent(string name, string accNo, string accType, int accBallance, int adharNO)
        {
            this.name = name;
            this.accNo = accNo;
            this.accType = accType;
            this.accBallance = accBallance;
            this.adharNo = adharNO;
        }





        public static void SavingBankAcc()
        {
            SavingsOrCurrent person1 = new SavingsOrCurrent("amit singh","5676500","saving",50050);
            SavingsOrCurrent person2 = new SavingsOrCurrent("it varma", "30555500","current", 50040);
            SavingsOrCurrent person3 = new SavingsOrCurrent("am sharma", "900555550","saving" ,54000);
            SavingsOrCurrent person4 = new SavingsOrCurrent("am sharma", "905755700", "saving", 54000,12113131);
            Console.WriteLine("Enter Amount for Intrest for 6 years is:");
            string amt = Console.ReadLine();
            int ammount= Convert.ToInt32(amt);

            IntrestCalculate object2 = new IntrestCalculate();
            object2.Calculate(ammount);
            ShowCustomer object3 = new ShowCustomer();
            object3.DisplayCustomers();



        }
        public class ShowCustomer
        {

            SavingsOrCurrent person1 = new SavingsOrCurrent("amit singh", "5000", "saving", 50050);
            SavingsOrCurrent person2 = new SavingsOrCurrent("it varma", "3000", "current", 50040);
            SavingsOrCurrent person3 = new SavingsOrCurrent("am sharma", "9000", "saving", 54000);
            SavingsOrCurrent person4 = new SavingsOrCurrent("am sharma", "9000", "saving", 54000, 12113131);
            
            public void DisplayCustomers()
            {
                Console.WriteLine("Customer Details:");
                Console.WriteLine(person1.name);
                Console.WriteLine("Account No:{0}",person1.accNo);
                Console.WriteLine(person1.accType);
                
            }
        }
    }
    

   public class IntrestCalculate
    {
        int years = 6;
        int rateOfInt = 10;
        public void Calculate(int ammount)
        {
            double SI = (ammount * 0.07*6);
            double finalSI = SI;
            Console.WriteLine("SI: {0}",finalSI);
            InheritClass object3 = new InheritClass();
            object3.Calculate(ammount, 6);
        }
        

         public class InheritClass :IntrestCalculate
        {
            public  void Calculate(int ammount, int years)
            {
                double CI = ((ammount * Math.Pow(1.07, years)) - ammount);
                Console.WriteLine("CI:{0}", CI);
            }

        }
    }


}
