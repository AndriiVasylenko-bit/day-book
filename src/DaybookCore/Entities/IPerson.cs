namespace DaybookCore.Entities
{
    public interface IPerson
    {
        public string Name { get; set; }
        public Group Group { get; set; }
        public Point[]? Points { get; set; }
    }
}
