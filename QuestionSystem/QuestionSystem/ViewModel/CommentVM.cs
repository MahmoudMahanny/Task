using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionSystem.ViewModel
{
    public class CommentVM
    {
        public int CommentID { get; set; }
        public string Comment { get; set; }
        public int QuestionId { get; set; }
        public string UserID { get; set; }
    }
}