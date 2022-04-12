using System.Collections.Generic;
using DataLayer.Entities;

namespace MatchingSystem.UI.ResultModels
{
    public class RolesAndMatchingForUser
    {
        public List<Matching> Matchings { get; set; }
        public List<Role> Roles { get; set; }
    }
}