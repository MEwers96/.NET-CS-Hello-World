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

        public static Entry CreateEntry(object s, Entry backEntry = null)
        {
            return new Entry(s, backEntry);
        }

    }
}
