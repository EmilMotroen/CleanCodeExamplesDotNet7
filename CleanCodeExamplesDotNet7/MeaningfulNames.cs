using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExamplesDotNet7
{
    class MeaningfulNames
    {
        private string _strDesc;  // Description of ... with type encoding 

        public void SetDescription(string description)
        {
            _strDesc = description;
        }

        public string GetDescription()
        {
            return _strDesc;
        }
    }
}
