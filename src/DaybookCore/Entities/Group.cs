namespace DaybookCore.Entities
{
    public class Group
    {
        public long Id { get; set; }
        public List<Student>? Participants { get; set; }

        public Group(long id, List<Student>? participants)
        {
            Id = id;
            Participants = participants;
        }
    }
}
