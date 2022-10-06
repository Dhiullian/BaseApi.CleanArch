using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.BaseApi.Application.Interfaces
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }
    }
}
