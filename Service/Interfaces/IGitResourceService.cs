using Core;

namespace Service.Interfaces;

public interface IGitResourceService
{
    IEnumerable<GitResource> GetAll(string lang = "EN", string category = null, string q = null, int page = 1, int pageSize = 50);
    IEnumerable<string> GetCategories(string lang = "EN");
    GitResource GetById(int id);
}
