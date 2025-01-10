namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PhoneBook

            PhoneBook Note = new PhoneBook(3);
            Note.Addperson(0, "Ahmed", 123);
            Note.Addperson(1, "Amr", 456);
            Note.Addperson(2, "Aya", 789);


            //Console.WriteLine(Note.GetPersonNumber("Amr"));

            //Console.WriteLine(Note.GetPersonNumber("Amr"));

            Note.SetPersonNumber("Amr", 101010);
            Console.WriteLine(Note[0]);
            #endregion
        }
    }
}
