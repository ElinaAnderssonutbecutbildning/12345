﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TestAnswer
    {
        public int TestAnswerID { get; set; }
        public int AnswerID { get; set; }

        public Answer Answer { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}