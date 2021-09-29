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

        public Progress (string progress)
        {
            StudentProgress = Convert.ToInt32(progress);
        }

        public int StudentProgress
        {
            get
            {
                return studentProgress;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(Convert.ToString(value)))
                {
                    throw new ArgumentNullException("Поле оценок студента не может быть пустым.");
                }
                studentProgress = Convert.ToInt32(value);
            }
        }

    }
}
