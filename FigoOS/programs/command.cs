using System;
using System.Collections.Generic;
using System.Text;

namespace FigoOS.commands
{
    public class command
    {
        public readonly String name;

        public command(String name) { this.name = name; }

        public virtual String execute(String[] args) { return ""; }
    }
}