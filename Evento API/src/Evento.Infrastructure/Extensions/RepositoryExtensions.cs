using Evento.Core.Domain;
using Evento.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Infrastructure.Extensions
{
    public static class RepositoryExtensions
    {
        public static async Task<Event> GetOrFailAsync(this IEventRepository repository, Guid id)
        {
            var @event = await repository.GetAsync(id);
            if (@event == null)
            {
                throw new Exception($"Wydarzenie o id: '{id}' nie istnieje");
            }

            return @event;
        }

        public static async Task<Event> IsExistsAsync(this IEventRepository repository, string name)
        {
            var @event = await repository.GetAsync(name);
            if (@event != null)
            {
                throw new Exception($"Wydarzenie: '{name}' juz istnieje");
            }

            return @event;
        }

        public static async Task<User> GetOrFailAsync(this IUserRepository repository, Guid id)
        {
            var user = await repository.GetAsync(id);
            if (user == null)
            {
                throw new Exception($"Urzytkownik z id: '{id}' nie istnieje");
            }

            return user;
        }

    }
}
