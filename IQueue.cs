namespace HelloWorld
{
    public interface IQueue
    {
        object Pop();
        void Push(object itemToPush);
    }
}