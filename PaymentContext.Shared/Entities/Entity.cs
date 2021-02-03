using System;

namespace PaymentContext.Shared.Entities
{
    abstract public class Entity
    {
        public Guid Id { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}