﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Doggolingo.Models
{
    public class Step
    {
        [Key]
        public int StepId { get; set; }
        public string Description { get; set; }
        public virtual Lesson Lesson { get; set; }

        public Step()
        {
        }
    }
}
