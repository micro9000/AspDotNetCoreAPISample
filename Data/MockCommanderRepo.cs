using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                 new Command{
                    Id = 1,
                    HowTo = "Boild an egg",
                    Line = "Boil water",
                    Platform = "Kettle & Pan"
                },
                 new Command{
                    Id = 2,
                    HowTo = "Test 1",
                    Line = "Boil water",
                    Platform = "Kettle & Pan"
                },
                 new Command{
                    Id = 3,
                    HowTo = "Test 3",
                    Line = "Boil water",
                    Platform = "Kettle & Pan"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                Id = 1,
                HowTo = "Boild an egg",
                Line = "Boil water",
                Platform = "Kettle & Pan"
            };
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