using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema2
{
    public abstract class DataFileProcessor
    {
        protected string fileName;
        protected string[][] words;
        protected string[] headers;

        protected int printValueColumn;
        protected int maxValColumn;
        protected int minValColumn;

        protected abstract void ModifyData();
        public void ReadData()
        {
            //current PROJECT directory, not bin/Debug etc
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            path += "/Resources/";

            StreamReader readFile = new StreamReader(path + fileName, Encoding.Default);

            char[] separators = { '\n' };

            string[] lines = readFile.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            words = new string[lines.Length - 1][];

            headers = lines[0].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < lines.Length; i++)
            {
                words[i - 1] = lines[i].Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            }
            ModifyData();
        }

        public void PrintDataSet()
        {
            for (int i = 0; i < words.Length; ++i)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i][j] + " ");
                }
                Console.Write("\n");
            }
        }

        public string GetValueWithMinDifference()
        {
            int returnValueLine = 0;
            int maxVal = Convert.ToInt32(words[0][maxValColumn]);
            int minVal = Convert.ToInt32(words[0][minValColumn]);

            int maxCurrentTemp, minCurrentTemp;
            for (int i = 1; i < words.Length; i++)
            {
                maxCurrentTemp = Convert.ToInt32(words[i][maxValColumn]);
                minCurrentTemp = Convert.ToInt32(words[i][minValColumn]);

                if (maxVal - minVal > maxCurrentTemp - minCurrentTemp)
                {
                    maxVal = maxCurrentTemp;
                    minVal = minCurrentTemp;
                    returnValueLine = i;
                }
            }
            return words[returnValueLine][printValueColumn];
        }
    }
}
