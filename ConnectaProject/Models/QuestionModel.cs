using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class QuestionModel
    {
        public int QuestionKey { get; set; }

        public int Sequence { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public char AnswerType { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}