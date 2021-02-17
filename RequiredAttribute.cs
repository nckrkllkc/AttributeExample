using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    [AttributeUsage(AttributeTargets.All)] // Bu attribute herşeye kullanılır
    //[AttributeUsage(AttributeTargets.Class)] Classlarda kullanılır.
    //[AttributeUsage(AttributeTargets.Property)]  Propertylerde kullanılır.
    //[AttributeUsage(AttributeTargets.Field)]  Fieldlarda kullanılır.
    //[AttributeUsage(AttributeTargets.Field) | AttributeUsage(AttributeTargets.Class)]  Field ve classlarda kullanılır.
    //[AttributeUsage(AttributeTargets.Class,AllowMultiple = true)] Aynı nesneye birden fazla kullanılabilir
    public class RequiredAttribute : Attribute
    {
        //without parameters

    }
}
