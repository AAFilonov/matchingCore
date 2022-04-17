﻿using System.Collections.Generic;
using DataLayer.Entities;

namespace MatchingSystem.UI.ResultModels
{
    public class TutorProjectsModel
    {
        public int CommonQuota { get; set; }
        public List<Project> Projects { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Technology> Technology { get; set; }
        public IEnumerable<WorkDirection> WorkDirections { get; set; }
        public bool IsReady { get; set; }
    }
}
