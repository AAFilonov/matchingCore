using System.Collections.Generic;
using DataLayer.Entities;

namespace MatchingSystem.UI.ResultModels
{
    public class AdjustmentData
    {
        public IEnumerable<Tutor> Tutors { get; set; }
        public IEnumerable<Allocation> Allocations { get; set; }
        public List<Project> Projects { get; set; }
    }
}