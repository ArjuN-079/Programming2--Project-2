using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public abstract class lifeline
    {
        protected Random random = new Random();
        public bool IsUsed { get; protected set; } = false;
        public abstract bool IsAvailable(int level);
        public abstract string Use(Question question, int level);

    }
}
