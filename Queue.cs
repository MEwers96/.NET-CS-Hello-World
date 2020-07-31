using System;
using HelloWorld;

namespace HelloWorld{
    public class Queue : IQueue
    {
        private IEntry _firstInLine = null;
        private IEntry _backOfLine = null;


        /* Function: add(String s)
         * Parameters: String s -> a string to add to the queue.
         * 
         * Description:
         * The add function will create a new Entry with the parameter given. If there is no
         * first item in the queue, it will then set both the back and front to the queue. 
         */

        public void Push(Object s)
        {

            if (_firstInLine == null)
            {
                var firstEntry = HelloWorld.Factory.CreateEntry(s);
                _firstInLine = firstEntry;
                _backOfLine = firstEntry;
            }

            else
            {
                var entry = Factory.CreateEntry(s, _backOfLine);
                _backOfLine = entry;
            }

        }


        /* Function: pop()
         * Parameters: NONE
         * 
         * Description:
         * The pop function will take the data from the _firstInLine Entry item, and then return the results.
         * If the current _firstInLine item is null, then the function will write to the console with an err message.
         */
        public Object Pop()
        {
            Object result;
            if (_firstInLine == null)
            {

                Console.WriteLine("There are no items in the queue. Please use the 'push' function to queue a new item");
                result = null;
            }
            else
            {

                result = _firstInLine.GetData();
                _firstInLine = _firstInLine.GetNext();
            }

            return result;

        }


    }
}
