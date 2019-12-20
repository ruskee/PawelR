using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    class Printer
    {

        private Random _random;
        public event EventHandler<PaperJammedEventArgs> PaperJammed;
        public event EventHandler<OutOfInkEventArgs> OutOfInk;


        private double _blackInkLevel;
        private double _cyanInkLevel;
        private double _magentaInkLevel;
        private double _yellowInkLevel;

        public void OnPaperJammed(EventArgs args)
        {
            Console.WriteLine("Printer: Paper jammed");
        }
        public void Print(int pageNumber)

        {

            if (_random.NextDouble() < 0.01)
            {
                // OnPaperJammed(EventArgs.Empty);
                PaperJammed.Invoke(this, new PaperJammedEventArgs(pageNumber));
            }
            else

            {
                Console.WriteLine("Etykieta");
                _blackInkLevel -= _random.NextDouble() * (0.1 - 0.01) + 0.01;
                _cyanInkLevel -= _random.NextDouble() * (0.1);
                _magentaInkLevel -= _random.NextDouble() * (0.1);
                _yellowInkLevel -= _random.NextDouble() * (0.1);

                if (_blackInkLevel <= 0)
                {
                    OutOfInk.Invoke(this, new OutOfInkEventArgs("black", pageNumber));
                }
                if (_cyanInkLevel <= 0)
                {
                    OutOfInk.Invoke(this, new OutOfInkEventArgs("cyan", pageNumber));
                }
                if (_magentaInkLevel <= 0)
                {
                    OutOfInk.Invoke(this, new OutOfInkEventArgs("magenta", pageNumber));
                }
                if (_yellowInkLevel <= 0)
                {
                    OutOfInk.Invoke(this, new OutOfInkEventArgs("yellow", pageNumber));
                }
            }

        }


        private void InternalEventHandler(object sender, PaperJammedEventArgs args)
        {
            Console.WriteLine($"[Printer log] Jammed at " +
            $"page {args.Page} at " +
            $"{DateTime.Now.ToLongDateString()}");
        }

        private void OutOfInkInternalEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine($"[Printer log] {args.InkColor.ToUpper()} is empty at " +
                  $"page {args.Page} at " +
                  $"{DateTime.Now.ToLongDateString()}");
        }

        public Printer()
        {
            _random = new Random();
            _blackInkLevel = 1;
            _cyanInkLevel = 1;
            _magentaInkLevel = 1;
            _yellowInkLevel = 1;
            PaperJammed += InternalEventHandler;
            OutOfInk += OutOfInkInternalEventHandler;
        }
        private class Ink
        {
            public double Level { get; set; }

        }
    }
}
