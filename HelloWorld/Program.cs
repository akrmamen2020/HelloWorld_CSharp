using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{

    class Emplyee
    {
        public int EmplyeeId { get; set; }
        public string Name { get; set;  }
        public string Gender { get; set; }
    }

    class Company
    {
        private  List<Emplyee> emplyees;

        public Company()
        {
            emplyees = new List<Emplyee>();

            emplyees.Add(new Emplyee() { EmplyeeId = 1, Name = "Ahmed", Gender = "Male" });
            emplyees.Add(new Emplyee() { EmplyeeId = 2, Name = "Mohmed", Gender = "Male" });
            emplyees.Add(new Emplyee() { EmplyeeId = 3, Name = "Salah", Gender = "Male" });
            emplyees.Add(new Emplyee() { EmplyeeId = 4, Name = "Fatema", Gender = "Female" });
            emplyees.Add(new Emplyee() { EmplyeeId = 5, Name = "Gada", Gender = "Female" });
        }


        public string this[int EmplyeeID]
        {
            get
            {
                string theName = "";
                foreach (Emplyee e in emplyees)
                {
                    if (e.EmplyeeId == EmplyeeID)
                    {
                        theName = e.Name;
                    }
                }
                return theName;
            }
            set
            {
                emplyees.FirstOrDefault(emp => emp.EmplyeeId == EmplyeeID).Name = value; 
            }
        }
    }


    class Program
    {
        


        static void Main()
        {

            Company c = new Company();

            //c[1] = "Hissen";

            Console.WriteLine(c[1]);  

            //DataTable dt = new DataTable("myTable");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("age");

            //DataRow r = dt.NewRow();

            //r[0] = "Ahmed";
            //r["age"] = 35;

            //Console.WriteLine(r[1]);

            Console.ReadKey(true); 
        }


    }
}