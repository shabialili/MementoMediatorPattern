using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMemento
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// Memento Pattern

            var student = new Student();
            Console.WriteLine($"Initial student status {student.Status}");
            try
            {
                student.StartAdmissionProcess();
                Console.WriteLine($"Student status after processing {student.Status}");
                throw new Exception();
            }
            catch (Exception)
            {
                student.Revert();
            }
            Console.WriteLine($"Student status after failure {student.Status}");
            Console.ReadKey();



            //// Mediator Pattern

            Sender Shabnam = new Sender();
            Shabnam.Name = "Shabnam";
            Shabnam.setAmount(5000);

            Receiver Cavid = new Receiver();
            Cavid.Name = "Cavid";

            Shabnam.sendMoney(5000);
            Bank.receiveFrom(Shabnam);
            Bank.sendTo(Cavid);
            Cavid.receiveMoney(5000);
          
        }
    }
}
