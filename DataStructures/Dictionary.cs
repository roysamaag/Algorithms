using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Dictionary
    {
        public void CreateAndRead()
        {
            var dictionary = new Dictionary<string, List<string>>();


            if (!dictionary.ContainsKey("warm"))
            {
                dictionary.Add("warm", new List<string> { "8", "7" });
            }

            if (!dictionary.ContainsKey("cold"))
            {
                dictionary.Add("cold", new List<string> { "3", "5" });
            }

            foreach (var kvp in dictionary)
            {
                if (kvp.Value.Contains("7"))
                {
                    Console.WriteLine(kvp.Key);
                }
            }

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var value in dictionary.Values)
            {
                foreach (var item in value)
                {
                    Console.Write(item + ",");
                }

            }

        }
    }
}
