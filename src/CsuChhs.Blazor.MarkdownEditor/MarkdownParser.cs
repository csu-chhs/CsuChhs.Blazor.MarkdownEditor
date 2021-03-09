using Markdig;

namespace CsuChhs.Blazor.MarkdownEditor
{
    internal static class MarkdownParser
    {
        internal static string Parse(string value)
        {
            if(!string.IsNullOrEmpty(value))
            {
                var pipeline = new MarkdownPipelineBuilder()
                    .UseEmojiAndSmiley()
                    .UseAdvancedExtensions()
                    .Build();

                return Markdown.ToHtml(value, pipeline);
            }
            return "";
        
        }
    }
}