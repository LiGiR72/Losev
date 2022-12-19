using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Losev
{
    internal class LosevIO
    {
        public DirectoryInfo directoryInfo;

        public LosevIO(string path)
        {
            directoryInfo = new DirectoryInfo(path);
        }
    }
}
