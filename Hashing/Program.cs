using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(11);
            string name = "";
            hashTable.Add("Mia", 123);
            hashTable.Add("Tim", 456);
            hashTable.Add("Bea", 645);
            hashTable.Add("Zoe", 089);
            hashTable.Add("Sue", 189);
            hashTable.Add("Len", 289);
            hashTable.Add("Moe", 489);
            hashTable.Add("Lou", 389);
            hashTable.Add("Rae", 589);
            hashTable.Add("Max", 689);
            hashTable.Add("Tod", 889);

            Console.WriteLine("enter a name to search for, enter to quit ");
            name = Console.ReadLine();
            while(name != "")
            {
                if (hashTable.Find(name) == -1)
                {
                    Console.WriteLine($"{name} is not in the array");
                }
                else
                {
                    Console.WriteLine($"{name} is located at index {hashTable.Find(name)}");
                }
                Console.WriteLine("enter a name to search, enter to quit ");
                name = Console.ReadLine();
            }
            

        }
    }
    class HashTable
    {
        private int size;
        private (string, object)[] table;
        public HashTable(int size) 
        {
            this.size = size;
            table = new (string, object)[size];
        }
        private int Hash(string key)
        {
            var sum = 0;
            foreach (var ch in key)
            {
                sum += (int)ch;
            }
            return sum;

        }
        public void Add(string key, object value) 
        {
            int index = Hash(key);
            Console.WriteLine($"hash calculated as {index}");
            while (table[index].Item1 != null)
            {
                index = (index + 1) % size;
                Console.WriteLine($"{key} stored at location {index}");
               
            }

        }
        public int Find(string key) 
        {
            
            for (int i = 0; i<table.Length; i++)
            {
                if (table[i].Item1 == "")
                {
                    return -1;
                }
                else
                {
                    Console.WriteLine($"this is the location of the item {table[i].Item2}");
                }
                
            }
            return 0;
            
        }
        
    }
}
