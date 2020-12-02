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
            Console.WriteLine("Employee id : " + " " + o1.EMPNO);
            Console.WriteLine("Employee name : " + " " + o1.NAME);
            Console.WriteLine("Employee Basic Salary : " + " " + o1.BASIC);
            Console.WriteLine("Employee DEPTNO : " + " " + o1.DEPTNO);
            Console.WriteLine(" ");


            Employee o2 = new Employee("Amol", 123465);
            Console.WriteLine("Employee id : " + " " + o2.EMPNO);
            Console.WriteLine("Employee name : " + " " + o2.NAME);
            Console.WriteLine("Employee Basic Salary : " + " " + o2.BASIC);
            Console.WriteLine("Employee DEPTNO : " + " " + o2.DEPTNO);
            Console.WriteLine(" ");

            Employee o3 = new Employee("Amol");
            Console.WriteLine("Employee id : " + " " + o3.EMPNO);
            Console.WriteLine("Employee name : " + " " + o3.NAME);
            Console.WriteLine("Employee Basic Salary : " + " " + o3.BASIC);
            Console.WriteLine("Employee DEPTNO : " + " " + o3.DEPTNO);
            Console.WriteLine(" ");

            Employee o4 = new Employee();
            Console.WriteLine("Employee id : " + " " + o4.EMPNO);
            Console.WriteLine("Employee name : " + " " + o4.NAME);
            Console.WriteLine("Employee Basic Salary : " + " " + o4.BASIC);
            Console.WriteLine("Employee DEPTNO : " + " " + o4.DEPTNO);


            #region Testcases
            //Employee o1 = new Employee();
            //Employee o2 = new Employee();
            //Employee o3 = new Employee();

            //Console.WriteLine(o1.EMPNO);
            //Console.WriteLine(o2.EMPNO);
            //Console.WriteLine(o3.EMPNO);


            #endregion

            Console.ReadLine();

        }
    }

   class Employee
    {

        private String name;
        public int Empno;
        private Decimal Basic;
        private short DeptNo;
        private static int count = 1;


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
            Empno= count++;
            this.BASIC = b;
            this.DEPTNO = d;
        }

        public Employee(String n, Decimal b)
        {
            this.NAME = n;
           Empno= count++;
            this.BASIC = b;
            this.DEPTNO = 10;
        }

        public Employee(String n)
        {
            this.NAME = n;
            Empno = count++;
            this.BASIC = 283920;
            this.DEPTNO = 10;
        }

        public Employee()
        {

            this.NAME = "Ramesh";
            Empno = count++;
            this.BASIC = 102039;
            this.DEPTNO = 20;

        }

        #endregion




    }


}
