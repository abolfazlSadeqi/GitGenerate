using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces;

public interface IGitConceptService
{
    List<GitConcept> GetByCategory(GitConceptCategory category, Language lang);
    GitConcept? GetConcept(string key, Language lang);
}

