using System.Text.Json.Serialization;

namespace LLama.HistoryTransform
{
    public class PromptKeyWords
    {
        [JsonConstructor]
        public PromptKeyWords(string start, string end, string user, string system, string assistant, string unknown, string afterRole)
        {
            Start = start;
            End = end;
            User = user;
            System = system;
            Assistant = assistant;
            Unknown = unknown;
            AfterRole = afterRole;
        }

        [JsonPropertyName(nameof(Start))]
        public string Start { get; }

        [JsonPropertyName(nameof(End))]
        public string End { get; }

        [JsonPropertyName(nameof(AfterRole))]
        public string AfterRole { get; }

        [JsonPropertyName(nameof(System))]
        public string System { get; }

        [JsonPropertyName(nameof(User))]
        public string User { get; }

        [JsonPropertyName(nameof(Assistant))]
        public string Assistant { get; }

        [JsonPropertyName(nameof(Unknown))]
        public string Unknown { get; }
    }
}
