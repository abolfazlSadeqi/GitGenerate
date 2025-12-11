using Core;

namespace Service.Interfaces;

public interface IVersionService
{
    VersionList GetAllVersions();
    VersionDetail GetVersion(int id);
    VersionDetail CreateVersion(VersionDetail newVersion);
    VersionDetail CreateNextVersion(int previousVersionId, string changeType, string preRelease = "", string description = "");
}
