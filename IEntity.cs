namespace Lab2.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}