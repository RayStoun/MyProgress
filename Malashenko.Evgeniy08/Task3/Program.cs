using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
       static string text= "However, the enemy forces were too large to hold back, no matter how brave the PDF was. in the early days of the War, the PDF inflicted massive casualties in the enemy forces, while also sustaining massive losses themselves"+
"Their efforts were not entirely in vain, as an Imperial Regiment in a neighbouring sector soon came to their aid.They were promised huge reinforcements as this sector was a valuable asset to the Imperium, controling routes to & from many industrial centres."+
"Also, because of the presence of a Space Marine Tthunderhawk refuelling depot in the Bunker Complex itself, the Adeptus Astartes rapidly deployed a Space Marine Chapter to aid in its defence."+
"However, due to an incoming Warp Storm, further Imperial Reinforcements were forced to turn back & now the whole Sector is cut off from the Imperium, & any hopes of further aid."+
"The PDF, Space Marines & the Imperial Guard regiment then withdrew to Bunker 149 & prepared for a long & bloody defence of the Bunker Complex & the planet itself.They hoped to hold out against the invaders & wait out the Warp Storm for further ";
        static void Main(string[] args)
        {
            Dictionary < string, int> dict= Frequency(text);
            //for (int i = 0; i < dict.Count; i++)
            //{
            //    Console.WriteLine($"Words {dict.Keys} values = {dict.Values} ");
            //}

            foreach (var word in dict)
            {
                Console.WriteLine($"Words {word.Key} values = {word.Value} ");
            }
            Console.ReadKey();
        }
       
        static Dictionary<string, int> Frequency(string text)
        {
            Dictionary<string, int> keyValues = new Dictionary<string, int>();
            string[] wordArray = Regex.Split(text, "[^A-Za-z]",RegexOptions.IgnorePatternWhitespace);
            for (int i = 0; i < wordArray.Length; i++)
            {
                if (string.IsNullOrEmpty(wordArray[i]))
                {
                    continue;
                }

                if (keyValues.ContainsKey(wordArray[i]))
                {
                    keyValues[wordArray[i]]++;
                }
                else
                {
                    keyValues.Add(wordArray[i], 1);
                }
            }
            return keyValues;
        }
    }
}
