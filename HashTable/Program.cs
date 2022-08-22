using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //UC1:Find the frequency of word in sentence
        
            Console.WriteLine("To be or not To be To be To be");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);  ///1 Creating Linklist Hashmap 
            string sentence = "to be or not to be";                                        ///2
            string[] words = sentence.ToLower().Split(" ");                                ///3 Created the array and Splitting The Sentances, 
            foreach (string word in words)                                                 ///4 To Take Every Word In That Sentaces
            {
                int value = LinkedHashMap.Get(word);                                       ///5 To determine its value We are getting in to 5.1
                if (value == default)                                                      //5.9 Storing Value as 1
                {
                    value = 1;
                }
                else value += 1;                                                           ///6 We get a identity but not intialize the linked list
                LinkedHashMap.Add(word, value);                                            //6.20 At last it will come here and Second word will executed
            }
            int frequency = LinkedHashMap.Get("to");
            Console.WriteLine(frequency);

 
        }
    }
}