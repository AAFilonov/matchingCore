﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace MatchingSystem.UI.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<WorkDirection> WorkDirection { get; set; }
        public IEnumerable<Technology> Technology { get; set; }
    }
}
