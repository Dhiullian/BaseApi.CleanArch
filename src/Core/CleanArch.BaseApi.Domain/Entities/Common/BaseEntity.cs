using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.BaseApi.Domain.Entities.Common
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
