using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaSearch
{
    class SearchLine
    {
        public string Text { get; set; }
        public int LineNumber { get; set; }
        public SearchLine(int num, string txt) { LineNumber = num; Text = txt; }
    }

    class SearchFile
    {
        public string Name { get; set; }
        public long Length { get; set; } = 0;
        public List<SearchLine> MatchedLines { get; set; }
        public DateTime LastModified { get; set; }
        public SearchFile(string name, long size, DateTime modified, string uncompiledFile) { Name = name; Length = size; LastModified = modified; UncompiledFile = uncompiledFile; }

        //If searching DOC CHM, PDF, this is the name of the parent file, before we 'expand' it to other files.
        public string UncompiledFile { get; set; } = null;
    }

    class SearchDir
    {
        public SearchDir(string path) { Name = path; }

        public string Name { get; set; } = "";
        public long SearchSizeBytes { get; set; } = 0;
      //  public long FileSearchSizeBytes { get; set; } = 0;
        public List<SearchDir> Dirs { get; set; } = new List<SearchDir>();
        public List<SearchFile> Files { get; set; } = new List<SearchFile>();
        public long TotalNumSubFiles { get; set; } = 0;
    }

}
