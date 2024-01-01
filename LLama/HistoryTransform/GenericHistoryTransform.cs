using LLama.Abstractions;
using LLama.Common;
using System.Text;

namespace LLama.HistoryTransform
{
    public class GenericHistoryTransform : IHistoryTransform
    {
        public GenericHistoryTransform(PromptKeyWords keyWords)
        {
            KeyWords = keyWords;
        }
        public PromptKeyWords KeyWords { get; }

        public string HistoryToText(ChatHistory history)
        {
            StringBuilder sb = new();
            foreach (var message in history.Messages)
                sb.AppendLine($"{KeyWords.Start}{RoleToName(message.AuthorRole)}{KeyWords.AfterRole}{message.Content}{KeyWords.End}");

            return sb.ToString();
        }

        public ChatHistory TextToHistory(AuthorRole role, string text)
        {
            ChatHistory history = new ChatHistory();
            history.AddMessage(role, TrimNamesFromText(text, role));
            return history;
        }

        string RoleToName(AuthorRole role)
        {
            return role switch
            {
                AuthorRole.User => KeyWords.User,
                AuthorRole.System => KeyWords.System,
                AuthorRole.Assistant => KeyWords.Assistant,
                AuthorRole.Unknown => KeyWords.Unknown,
                _ => KeyWords.Unknown
            };
        }

        private string TrimNamesFromText(string text, AuthorRole role)
        {
            var startLength = KeyWords.Start.Length + RoleToName(role).Length + KeyWords.AfterRole.Length;
            text = text.Substring(startLength, startLength - KeyWords.End.Length).Trim();
            return text;
        }
    }
}
