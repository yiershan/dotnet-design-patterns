using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Invoker
    {
        private IList<Command> _commands = new List<Command>();

        public Invoker AddCommand(Command command) {
            _commands.Add(command);
            return this;
        }

        public void Excute(Receiver receiver) {
            foreach (var command in _commands) {
                command.Excute(receiver);
            }
        }
    }
}
