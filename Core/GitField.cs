
namespace Core;

public class GitField
{
    public string Name { get; set; }
    public string LabelEn { get; set; }
    public string LabelFa { get; set; }
    public string Type { get; set; } // text, number, checkbox
    public string PlaceholderEn { get; set; }
    public string PlaceholderFa { get; set; }
    public bool IsRequired { get; set; } = false;
    public List<GitOption>? Options { get; internal set; }
}

