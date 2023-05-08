using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo

{
    //Arraylist is non generic collection
    //stores the elements  or multiple data types 
    //size can vary dynamically
    //When the data type and data size is unknown we can use arraylist
    public class ArrayListDemo
    {
        public void AddArrayList()
        {
            ArrayList arrayList = new ArrayList();
            //ADD
            arrayList.Add(1);
            arrayList.Add("Khamisha");
            arrayList.Add(8);
            arrayList.Add(4);
            arrayList.Add(554);
            arrayList.Add(61);
            arrayList.Add(7);
            arrayList.Add(60);
            arrayList.Add(6445);


            arrayList.Add(6);

            //Insert
            //arrayList.Insert(1, 1111111);
            //Remove- Removing the value
           // arrayList.Remove(1);
            //arrayList.Remove(8);

          //  arrayList.RemoveAt(3);
            arrayList.RemoveRange(0,2);
            int count = arrayList.Count;
            Console.WriteLine("Count" + count);
            //arrayList.Clear();
            //int counts = arrayList.Count;
            //Console.WriteLine("Count" + counts);
            arrayList.Sort();

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------------------");
           
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

        }
    }
}
