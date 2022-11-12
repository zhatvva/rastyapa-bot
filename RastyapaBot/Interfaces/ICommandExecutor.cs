using RastyapaBot.Models;

namespace RastyapaBot.Interfaces
{
    public interface ICommandExecutor
    {
        public string Command { get; }
        public string Execute(Notification notification);
    }
}
