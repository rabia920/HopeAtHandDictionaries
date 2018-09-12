﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Poem
    {
        public int PoemId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Theme { get; set; }
        public string Tag { get; set; }
    }
    public class WritingAssignment
    {
        public int WritingAssignmentId { get; set; }
        public string Title { get; set; }
        public string Theme { get; set; }
        public string Tag { get; set; }
    }
    public class ArtPiece
    {
        public int ArtPieceId { get; set; }
        public string Title { get; set; }
        public string Theme { get; set; }
        public string Tag { get; set; }
    }
    public class LessonPlan
    {
        public int LessonPlanId { get; set; }
        public int PoemId { get; set; }
        public int WritingAssignmentId { get; set; }
        public int ArtPieceId { get; set; }
    }
}
