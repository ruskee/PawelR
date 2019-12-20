using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    public class OutOfInkEventArgs : PrinterEventArgs
    {

        public OutOfInkEventArgs(string inkColor, int page) : base(page)
        {
            this.InkColor = inkColor;
            
        }

        public string InkColor { get; set; }
      
    }
}