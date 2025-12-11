using Core;

namespace Service.Interfaces;

public interface IGitSubmoduleService
{
    GitSubmoduleOutput GenerateCommands(GitSubmoduleInputModel input, string lang = "en");
    GitSubmoduleOutput SuggestConflictResolution(GitSubmoduleInputModel input, string lang = "en");
}
