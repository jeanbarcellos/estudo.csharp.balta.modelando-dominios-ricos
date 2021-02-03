using System;
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
    abstract public class Entity : Notifiable
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}