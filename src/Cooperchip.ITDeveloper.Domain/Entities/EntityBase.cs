using System;

namespace Cooperchip.ITDeveloper.Domain.Enums
{
    public class EntityBase
    {
        public EntityBase()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
