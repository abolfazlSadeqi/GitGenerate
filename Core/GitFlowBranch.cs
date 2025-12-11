namespace Core;

public class GitFlowBranch
{
    public string Name { get; set; }
    public string Display { get; set; }
    public Dictionary<string, string> Description { get; set; } = new(); // en/fa
    public string Parent { get; set; } // From which branch it is created
    public string MergeTarget { get; set; } // To which branch it is merged
    public Dictionary<string, List<string>> Rules { get; set; } = new();
    public Dictionary<string, List<string>> Challenges { get; set; } = new();
    public Dictionary<string, List<string>> Solutions { get; set; } = new();
    public Dictionary<string, List<string>> Notes { get; set; } = new(); // Additional tips
}
