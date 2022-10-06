using CleanArch.BaseApi.Domain.Entities.Common;
using System;

namespace CleanArch.BaseApi.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
