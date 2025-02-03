public class GenericEventArgs<T> : EventArgs
{
    public T Data { get; }

    public GenericEventArgs(T data)
    {
        this.Data = data;
    }
}

public class EventPublisher
{
    public event EventHandler<GenericEventArgs<string>> GenericEvent;

    public void RaiseEvent(string message)
    {
        GenericEvent?.Invoke(this, new GenericEventArgs<string>(message));
    }
}


var publisher = new EventPublisher();
publisher.GenericEvent += (sender, args) => Console.WriteLine(args.Data);
publisher.RaiseEvent("Generic Event Raised!");
