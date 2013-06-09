using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SubRenamer
{
    class Subsidary
    {
        public static bool PathIsDirectory(string path)
        {
            FileInfo info = new FileInfo(path);
            return (info.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }
    }
}
