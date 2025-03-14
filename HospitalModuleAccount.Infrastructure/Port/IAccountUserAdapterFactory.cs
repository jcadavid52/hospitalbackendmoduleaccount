
using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto;
using HospitalModuleAccount.Domain.Entities.AccountUser.Model.Entity;
using HospitalModuleAccount.Infrastructure.Adapter.AccountUserAdapter;

namespace HospitalModuleAccount.Infrastructure.Port
{
    public interface IAccountUserAdapterFactory
    {
        IdentityAccountUserAdapter CreateMapIdentityUserAdapter(IdentityUserAdpaterDto user);
        IdentityUserAdpaterDto CreateMapIdentityUserDto(IdentityAccountUserAdapter identityUserAdapter);
        IdentityAccountUserAdapter CreateMapIdentityUserAdapter(AccountUserEntity user);
    }
}
