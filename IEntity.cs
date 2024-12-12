namespace interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}