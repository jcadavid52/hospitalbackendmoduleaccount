﻿using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto;
using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Entity;
using HospitalModuleAccount.Infrastructure.Port;

namespace HospitalModuleAccount.Infrastructure.Adapter.AccountUserAdapter
{
    public class AccountUserAdapterFactory : IAccountUserAdapterFactory
    {
        public IdentityAccountUserAdapter CreateMapIdentityUserAdapter(IdentityUserAdpaterDto identityUserAdapterDto)
        {
            return new IdentityAccountUserAdapter
            {
                Id = identityUserAdapterDto.Id,
                Age = identityUserAdapterDto.Age,
                Email = identityUserAdapterDto.Email,
                UserName = identityUserAdapterDto.UserName,
                Address = identityUserAdapterDto.Address,
                PhoneNumber = identityUserAdapterDto.PhoneNumber,
                FullName = identityUserAdapterDto.FullName,
                PasswordHash = identityUserAdapterDto.PasswordHash,
                NormalizedEmail = identityUserAdapterDto.NormalizedEmail,
                AccessFailedCount = identityUserAdapterDto.AccessFailedCount,
                LockoutEnabled = identityUserAdapterDto.LockoutEnabled,
                ConcurrencyStamp = identityUserAdapterDto.ConcurrencyStamp,
                EmailConfirmed = identityUserAdapterDto.EmailConfirmed,
                LockoutEnd = identityUserAdapterDto.LockoutEnd,
                NormalizedUserName = identityUserAdapterDto.NormalizedUserName,
                PhoneNumberConfirmed = identityUserAdapterDto.PhoneNumberConfirmed,
                SecurityStamp = identityUserAdapterDto.SecurityStamp,
                TwoFactorEnabled = identityUserAdapterDto.TwoFactorEnabled,

            };
        }

        public IdentityAccountUserAdapter CreateMapIdentityUserAdapter(AccountUserEntity user)
        {
            return new IdentityAccountUserAdapter
            {
                Age = user.Age,
                Email = user.Email,
                UserName = user.UserName,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                FullName = user.FullName,
            };
        }

        public IdentityUserAdpaterDto CreateMapIdentityUserDto(IdentityAccountUserAdapter identityUserAdapter)
        {
            return new IdentityUserAdpaterDto
               (
                 identityUserAdapter.Id,
                 identityUserAdapter.FullName,
                 identityUserAdapter.Age,
                 identityUserAdapter.Address,
                 identityUserAdapter.UserName,
                 identityUserAdapter.NormalizedUserName,
                 identityUserAdapter.Email,
                 identityUserAdapter.NormalizedEmail,
                 identityUserAdapter.EmailConfirmed,
                 identityUserAdapter.PasswordHash,
                 identityUserAdapter.SecurityStamp,
                 identityUserAdapter.ConcurrencyStamp,
                 identityUserAdapter.PhoneNumber,
                 identityUserAdapter.PhoneNumberConfirmed,
                 identityUserAdapter.TwoFactorEnabled,
                 identityUserAdapter.LockoutEnd,
                 identityUserAdapter.LockoutEnabled,
                 identityUserAdapter.AccessFailedCount
               );
        }
    }
}
