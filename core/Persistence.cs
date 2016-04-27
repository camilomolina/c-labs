using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using IBatisNet.Common;
using IBatisNet.DataMapper;
using c_labs.common;

namespace c_labs.core
{
    class Persistence
    {
        public static ISqlMapper EntityMapper
        {
            get
            {
                try
                {
                    ISqlMapper mapper = Mapper.Instance();
                    return mapper;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static IList<ValueObject> sqlTest()
        {
            ISqlMapper mapper = EntityMapper;
            IList<Hashtable> values = (IList<Hashtable>)mapper.QueryForList<Hashtable>("sqlTest", null);

            return Utils.convertToList(values);
        }
    }
}
