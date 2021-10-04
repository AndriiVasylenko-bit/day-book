using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayBook
{
    class Progress
    {
        private int studentProgress;

        public Progress (int progress)
        {
            StudentProgress = progress;
        }

        public int StudentProgress
        {
            
            get
            {
                return studentProgress;
            }
            set
            {
                studentProgress = StudentProgress;               
            }
        }

    }
}
