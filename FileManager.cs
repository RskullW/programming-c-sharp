using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication1
{
    public class FileManager: IDisposable
    {
        private IntPtr _file;
        
        [DllImport("file32.dll")]
        private static extern IntPtr open(string path, bool read);
        [DllImport("file32.dll")]
        private static extern void close(IntPtr file);
        [DllImport("file32.dll")]
        public static extern bool read(IntPtr file, int num, StringBuilder word);
        [DllImport("file32.dll")]
        public static extern void write(IntPtr file, string text);
        [DllImport("file32.dll")]
        public static extern int length(IntPtr file);

        public FileManager(string path, bool read)
        {
            _file = open(path, read);

            if (_file == null)
            {
                throw new Exception("Error. File not opened!\n");
            }
        }

        public void Dispose()
        {
            close(_file);
        }

        public int GetLength()
        {
            return length(_file);
        }
        
        public void WriteFile(string text)
        {
            write(_file, text);
        }
        
        public void ReadFile(int num, StringBuilder word)
        {
            read(_file, num, word);
        }

    }
}