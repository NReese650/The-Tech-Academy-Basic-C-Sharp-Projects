using System;
using System.Collections.Generic;
using System.Linq;
using ChallengeSubmission.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChallengeSubmission.Pages
{
    public class TimePageModel : PageModel
    {
        public TimeModel CurrentTime { get; set; }

        public void OnGet()
        {
            CurrentTime = new TimeModel(); // Create an instance of TimeModel
        }
    }
}
