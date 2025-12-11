using Core;

namespace Service.Interfaces;

public interface IGitTagService
{
    string GenerateCommand(GitTagModel model);
    string GetDescriptionEN();
    string GetDescriptionFA();
    IEnumerable<string> SuggestSemanticNextTags(string currentTag); // helper
}
