using LLama.Abstractions;

namespace LLama.HistoryTransform
{
    public static class HistoryTransformFactory
    {
        public static IHistoryTransform MistralHistoryTransform() => new GenericHistoryTransform(PropmptKeyWordsFactory.MistralKeyWords());
        public static IHistoryTransform OpenChatHistoryTransform() => new GenericHistoryTransform(PropmptKeyWordsFactory.OpenChatKeyWords());
    }
}
