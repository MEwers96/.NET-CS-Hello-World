using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class Factory
    {

        public static IQueue CreateQueue()
        {
            return new Queue();
        }

        public static IEntry CreateEntry(object s, IEntry backEntry = null)
        {
            return new Entry(s, backEntry);
        }

    }
}
