﻿using System.Security.Claims;

namespace ImproveU_backend.Services.Interfaces.IUsuarioServices;

public interface IUser
{
    string Name { get; }
    Guid GetUserId();
    string GetUserEmail();
    bool IsAuthenticated();
    bool IsInRole(string role);
    IEnumerable<Claim> GetClaimsIdentity();
}
