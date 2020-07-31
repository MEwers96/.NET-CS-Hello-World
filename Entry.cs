using System;
using HelloWorld;

namespace HelloWorld
{
    public class Entry : IEntry
    {
        private readonly Object _data;
        private Entry _previous;
        private Entry _next = null;

        /* Function Entry(String s, Entry _backOfLine = null) [Constructer]
         * Parameters: String s -> a string to be assigned to a Entry item
         *             Entry _backOfLine = null -> Optional parameter, used to set both _previous and _next attributes of a Entry. 
         *
         * Description: 
         * The Entry constructor will set the _data of the item, and will set the "_previous" field to the _backOfLine Entry. 
         * It then will go into the "_previous" Entry and set its "_next" field to the current Entry item. 
         */

        public Entry(Object s, Entry backOfLine = null)
        {
            this._data = s;

            _ = backOfLine == null ? this._previous = null : _previous = backOfLine;


            if (this._previous != null)
            {
                this._previous._next = this;
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