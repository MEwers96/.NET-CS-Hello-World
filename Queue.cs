using System;

namespace myQueue { 
public class Queue
{
    StringEntry firstInLine = null;
    StringEntry backOfLine = null;


    /* Function: add(String s)
     * Parameters: String s -> a string to add to the queue.
     * 
     * Description:
     * The add function will create a new StringEntry with the parameter given. If there is no
     * first item in the queue, it will then set both the back and front to the queue. 
     */
    public void push(String s)
    {

        if (backOfLine == null)
        {
            StringEntry firstEntry = new StringEntry(s);
            firstInLine = firstEntry;
            backOfLine = firstEntry;
        }

        else
        {
            StringEntry entry = new StringEntry(s, backOfLine);
            backOfLine = entry;
        }

    }


    /* Function: pop()
     * Parameters: NONE
     * 
     * Description:
     * The pop function will take the data from the firstInLine StringEntry item, and then return the results.
     * If the current firstInLine item is null, then the function will write to the console with an err message.
     */
    public String pop()
        {
            String result;
            if(firstInLine == null){

                Console.WriteLine("There are no items in the queue. Please use the 'push' function to queue a new item");
                result = "NULL";    
            }
            else{

                result = firstInLine.data;
                firstInLine = firstInLine.next;
            }
                
            return result;

        }

    class StringEntry
    {
        public String data;
        StringEntry previous;
        public StringEntry next = null;

        /* Function StringEntry(String s, StringEntry backOfLine = null) [Constructer]
         * Parameters: String s -> a string to be assigned to a StringEntry item
         *             StringEntry backOfLine = null -> Optional parameter, used to set both previous and next attributes of a StringEntry. 
         *
         * Description: 
         * The StringEntry constructor will set the data of the item, and will set the "previous" field to the backOfLine StringEntry. 
         * It then will go into the "previous" StringEntry and set its "next" field to the current StringEntry item. 
         */
        public StringEntry(String s, StringEntry backOfLine = null)
        {
            this.data = s;

           _ = backOfLine == null ? this.previous = null : previous = backOfLine;


            if (this.previous != null)
            {
                this.previous.next = this;
            }

        }

    }
}
}
