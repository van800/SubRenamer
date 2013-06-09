using System;
using System.Collections.Generic;
using System.Text;

namespace SubRenamer
{
    class Subsidary
    {
        public static bool PathIsDirectory(string path)
        {
            System.IO.FileInfo info = new System.IO.FileInfo(path);
            return (info.Attributes & System.IO.FileAttributes.Directory) == System.IO.FileAttributes.Directory;
        }
    }
}
