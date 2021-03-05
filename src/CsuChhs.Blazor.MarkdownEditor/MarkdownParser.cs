using Markdig;

namespace CsuChhs.Blazor.MarkdownEditor
{
    public static class MarkdownParser
    {
        public static string Parse(string value)
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