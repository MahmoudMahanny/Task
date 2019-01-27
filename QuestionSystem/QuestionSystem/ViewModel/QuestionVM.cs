using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionSystem.ViewModel
{
    public class QuestionVM
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string UserId { get; set; }
    }
}