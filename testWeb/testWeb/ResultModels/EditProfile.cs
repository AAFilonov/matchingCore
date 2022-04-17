﻿using System.Collections.Generic;
using DataLayer.Entities;

namespace MatchingSystem.UI.ResultModels
{
    public class EditProfile
    {
        public IEnumerable<WorkDirection> WorkDirections { get; set; }
        public IEnumerable<Technology> Technologies { get; set; }
        public string Info { get; set; }
        public string Info2 { get; set; }
    }
}
