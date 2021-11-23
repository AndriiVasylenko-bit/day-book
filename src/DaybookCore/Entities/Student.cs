namespace DaybookCore.Entities
{
    public class Student : IPerson
    {
        public Student(string name, Group group, Point[]? points)
        {
            Name = name;
            Group = group;
            Points = points;
        }

        public string Name { get; set; }
        public Group Group { get; set; }
        public Point[]? Points { get; set; }
    }
}
