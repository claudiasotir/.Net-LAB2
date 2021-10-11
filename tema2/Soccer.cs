using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema2
{
    class Soccer : DataFileProcessor
    {
        public Soccer()
        {
            fileName = "football.dat";
            printValueColumn = 2;
            maxValColumn = 7;
            minValColumn = 9;

            printValueColumn--;
            maxValColumn--;
            minValColumn--;
        }

        protected override void ModifyData()
        {
            //throw new NotImplementedException();
        }
    }
}
