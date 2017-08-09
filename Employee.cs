using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    abstract class Employee
    {   // instance variables
        protected int empno;
        protected string empname;
        protected int salary;
        protected string[] skills = new string[5];

        // Constructor 
        public Employee(int empno, string empname, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }
        public int Number
        {
            get
            {
                return empno;
            }
            private set
            {
                this.empno = value; 
            }
        }
        // Methods 
        public virtual void Print()
        {
            Console.WriteLine(this.empno);   // WriteLine(int)
            Console.WriteLine(this.empname); // WriteLine(string)
            Console.WriteLine(this.salary);
            foreach(string s in skills)
            {
                if (s != null && s.Length > 0)
                    Console.WriteLine(s);
            }

        }
        public void SetSalary(int salary)
        {
            if (salary > 0)
                this.salary = salary;
        }

        public abstract int GetNetSalary();

        // Indexer
        public string this[int index]
        {
            get
            {
                return skills[0];
            }
            set
            {
                skills[index] = value;
            }
        }
    }

    class Programmer : Employee
    {
        private string project;
        private int trainingAllowance; 

        public Programmer(int empno, string empname, int salary, string project, 
               int trainingAllowance)
             : base(empno,empname,salary)
        {
            this.project = project;
            this.trainingAllowance = trainingAllowance;
        }

        public override  void Print()
        {
            base.Print();
            Console.WriteLine("Project : " + project);
        }

        public override  int GetNetSalary()
        {
            return  salary + ( salary * 30 / 100 ) + trainingAllowance;
        }
    }


    class TestEmployee
    {
        public static void Main()
        {
            Employee e;

            e = new Programmer(1, "Abc", 70000, "Website", 5000);

            Programmer p;

            if ( e is Programmer)
                p = (Programmer) e;  // Downcasting 

            p = e as Programmer;

        }

    }
}
