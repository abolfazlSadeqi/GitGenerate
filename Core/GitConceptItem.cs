using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core;

public class GitConceptItem
{
    public string Key { get; set; }          // example: dotgit_folder
    public string Title { get; set; }        // localized title
    public string Description { get; set; }  // localized description
    public string Example { get; set; }      // code block
}
