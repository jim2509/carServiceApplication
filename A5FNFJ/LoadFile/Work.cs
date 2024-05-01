using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5FNFJ.LoadFile
{
    public class Work
    {
        
        private readonly string nameOfWork;
        private readonly int requiredTimeInMinutes;
        private readonly int materialCosts;

        public Work(string nameOfWork, int requiredTimeInMinutes, int materialCosts)
        {
            this.nameOfWork = nameOfWork;
            this.requiredTimeInMinutes = requiredTimeInMinutes;
            this.materialCosts = materialCosts;
        }
        
        public string getNameOfWork()
        {
            return nameOfWork;
        }
        public int getRequiredTimeInMinutes()
        {
            return requiredTimeInMinutes;
        }
        public int getMaterialCosts()
        {
            return materialCosts;
        }
        public int ServiceHour => getRequiredTimeInMinutes() / 60;
        public int ServiceMinute => getRequiredTimeInMinutes()% 60;

    }
}
