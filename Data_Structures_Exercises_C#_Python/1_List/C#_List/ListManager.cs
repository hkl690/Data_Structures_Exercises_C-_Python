using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Exercises
{
    public class ListManager
    {
        private int[] list;

        // Constructor to initialize the list
        public ListManager()
        {
            list = new int[0];
        }

        /// <summary>
        /// Method to add an element to the end of the list (case 1)
        /// </summary>  
        public void AddToEnd()
        {
            Console.WriteLine("Enter the number to add to the list: ");
            int newElement;

            // Validate user input
            while (!int.TryParse(Console.ReadLine(), out newElement))
            {
                Console.WriteLine("Invalid input. Please enter a valid number: ");
            }

            // Create a new list with an extra space
            int[] newList = new int[list.Length + 1];

            // Copy the elements from the old list to the new list
            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            // Add the new element to the end of the new list
            newList[list.Length] = newElement;

            // Update the reference to the new list
            list = newList;

            Console.WriteLine($"Element {newElement} added to the end of the list.");
        }

        /// <summary>
        /// Method to insert an element at a given location (case 2)
        /// </summary>
        public void InsertElement(int index, int newValue)
        {
            if (index < 0 || index > list.Length)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            // Create a new list with an extra space
            int[] newList = new int[list.Length + 1];

            // Copy the elements from the old list to the new list
            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }
            // Insert the new element at the specified index
            newList[index] = newValue;

            // Copy the remaining elements from the old list to the new list
            for (int i = index; i < list.Length; i++)
            {
                newList[i + 1] = list[i];
            }
            // Update the reference to the new list
            list = newList;
            Console.WriteLine($"Inserted element {newValue} at index {index}.");
        }

        /// <summary>
        /// Method to delete the element at a given location (case 3)
        /// </summary>
        public void DeleteElement(int index)
        {
            if (index < 0 || index >= list.Length)
            {
                Console.WriteLine("Invalid index.");
                return;
            }
            // Create a new list with one less space
            int[] newList = new int[list.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newList[i] = list[i];
            }
            // Copy elements after the deleted index
            for (int i = index + 1; i < list.Length; i++)
            {
                newList[i - 1] = list[i];
            }
            // Update the reference to the new list
            list = newList;

            Console.WriteLine($"Element at index {index} has been deleted.");

        }

        /// <summary>
        /// Method to display the list (case 4)
        /// </summary>
        public void DisplayList()
        {
            if (list.Length == 0)
            {
                Console.WriteLine("The list is empty.\n");
                return;
            }
            /*
            Console.WriteLine("These are the elements in your list.");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"Index {i}: {list[i]}");
            }*/
            Console.WriteLine("List elements: [" + string.Join(", ", list) + "]\n");
        }

        /// <summary>
        /// Method to display the count of the total number of elements in the list (case 5)
        /// </summary>
        public void DisplayCount()
        {
            int count = list.Length;
            Console.WriteLine($"The list contains {count} elements.");
        }

        /// <summary>
        /// Method to clear (initialize) the list (case 6)
        /// </summary> 
        public void ClearList()
        {
            list = new int[0];
            Console.WriteLine("List has been cleared.");
        }

    }
}