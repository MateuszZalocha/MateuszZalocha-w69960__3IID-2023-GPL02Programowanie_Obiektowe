using interfaces;

namespace Lab2.Lab6
{
    public class Book : IEntity<long>, ICreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}