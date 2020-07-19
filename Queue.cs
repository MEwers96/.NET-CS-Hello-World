using System;

namespace HelloWorld{ 
public class Queue
{
    private StringEntry _firstInLine = null;
    private StringEntry _backOfLine = null;


    /* Function: add(String s)
     * Parameters: String s -> a string to add to the queue.
     * 
     * Description:
     * The add function will create a new StringEntry with the parameter given. If there is no
     * first item in the queue, it will then set both the back and front to the queue. 
     */
    public void Push(string s)
    {

        if (_backOfLine == null)
        {
            var firstEntry = new StringEntry(s);
            _firstInLine = firstEntry;
            _backOfLine = firstEntry;
        }

        else
        {
            var entry = new StringEntry(s, _backOfLine);
            _backOfLine = entry;
        }

    }


    /* Function: pop()
     * Parameters: NONE
     * 
     * Description:
     * The pop function will take the data from the _firstInLine StringEntry item, and then return the results.
     * If the current _firstInLine item is null, then the function will write to the console with an err message.
     */
    public string Pop()
        {
            string result;
            if(_firstInLine == null){

                Console.WriteLine("There are no items in the queue. Please use the 'push' function to queue a new item");
                result = "NULL";    
            }
            else{

                result = _firstInLine.GetData();
                _firstInLine = _firstInLine.GetNext();
            }
                
            return result;

        }

    public class StringEntry
    {
        readonly string _data;
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
}
