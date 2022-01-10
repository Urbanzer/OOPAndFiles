﻿using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {
        class Frozen
        {
            string name;
            string wish;

            public Frozen(string _name, string _wish)
            {
                name = _name;
                wish = _wish;
            }

            //getters for Frozen

            public string Name
            {
                get { return name; }
            }

            public string Wish
            {
                get { return wish; }
            }

      
        }
        static void Main(string[] args)
        {
            List<Frozen> myFrozen = new List<Frozen>();
            string[] frozenFromFile = GetDataFromFile();

            foreach (string line in frozenFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newFrozen = new Frozen(tempArray[0], tempArray[1]);
                myFrozen.Add(newFrozen);
            }

            foreach (Frozen frozenFromList in myFrozen)
            {
                Console.WriteLine($"{frozenFromList.Name} want's {frozenFromList.Wish} for christmas.");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Aleksander\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}