
using Core;

namespace Service.Services;

public interface IGitIgnoreService
{
    public List<GitIgnoreTemplate> GetTemplates();
    List<GitIgnoreLanguage> GetLanguages();
    public string Generate(GitIgnoreRequest request);
}
public interface IGitFlowService
{
    List<GitFlowBranch> GetBranches();

    // گرفتن شاخه‌ها بر اساس زبان سایت
     List<GitFlowBranch> GetBranchesByLanguage(string lang);
    BranchPlan GenerateBranchPlan(BranchRequest req);
}