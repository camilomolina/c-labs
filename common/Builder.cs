using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_labs.common
{
    class Builder
    {

        public static IList<ValueObject> selectBuilder()
        {
            IList<ValueObject> result = new List<ValueObject>();
            ValueObject o = new ValueObject();
            o.id = 1;
            o.desc = "Valor 1";
            result.Add(o);

            o = new ValueObject();
            o.id = 2;
            o.desc = "Valor 2";
            result.Add(o);

            o = new ValueObject();
            o.id = 3;
            o.desc = "Valor 3";
            result.Add(o);

            o = new ValueObject();
            o.id = 4;
            o.desc = "Valor 4";
            result.Add(o);

            return result;
        }

    }
}
