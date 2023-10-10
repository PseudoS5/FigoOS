using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Sys = Cosmos.System;

namespace FigoOS
{
    public class Kernel : Sys.Kernel
    {
        public static VBECanvas canvas = new VBECanvas(new Mode(1920, 1080, ColorDepth.ColorDepth32));

        protected override void BeforeRun()
        {

        }

        protected override void Run()
        {
            canvas.DrawFilledRectangle(new Pen(Color.DarkGreen), 0, 0, 1920, 1080);
            canvas.Display();
        }
    }
}
