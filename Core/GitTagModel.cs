namespace Core;

public class GitTagModel
{
    public string Branch { get; set; }
    public string TagName { get; set; }
    public bool IsAnnotated { get; set; }
    public bool UseGpgSign { get; set; }
    public bool ForceReplace { get; set; }
    public string Message { get; set; }
    public string MessageFile { get; set; }
    public string Target { get; set; }
    public string PreReleaseLabel { get; set; }
    public string VersionBump { get; set; }
    public bool PushAfter { get; set; }
    public string? GeneratedCommand { get; set; }
    public string Language { get; set; }
}
