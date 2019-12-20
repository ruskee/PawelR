using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
  public abstract class PrinterEventArgs : EventArgs
    {
        public int Page { get; private set; }
        public PrinterEventArgs(int page)
        {
            Page = page;
        }

    }
}
