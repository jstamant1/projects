using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Image
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Image(string path, string name)
        {
            Name = name;
            Path = path;
        }

        public static Image Create(string path, string name)
        {
            return new Image(path, name);
        }

        public void Save()
        {

        }
    }
}
