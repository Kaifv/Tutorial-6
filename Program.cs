using System;
using System.Collections.Generic;

namespace Tutorial_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Defining custom generic list of type file
            GenericList<File> files = new GenericList<File>();

            
            //Making object of type File so that we can add it later to the list
            File file1 = new File(new DateTime(2015, 11, 20), "Apple", 78.45, new DateTime(2018, 12, 12), "txt");
            File file2 = new File(new DateTime(2016, 10, 21), "Banana", 34.78, new DateTime(2017, 3, 13), "docx");
            File file3 = new File(new DateTime(2013, 9, 10), "Orange", 102.08, new DateTime(2015, 4, 14), "pptx");
            File file4 = new File(new DateTime(2016, 8, 12), "Lemon", 134.56, new DateTime(2017, 5, 16), "dll");
            File file5 = new File(new DateTime(2019, 7, 24), "Tomato", 56.34, new DateTime(2020, 6, 18), "sln");
           

            //Adding objects at teh back of the list using AddToBack method
            files.AddToBack(file1);
            files.AddToBack(file2);
            files.AddToBack(file3);
            files.AddToBack(file4);
            files.AddToBack(file5);
            

            //Outputting a list content to check if the objects are added to the back or not.
            Console.WriteLine("List of files, added using AddToBack method");

            foreach (File e in files)
            {

                Console.WriteLine(e);

            }


            //Calling sort method to the current method
            /*
             * This is the custom made sort method that we have made to substitute predefined sort method in the generic collections last class
             * But there is some restrictions for using this method. One of the main reason is that we can only use this method on numeric data
             * types, because this method compares value of two numeric variables and thus it can not be used as to sort a string list. 
             */
            files.sortList();


            //Outputting list content to check if method worked or not.
            Console.Write("\nFiles are ordered according to the file size\n");
           foreach (File e in files)
           {
               Console.WriteLine(e);
           }
        }
    }
}
