using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class SurveyAnswerModel
    {
        public int SurveyAnswerKey { get; set; }

        public int SurveyUserKey { get; set; }

        public int QuestionKey { get; set; }

        public float ValueN { get; set; }

        public DateTime ValueD { get; set; }

        public string ValueT { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}