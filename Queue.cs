using System;
using QueueNS;

namespace QueueNS{ 
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


}
}
