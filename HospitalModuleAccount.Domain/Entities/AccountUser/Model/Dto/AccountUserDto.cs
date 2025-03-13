

namespace HospitalModuleAccount.Domain.Entities.AccountUser.Model.Dto
{
    public record AccountUserDto(string id, string FullName, string UserName, string Email, string PhoneNumber, int Age, string Address, IEnumerable<string> roles);

}
