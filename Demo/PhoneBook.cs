using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Demo
{
    struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public int Size
        {
            get { return size; }
        }

        public long GetPersonNumber(string Name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                        return numbers[i];
                }
            }
            return -1;
            
        }

        public void SetPersonNumber(string Name,long Number)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        numbers[i] = Number;
                        return;
                    }

                }
            }
           

        }

        #region Indexer
        //special Propety
        //this 

        //public long this[string name]
        //{
        //    get
        //    {
        //        if (names is not null && numbers is not null)
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (name == names[i])
        //                    return numbers[i];
        //            }
        //        }
        //        return -1;
        //    }

        //    set
        //    {
        //        if (names is not null && numbers is not null)
        //        {
        //            for (int i = 0; i < names.Length; i++)
        //            {
        //                if (name == names[i])
        //                {
        //                    numbers[i] = value;
        //                    return;
        //                }

        //            }
        //        }
        //    }
        //}


        //public string this[int index]
        //{
        //    get
        //    {
        //        return $"{index} :: {names[index]} :: {numbers[index]}";
        //    }
        //}
        //public PhoneBook(int _size)
        //{

        //    size = _size;
        //    names = new string[size];
        //    numbers = new long[size];
        //}
        //public void Addperson(int postion, string Name, long Num)
        //{
        //    if (names is not null && numbers is not null)
        //    {
        //        if (postion >= 0 && postion < size)
        //        {
        //            names[postion] = Name;
        //            numbers[postion] = Num;
        //        }
        //    }

        //}


        #endregion





    }


}
