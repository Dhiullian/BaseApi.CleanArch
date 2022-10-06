using CleanArch.BaseApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace CleanArch.BaseApi.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
