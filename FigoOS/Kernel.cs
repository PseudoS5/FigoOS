using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Sys = Cosmos.System;
using System.Reflection.Metadata;
using FigoOS.Commands;
using FigoOS.commands;

namespace FigoOS
{
    public class Kernel : Sys.Kernel
    {
        private commandManager commandManager;
        protected override void BeforeRun()
        {
            Console.WriteLine("SYS LOADED!");
            this.commandManager = new commandManager();
        }


        protected override void Run()
        {
            String response;
            Console.Write("> ");
            String input = Console.ReadLine();
            response = this.commandManager.processInput(input);
            Console.WriteLine(response);
        }
    }
}
