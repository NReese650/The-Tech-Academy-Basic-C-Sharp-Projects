using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpChallengeSubmission.Models
{
    public class Time
    {
        public string CurrentTime { get; set; }

        public Time()
        {
            CurrentTime = DateTime.Now.ToString("F"); 
        }
    }
}
