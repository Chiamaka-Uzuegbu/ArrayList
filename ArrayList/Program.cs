using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArraynList
{
    class Program
    {
        static void Main(string[] args)
        {
            Lists();
            SLists();
            int[] myArray = { 1, 3, 4, 5, 8 };
            ArrayList ourArrayList = new ArrayList() { 1, "eht", DateTime.Today };
            ourArrayList.Add(System.Guid.NewGuid());

            //ourArrayList.AddRange(myArray);
            ourArrayList.InsertRange(1, myArray);
            foreach(object o in ourArrayList)
            {
                Console.WriteLine(o.ToString());
            }

            Console.ReadLine();

        }
        
        //Lists
        static int Lists()
        {
            var student = new List<Students>();
            var stud1 = new Students() { Id = 1, Name = "Bill" };
            var stud2 = new Students() { Id = 1, Name = "Bill" };

            student.Add(stud1);
            student.Add(stud2);

            return 1;

        }


        //Sorted Lists
        static int SLists()
        {
            var sList = new SortedList<int, string>();
            sList.Add(3, "Ade");
            sList.Add(1, "James");
            sList.Add(2, "Obong");
            sList.Add(7, "hassan");
            sList.Add(4, "James");

            foreach( var item in sList)
            {
                Console.WriteLine($"{item.Value} is in {item.Key} position");
            }

            return 1;

        }



    }


}
