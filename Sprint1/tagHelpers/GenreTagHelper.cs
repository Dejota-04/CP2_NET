using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace CP2.TagHelpers
{
    [HtmlTargetElement("genre-tag")]
    public class GenreTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";

            output.AddClass("badge", HtmlEncoder.Default);
            output.AddClass("bg-primary", HtmlEncoder.Default);

            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}