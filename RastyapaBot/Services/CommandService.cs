using RastyapaBot.Interfaces;
using RastyapaBot.Models;
using System.Collections.Concurrent;

namespace RastyapaBot.Services
{
    public class CommandService
    {
        private readonly ConcurrentDictionary<string, ICommandExecutor> _executors;

        public CommandService(IEnumerable<ICommandExecutor> executors)
        {
            _executors = new();
            foreach (var executor in executors)
            {
                _executors.TryAdd(executor.Command, executor);
            }
        }

        public string Execute(Notification notification)
        {
            if (_executors.TryGetValue(notification.Type, out var executor))
            {
                var result = executor.Execute(notification);
                return result;
            }

            return "ok";
        }
    }
}
