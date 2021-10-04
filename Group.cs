using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayBook
{
    class Group
    {
        private int groupNumber;

        
        public Group (int group)
        {
            GroupNumber = group;
        }

        public int GroupNumber
        {
            get
            {
                return groupNumber;
            }
            set
            {
                 groupNumber = GroupNumber;
            }
        }
    }
}
