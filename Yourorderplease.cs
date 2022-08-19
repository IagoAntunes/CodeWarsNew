using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Yourorderplease
    {
        public string Opa(string words){
            var phrase = words.Split(' ');
            string[] wordsNew = new string[phrase.Length];
            foreach(var word in phrase){
                foreach(var caracter in word){
                    if(int.TryParse(caracter.ToString(),out int numericValue)){
                        int index = int.Parse(caracter.ToString());
                        wordsNew[index-1] = word;
                    }
                }
            }
            return string.Join(' ',wordsNew);
        }
    }
}