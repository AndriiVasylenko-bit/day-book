namespace DayBook.Src.Models
{
    public class Group
    {
        private readonly string _name;
        private uint _progress;

        public Group(string name, uint progress)
        {
            _name = name;
            _progress = progress;
        }

        public string Name => _name;
        public uint Progress
        {
            get => _progress;
            set => _progress = value;
        }

        public static bool operator >(Group group1, Group group2)
        {
            return group1.Progress > group2.Progress;
        }

        public static bool operator <(Group group1, Group group2)
        {
            return group1.Progress < group2.Progress;
        }
    }
}
