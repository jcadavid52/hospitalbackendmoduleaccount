﻿

namespace HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto
{
    public record IdentityUserAdpaterDto(
      string Id,
      string FullName,
      int Age,
      string Address,
      string UserName,
      string NormalizedUserName,
      string Email,
      string NormalizedEmail,
      bool EmailConfirmed,
      string PasswordHash,
      string SecurityStamp,
      string ConcurrencyStamp,
      string PhoneNumber,
      bool PhoneNumberConfirmed,
      bool TwoFactorEnabled,
      DateTimeOffset? LockoutEnd,
      bool LockoutEnabled,
      int AccessFailedCount);
}
