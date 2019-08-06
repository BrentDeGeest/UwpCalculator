using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public sealed class MemberViewModel : BaseViewModel<Member>
    {
        public MemberViewModel(Member model) : base(model) { }

        public string MemberIdentification
        {
            get => Model.MemberIdentification;
            set => SetProperty(Model.MemberIdentification, value, () => Model.MemberIdentification = value);
        }
        public string FirstName
        {
            get => Model.FirstName;
                set=> SetProperty(Model.FirstName , value, () => Model.FirstName = value);
        }
    public string LastName
    {
            get => Model.LastName;
            set=> SetProperty(Model.LastName , value, () => Model.LastName = value);
    }
    public DateTimeOffset BirthDate
    {
            get => Model.BirthDate;
            set=> SetProperty(Model.BirthDate , value, () => Model.BirthDate = value);
    }
}
}
