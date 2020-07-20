using System;

namespace QueueNS
{
    public class StringEntry
    {
        private readonly string _data;
        private StringEntry _previous;
        private StringEntry _next = null;

        /* Function StringEntry(String s, StringEntry _backOfLine = null) [Constructer]
         * Parameters: String s -> a string to be assigned to a StringEntry item
         *             StringEntry _backOfLine = null -> Optional parameter, used to set both _previous and _next attributes of a StringEntry. 
         *
         * Description: 
         * The StringEntry constructor will set the _data of the item, and will set the "_previous" field to the _backOfLine StringEntry. 
         * It then will go into the "_previous" StringEntry and set its "_next" field to the current StringEntry item. 
         */
        public StringEntry(string s, StringEntry backOfLine = null)
        {
            this._data = s;

            _ = backOfLine == null ? this._previous = null : _previous = backOfLine;


            if (this._previous != null)
            {
                this._previous._next = this;
            }

        }

        public string GetData()
        {
            return this._data;
        }

        public StringEntry GetNext()
        {
            return this._next;
        }

    }
}