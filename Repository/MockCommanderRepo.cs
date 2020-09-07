using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Boil a Steak", Line="Boil Water", Platform="Kettle & Pan"},
                new Command{Id=2, HowTo="Boil a Pot", Line="Boil Water", Platform="Kettle & Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil Water", Platform="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}