using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_6
{
    /**
     * This is the GenericList class which is custom made by us. This is defining the functions that we already use from the normal generic class
     * of collections. In this class we will be adding 3 basic methods like, AddHead, AddToBack and sortList which will do the work
     * according to their names. 
     */
    public class GenericList<T> where T : File
    {

        
        // The nested class is also generic on T.
        private class Node
        {
            //Private field
            private Node next;

            // T as private member data type.
            private T data;

            // T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }



            //This is the method which will be defining getter and setter for next variable
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }



            //This is the method which will be defining getter and setter for data variable
            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }


        //A private variable used for denoting a head of the list
        private Node head;
       

        // constructor for setting head as null
        public GenericList()
        {
            head = null;

        }

        //This method is used for adding a T type object to the front of the list.
        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }



        //Referenced from https://www.geeksforgeeks.org/linked-list-set-2-inserting-a-node/
        //This method will be doing the same function as an Add method in normal List class of Generic collections. So, it will be adding T type
        //objects at the back of the list.
        public void AddToBack(T t)
        {
            //defining a new node with T type parameter
            Node n = new Node(t);


            //Checking if head is null, if it is then just return the head back as new node
            if (head == null)
            {
                head = new Node(t);
             
                return;
            }

            //Making next node null
            n.Next = null;

            //Making last type node to head
            Node last = head;

            //If next to last is not null then we will make next to last the last one.
            while (last.Next != null)
                last = last.Next;

            //Then we will make next to last our defined node in the list.
            last.Next = n;
            return;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        //Referenced from employee class of professor.
        //A method to sort in ascending order.
        public void sortList()
        {
            //Node current will point to head  
            Node current = head;

            //This node will just simply define a new node named index
            Node index = null;

            //A temp variable of type T
            T temp;


            //If head is already null, means if there is nothing in the list then it will return the method
            if (head == null)
            {
                return;
            }

            //If the head is not null then we will do the following process of sorting list
            else
            {
                //Until current node is not null this loop will occur
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.Next;


                    //Until index is null following loop will occur
                    while (index != null)
                    {
                        //If current node's data is greater than index's node data, swap the data between them  
                        if (current.Data.size > index.Data.size)
                        {
                            temp = current.Data;
                            current.Data = index.Data;
                            index.Data = temp;
                        }
                        //Making index next to last index
                        index = index.Next;
                    }
                    //Making current next to last current node
                    current = current.Next;
                }
            }
        }


    }
}
