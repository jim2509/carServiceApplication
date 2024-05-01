using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5FNFJ.LoadFile
{
    
      internal class Loader<T> where T : class
        {
            private Parser parser = new Parser();

            public List<T> LoadFile(string filePath)
            {
                List<T> works = new List<T>();
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] columns = line.Split(';');
                    T work = parser.Parse(columns) as T;
                    works.Add(work);
                }

                return works;
            }
        }

    }

