using System;
using Newtonsoft.Json;

namespace PodioAPI.Models
{
    public class QuestionOption
    {
        [JsonProperty("question_option_id")]
        public long QuestionOptionId { get; set; }

        [JsonProperty("text")]
        public String Text { get; set; }
    }
}