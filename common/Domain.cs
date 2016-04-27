using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_labs.common
{

    public enum TypeEnum
    {
        NAME_1 = 1,
        NAME_2 = 2,
        NAME_3 = 3,
        NAME_4 = 4,
    }
    class ValueObject
    {
        public Int64 id { get; set; }
        public String desc { get; set; }
    }

    class Table1
    {
        public Int64 id { get; set; }
        public String description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public Decimal amount { get; set; }
    }

}
