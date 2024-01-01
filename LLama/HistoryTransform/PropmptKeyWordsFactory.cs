namespace LLama.HistoryTransform
{
    public static class PropmptKeyWordsFactory
    {
        public static PromptKeyWords MistralKeyWords() => new PromptKeyWords("<|im_start|>", "<|im_end|>", "user", "system", "assistant", "unknown", "\n");
        public static PromptKeyWords OpenChatKeyWords() => new PromptKeyWords(string.Empty, "<|end_of_turn|>", "GPT4 Correct User", "System", "GPT4 Correct Assistant", "Unknown", ": ");
    }
}
