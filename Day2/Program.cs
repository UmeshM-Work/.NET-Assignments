using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main()
        {

            Employee o1 = new Employee("Amol", 123465, 10);
            Console.WriteLine("Employee id"+ " "+ o1.EMPNO);
            Employee o2 = new Employee("Amol", 123465);
            Console.WriteLine(o2.EMPNO);
            Employee o3 = new Employee("Amol");
            Console.WriteLine(o3.EMPNO);
            Employee o4 = new Employee();
            Console.WriteLine(o4.EMPNO);



            //Employee o1 = new Employee();
            //Employee o2 = new Employee();
            //Employee o3 = new Employee();

            //Console.WriteLine(o1.EMPNO);
            //Console.WriteLine(o2.EMPNO);
            //Console.WriteLine(o3.EMPNO);




            Console.ReadLine();

        }
    }

   class Employee
    {

        private String name;
        public static int Empno;
        private Decimal Basic;
        private short DeptNo;


        #region property

        #region Name
        public String NAME
        {


            set { 
                if(value !=" ")
                {
                    name = value;
                }
                else
                {

                    Console.WriteLine("Please enter Name dont leave it blank");
                }
            }

            get {

                return name;
            }

        }

        #endregion


        #region EMPNO
        public int EMPNO
        {

            get
            {

                return Empno;
            }

        }
        #endregion

        #region Basic
        public Decimal BASIC
        {
            set
            {
                if (value > 100000 && value < 1000000)
                {
                    Basic = value;
                }
                else
                {
                    Console.WriteLine("Salary out of range please enter once again !!");
                }
            }

            get
            {

                return Basic;
            }

        }
        #endregion


        #region DEPTNO
        public short DEPTNO
        {
            set { 
            
                if(value>0)
                {
                    DeptNo = value;
                }

                else
                {
                    Console.WriteLine("Deptno should be greater than zero please enter once again !!");
                }


            }

            get {

                return DeptNo; 
           
            }
        }

        #endregion



        #region GETSALARY
        public decimal GetNetSalary()
        {

            return 12 * Basic;

        }
        #endregion

        #endregion


        #region  Contructor and param- Constructor

        public Employee(String n,Decimal b,short d)
        {
            this.NAME = n;
            Empno++;
            this.Basic = b;
            this.DEPTNO = d;
        }

        public Employee(String n, Decimal b)
        {
            this.NAME = n;

            Empno++;
            this.Basic = b;
        }

        public Employee(String n)
        {
            this.NAME = n;
            Empno++;
        }

        public Employee()
        {

            Empno++;
                
        }

        #endregion




    }


}
