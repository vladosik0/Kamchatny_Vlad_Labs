using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> keys =  new List<int>{1,2,3,4,5};
            Dictionary<int, string> values = new Dictionary<int, string>
            {
                {0,"name1" },
                {2,"name2" },
                {7,"name3" },
                {1,"name4" },
                {8,"name5" },
            };
            Dictionary<int, string> newDictionary = new Dictionary<int, string>();
            for(int i=0;i<keys.Count;i++)
            {
                newDictionary.Add(keys[i],values.Values.ElementAt(i));
            }
            Console.WriteLine("Dictionary: ");
            foreach(var element in newDictionary)
            {
                Console.WriteLine(element);
            }
            SaveDictionaryInFile(newDictionary, "file.json");
        }
        public static void SaveDictionaryInFile(Dictionary<int,string> dictionary, string fileName)
        {
                string jsonString = JsonConvert.SerializeObject(dictionary);
                File.WriteAllText(fileName, jsonString);
        }
    }
}
