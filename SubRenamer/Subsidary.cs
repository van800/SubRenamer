using System.IO;

namespace SubRenamer
{
    class Subsidary
    {
        public static bool PathIsDirectory(string path)
        {
            var info = new FileInfo(path);
            return (info.Attributes & FileAttributes.Directory) == FileAttributes.Directory;
        }
    }
}
