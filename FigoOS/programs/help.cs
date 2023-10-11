using FigoOS.commands;
using System;
using System.Collections.Generic;
using System.Text;
namespace FigoOS.Commands
{
    public class help : command
    {
        public help (String name) : base (name) { }

        public override string execute (string[] args)
        {
            return "OK";
        }
    }
}