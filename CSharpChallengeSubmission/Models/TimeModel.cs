using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeSubmission.Models
{
    public class TimeModel
    {
        public string CurrentTime { get; set; }

        public TimeModel()
        {
            CurrentTime = DateTime.Now.ToString("F"); 
        }
    }
}
