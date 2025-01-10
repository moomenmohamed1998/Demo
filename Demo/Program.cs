using System.Security;
using Microsoft.VisualBasic.FileIO;

namespace Demo
{

    [Flags]
    enum Permission:byte 
    {
        Delete=1, Execute=2, Read=4, Write=8
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Permission Permission { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region PhoneBook

            //PhoneBook Note = new PhoneBook(3);
            //Note.Addperson(0, "Ahmed", 123);
            //Note.Addperson(1, "Amr", 456);
            //Note.Addperson(2, "Aya", 789);


            //Console.WriteLine(Note.GetPersonNumber("Amr"));

            ////Console.WriteLine(Note.GetPersonNumber("Amr"));

            //Note.SetPersonNumber("Amr", 101010);
            //Console.WriteLine(Note[0]);
            #endregion

            #region Enum
            //Employee emp = new Employee();
            //emp.Id = 1;
            //emp.Name = "Ahmed";
            //emp.Salary = 5000;
            ////emp.Permission = Permission.Read;
            //emp.Permission = (Permission)3;
            //Console.WriteLine(emp.Permission);

            //Permission p = (Permission)3;
            //Console.WriteLine(p);

            //p |= Permission.Read;
            //Console.WriteLine(p);

            //p &= (~Permission.Read);
            //Console.WriteLine(p);

            //p ^= Permission.Delete;
            //Console.WriteLine(p);

            //if ((p &Permission.Delete)==Permission.Delete)
            //    Console.WriteLine("Delete is Exsist");
            //else
            //    Console.WriteLine("Delete is not Exsist"); 
            #endregion

            #region class

            Car c1;
            c1 = new Car(1, "BMW", 400);
            Console.WriteLine(c1.ToString());

            #endregion

        }
    }
}
