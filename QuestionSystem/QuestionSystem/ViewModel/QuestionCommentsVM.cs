using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionSystem.ViewModel
{
    public class QuestionCommentsVM
    {
        public string Question { get; set; }
        List<CommentVM> Comments = new List<CommentVM>();
    }
}