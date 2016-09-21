using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Data;
//using BookLending.Classes;

namespace BookLending.Repository
{
    public abstract partial class EntityRepository
    {

        private string filePath;
        private string directory;

        public string Directory
        {
            get { return directory; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    string exeName =
                        Assembly.GetExecutingAssembly().Location;
                    directory =
                        Path.GetDirectoryName(exeName) + "\\Repository";
                }
                else
                {
                    directory = value.Trim();
                }
                if (!File.Exists(directory))
                    System.IO.Directory.CreateDirectory(directory);
                filePath = directory + "\\";
            }
        }

        public EntityRepository(string directory = "")
        {
            this.Directory = directory;
        }
    }
}
