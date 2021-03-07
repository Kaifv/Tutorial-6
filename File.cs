using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_6
{
    public class File
        {
            //A public variable which will be sotring the value of the date and time when the file was created.
            public DateTime created { get; set; }

            //A public method which will be storing the value of the name of the file
            public string fileName { get; set; }

            //A public method which will be storing the size of the file.
            public double size { get; set; }

            //A public method which will be storing the date and time when the file was last created
            public DateTime lastEdited { get; set; }

            //A public method for storing the value for the type of file
            public string fileType { get; set; }

            public File Prev;
            public File Next;



            /**
             * A public constructor which will be called whenever an object is instantiated from this class.
             * This will be just setting the values to the public variables that were initiated in this class
             */
            public File(DateTime created, string name, double size, DateTime edited, string type)
            {
                this.created = created;
                this.fileName = name;
                this.size = size;
                this.lastEdited = edited;
                this.fileType = type;
            }

            /**
             *This method will be used for sorting the files in our list into descending order of the date they were created.
             * That will be achieved using LINQ.
             */
            public static List<File> SortByDate(List<File> listofFiles)
            {
                //List will be ordered by the dates they were created in the descending form.
                List<File> sorted = listofFiles.OrderByDescending(c => c.created).ToList();
                return sorted;
            }

            /**
             * This method will be used for sorting the files in out list into alphabetical order of their name.
             * That will be achieved using LINQ
             */
            public static List<File> SortByName(List<File> listofFiles)
            {
                //List will be ordered by file name and it will automatically order them in alphabetical order.
                List<File> sorted = listofFiles.OrderBy(c => c.fileName).ToList();

                return sorted;
            }

            /**
             * This method will be used for getting the files whose size is greater than 100 and adding them in list.
             * This will be achieved by LINQ
             */
            public static List<File> SortBySize(List<File> listofFiles)
            {
                //List will be only having files whose size is greater than 100.
                List<File> sorted = listofFiles.Where(c => c.size >= 100).ToList();
                return sorted;
            }

            

        /**
         * A ToString method will be just putting out the date.
         */
        public override string ToString()
            {
                return "Date when the file was created: " + created + " name: " + fileName + " size: " + size + " last edited " + lastEdited + " and file type: " + fileType;
            }
        }
    
}
