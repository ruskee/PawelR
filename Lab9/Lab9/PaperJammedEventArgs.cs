using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    class PaperJammedEventArgs : PrinterEventArgs
    {
        

        public PaperJammedEventArgs(int page): base(page)
        {
          
        }

    }
}
