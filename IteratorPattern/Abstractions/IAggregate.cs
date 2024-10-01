namespace IteratorPattern.Abstractions
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
