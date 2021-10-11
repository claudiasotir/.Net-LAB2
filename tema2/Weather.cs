using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema2
{
    class Weather : DataFileProcessor
    {
        private string[] monthlyMean;

        public Weather()
        {
            fileName = "weather.dat";
            printValueColumn = 1;
            maxValColumn = 2;
            minValColumn = 3;

            printValueColumn--;
            maxValColumn--;
            minValColumn--;
        }

        protected override void ModifyData()
        {
            monthlyMean = words[words.Length - 1];

            string[][] newWords = new string[words.Length - 1][];

            for (int k = 0; k < words.Length - 1; k++)
            {
                newWords[k] = new string[words[k].Length];
                for (int i = 0; i < 3; i++)
                {
                    newWords[k][i] = new string(words[k][i].Where(x => char.IsDigit(x)).ToArray());
                }
                for (int i = 3; i < words[k].Length; i++)
                {
                    newWords[k][i] = words[k][i];
                }
            }

            words = newWords;
        }
    }
}
