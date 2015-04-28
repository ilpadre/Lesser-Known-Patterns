using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Program
    {
        static void Main()
        {
            var s = new SalesProspect   // Originator
            {
                Name = "Nick Danger",
                Phone = "(555) 256-0990",
                Budget = 25000.0
            };

            s.PrintProspect();

            // Store internal state
            var m = new ProspectBuffer // Caretaker class
            {
                Memento = s.CreateMemento()
            };

            // Continue changing originator
            s.Name = "Rancid Crabtree";
            s.Phone = "(555) 209-7111";
            s.Budget = 1000000.0;

            s.PrintProspect();

            // Restore saved state
            s.SetMemento((Memento)m.Memento);

            s.PrintProspect();

            // Wait for user
            Console.ReadLine();
        }
    }

    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }
    }

    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class ProspectBuffer
    {
        public object Memento { get; set; }
    }

    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class SalesProspect
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        // Dump contents
        public void PrintProspect()
        {
            Console.WriteLine("Name:  " + Name);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Budget: {0:C}", Budget);
        }

        // Returns memento
        public Memento CreateMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento()
            {
                Name = Name,
                Phone = Phone,
                Budget = Budget
            };
        }

        // Restores state from memento
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }


}
