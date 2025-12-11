namespace Core;

public class TagModel
{
    public string TagName { get; set; }        // div, span, p, img, a, button ...
    public string Id { get; set; }
    public string Class { get; set; }
    public string Style { get; set; }
    public string Attributes { get; set; }     // any additional attributes manually
    public string InnerText { get; set; }      // content inside tag
    public bool IsSelfClosing { get; set; }    // img, input, br ...

    public string GeneratedTag { get; set; }
}
