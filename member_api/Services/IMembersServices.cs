using LibraryReact.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryReact.Services
{
    public interface IMembersServices
    {
        Task<IEnumerable<Member>> GetMembers();
        Task<Member> GetMemberById(string memberObj);
        Task<Member> UpdateMember(Member memberObj);
        Task<Member> CreateMember(Member memberObj);
        Task<Member> DeleteMember(string memberObj);

    }
}