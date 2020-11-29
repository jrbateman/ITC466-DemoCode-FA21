using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTestDemo
{
    public class FileProcess
    {

        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }

            return File.Exists(fileName);
        }

    }
}
