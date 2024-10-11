/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{
    public class Abstract_class2
    {
        static void Main(String[] args) {

            Console.WriteLine("Transaction doing Sbi bank ");
            IBank sbi = BankFactory.GetBankObject("Sbi");
            sbi.validate_card();
            sbi.check_balance();
            sbi.withdraw();

            Console.WriteLine("Transaction doing Axis bank");
            IBank axis = BankFactory.GetBankObject("Axis");
            axis.validate_card();
            axis.check_balance();   
            axis.withdraw();
        
        }
    }

    public abstract class IBank {

        public abstract void validate_card();
        public abstract void check_balance();
        public abstract void withdraw();
    
    }
    public class BankFactory { 
    
    
        public static IBank GetBankObject(String bankType) { 
        
            IBank BankObject = null;

            if (bankType == "SBI") {

                BankObject = new Sbi();
            }
            else if(bankType =="Axis") { 
            
                   BankObject = new Axis();
            }
            return BankObject;

        }
    
    
    }


    public class Sbi : IBank {

        public override void validate_card()
        {
            Console.WriteLine("Sbi bank validate card");

        }
        public override void check_balance()
        {
            Console.WriteLine("Sbi bank check_balance");
        }
        public override void withdraw() 
        {

            Console.WriteLine("Sbi bank withdraw");
        }

    }
    public class Axis : IBank 
    {

        public override void validate_card() { 
        
            Console.WriteLine("Axis bank validate card");
        }
        public override void check_balance() 
        {
            Console.WriteLine("Axis bank check balance");
        }
        public override void withdraw()
        {
            Console.WriteLine("Axis bank withdraw ");
        }
    }

}
*/