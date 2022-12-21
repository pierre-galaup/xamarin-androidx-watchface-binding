using System.Collections;
using Java.Lang;
using Java.Util;
using ICollection = System.Collections.ICollection;

namespace Androidx.Wear.Watchface.Style;

public partial class UserStyle
{
    ICollection IMap.EntrySet()
    {
        return (ICollection)new object();
    }

    Object? IMap.Get(Object? key)
    {
        return (Object)new object();
    }

    ICollection IMap.KeySet()
    {
        return (ICollection)new object();
    }

    Object? IMap.Remove(Object? key)
    {
        return (Object)new object();
    }

    public Object? Put(Object? key, Object? value)
    {
        //
        return (Object)new object();
    }

    public void PutAll(IDictionary m)
    {
        //
    }

    int IMap.Size()
    {
        return Size;
    }

    ICollection IMap.Values()
    {
        return (ICollection)new object();
    }
}