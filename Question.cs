using Newtonsoft.Json;

namespace kQuickTrivia
{
    public class Question
    {
        [JsonProperty("question")]
        public string Text { get; set; }
        [JsonProperty("options")]
        public string[] Options { get; set; }
        [JsonProperty("answer")]
        public string Answer { get; set; }
    }
}