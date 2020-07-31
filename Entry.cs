using System;
using HelloWorld;

namespace HelloWorld
{
    public class Entry : IEntry
    {
        private readonly Object _data;
        private Entry _next = null;

        /* Function Entry(String itemToPush, Entry _backOfLine = null) [Constructer]
         * Parameters: String itemToPush -> a string to be assigned to a Entry item
         *             Entry _backOfLine = null -> Optional parameter, used to set both _previous and _next attributes of a Entry. 
         *
         * Description: 
         * The Entry constructor will set the _data of the item, and will set the "_previous" field to the _backOfLine Entry. 
         * It then will go into the "_previous" Entry and set its "_next" field to the current Entry item. 
         */

        public Entry(Object itemToPush, IEntry backOfLine = null)
        {
            Entry previous;

            this._data = itemToPush;

            _ = backOfLine == null ? previous = null : previous = (Entry)backOfLine;


            if (previous != null)
            {
                previous._next = this;
            }

        }

        public Object GetData()
        {
            return this._data;
        }

        public Entry GetNext()
        {
            return this._next;
        }

    }
}