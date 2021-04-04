using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedup.Interfaces
{
    public interface IFileHasher
    {
        string GetHash(string path);
    }
}
