﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using DataLayer.Entities;

namespace MatchingSystem.UI.RequestModels
{
    public class ChangeQuotaRequest
    {
        [JsonPropertyName("deltas")]
        public List<ProjectQuota> Deltas { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("tutorId")]
        public int TutorId { get; set; }
        [JsonPropertyName("newQuota")]
        public short NewQuotaQty { get; set; }
    }
}