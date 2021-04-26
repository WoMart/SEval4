using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    [JsonObject]
    public class JsonScenario
    {
        [JsonProperty("Context")]
        public string Context { get; set; }
        [JsonProperty("Order")]
        public int Order { get; set; }
        [JsonProperty("Responses")]
        public JsonScenarioResponse[] Responses { get; set; }
    }

    [JsonObject]
    public class JsonScenarioResponse
    {
        [JsonProperty("Text")]
        public string Text { get; set; }
        [JsonProperty("Value")]
        public int Value { get; set; }
        [JsonProperty("Tag")]
        public string Tag { get; set; }
        [JsonProperty("Correct")]
        public bool Correct { get; set; }
    }
}
