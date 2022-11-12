using RastyapaBot.Interfaces;
using RastyapaBot.Models;

namespace RastyapaBot.Services
{
    public class ConfirmationCommandExecutor : ICommandExecutor
    {
        public string Command => "confirmation";

        public string Execute(Notification _) => Environment.GetEnvironmentVariable("CONFIRMATION") 
            ?? throw new Exception("\"CONFIRMATION\" env var not found");
    }
}
