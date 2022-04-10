using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMemento
{
    public class Sender
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public int getAmount()
        {
            return Amount;
        }
        public void setAmount(int amount)
        {
            Amount = amount;    
        }
        public void sendMoney(int amount)
        {
            Console.WriteLine("Amount send from " + Name+ ": " +amount);
        }
    }

    public class Receiver
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public int getAmount()
        {
            return Amount;
        }
        public void setAmount(int amount)
        {
            Amount = amount;
        }
        public void receiveMoney(int amount)
        {
            Console.WriteLine("Money received by " + Name + ": " + getAmount());
        }
    }
    public abstract class Bank
    {
        static int Amount = 0;
        public static void receiveFrom(Sender sender)
        {
            Amount = sender.getAmount();    
        }
        public static void sendTo(Receiver receiver)
        {
            receiver.setAmount(Amount);
        }
    }
}
