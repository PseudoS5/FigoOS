using FigoOS.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigoOS.commands
{
    public class commandManager
    {

        private List<command> commands;

        public commandManager()
        {
            this.commands = new List<command>(1);
            this.commands.Add(new help("help"));
        }

        public String processInput (String input)
        {
            String[] split = input.Split(' ');

            String label = split[0];

            List<String> args = new List<String>();

            int ctr = 0;
            foreach (String s in split)
            {
                if (ctr == 0)
                    args.Add(s);
                ctr++;

            }
            foreach (command pgm in this.commands)
            {
                if (pgm.name == label)
                    return pgm.execute(args.ToArray());
            }

            return "ERROR";
        }
    }
}