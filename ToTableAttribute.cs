using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    [AttributeUsage(AttributeTargets.All , AllowMultiple =true)]
    public class ToTableAttribute : Attribute
    {
        string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
