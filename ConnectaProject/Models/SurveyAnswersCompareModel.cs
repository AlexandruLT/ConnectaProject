﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class SurveyAnswersCompareModel
    {
        public int SurveyAnswerCompareKey { get; set; }

        [Required]
        public int QuestionKey { get; set; }

        public int SurveyUserAKey { get; set; }

        public int SurveyUserBKey { get; set; }

        public int Score { get; set; }

        public string Note { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}