using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FORECAST
    {

        public override string ToString()
        {
            return $"{CityName,30} {Date,30}{TEMPERATUREMin,10} {TEMPERATUREMax,10}  {PRESSUREMin,10} {PRESSUREMax,10} ";
        }

        public string CityName { get; set; }
        public string Date { get; set; }
        private string TEMPERATUREMaxField;
        private string TEMPERATUREMinField;

        private string PRESSUREMinField;
        private string PRESSUREMaxField;
        public string PRESSUREMax { get { return $"{PRESSUREMaxField} мм.рт.ст."; } set { PRESSUREMaxField = value; } }
        public string PRESSUREMin { get { return $"{PRESSUREMinField} мм.рт.ст."; } set { PRESSUREMinField = value; } }
        public string TEMPERATUREMax { get { return $"{TEMPERATUREMaxField} °c"; } set { TEMPERATUREMaxField = value; } }
        public string TEMPERATUREMin { get { return $"{TEMPERATUREMinField} °c"; } set { TEMPERATUREMinField = value; } }
    }
}
