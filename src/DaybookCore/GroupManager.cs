using DaybookCore.Entities;

namespace DaybookCore
{
    public static class GroupManager
    {
        private static readonly List<Group> _groups;

        static GroupManager()
        {
            _groups = new List<Group>();
        }

        public static void AddStudent(long groupId, Student student)
        {
            _groups?.FirstOrDefault
            (
                group => group.Id == groupId
            )?.Participants?.Add(student);
        }

        public static void RemoveStudent(long groupId, Student student)
        {
            _groups?.FirstOrDefault
            (
                group => group.Id == groupId
            )?.Participants?.Remove(student);
        }

        public static void AddGroup(Group group)
        {
            _groups.Add(group);
        }

        public static void DeleteGroup(Group group)
        {
            _groups.Remove(group);
        }
    }
}
