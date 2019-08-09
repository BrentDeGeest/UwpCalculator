using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public sealed class OrganizationModel
    {
        public string Name { get; set; }
        public List<Member> Members { get; set; } = new List<Member>();

        public OrganizationModel(string name)
        {
            Name = name;
        }

        //public void AddMember(Member member)
        //{
        //    if (!Members.Any(m => m.MemberIdentification == member.MemberIdentification))
        //    {
        //        Members.Add(member);

        //        //MemberService.Add(member);
        //    }
        //}

        ////public void UpdateMember(Member member) => MemberService.Update(member);

        //public void RemoveMember(Member member)
        //{
        //    Member memberToRemove = Members.FirstOrDefault(m => m.MemberIdentification == member.MemberIdentification);

        //    if (memberToRemove != null)
        //    {
        //        Members.Remove(memberToRemove);
        //    }
        //}

    }
}
