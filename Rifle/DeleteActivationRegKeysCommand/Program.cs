
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rifle;

namespace DeleteActivationRegKeysCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            Activator av = new Activator();
            av.DeleteRegKeys();
        }
    }
}
