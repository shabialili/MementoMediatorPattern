using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMemento
{
    public class Student
    {
        public String Status { get; set; }
        private Memento memento;    

        public Student()
        {
            this.Status = "Pending Approval";
            this.memento = new Memento(this.Status);
        }
        public void StartAdmissionProcess()
        {
            this.Status = "Admitted";
        }
        public void Revert()
        {
            this.Status = this.memento.status;
        }
    }
    class Memento
    {
        public readonly string status;
        public Memento (String status)
        {
            this.status = status;
        }
    }
}
