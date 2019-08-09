using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModelView
{
    public sealed class OrganizationViewModel : BaseViewModel<OrganizationModel>
    {
        private MemberViewModel _selectedMember;
        private ObservableCollection<MemberViewModel> _members;
        public readonly ICommand AddMemberCommand;
        public readonly ICommand RemoveMemberCommand;
        public OrganizationViewModel(OrganizationModel model) : base(model)
        {
            _members = new ObservableCollection<MemberViewModel>();

            foreach (Member member in model.Members)
            {
                var memberViewModel = new MemberViewModel(member);
                _members.Add(memberViewModel);
            }

            AddMemberCommand = new RelayCommand(() => AddMember());
            RemoveMemberCommand = new RelayCommand(() => RemoveMember());
        }


        public string OrganizationName
        {
            get => Model.Name;
            set => SetProperty(Model.Name, value, () => Model.Name = value);
        }
        public MemberViewModel SelectedMember
        {
            get => _selectedMember;
            set => SetProperty(ref _selectedMember, value);
        }
        public ObservableCollection<MemberViewModel> Members
        {
            get => _members;
            set => SetProperty(ref _members, value);
        }

        private void AddMember()
        {
            Members.Add(new MemberViewModel(new Member
            {
                FirstName = "testFirst",
                LastName = "testLast",
                BirthDate = new DateTimeOffset(new DateTime(1999, 1, 1)),
                MemberIdentification = "id"
            }));
        }

        private void RemoveMember()
        {
            Members.Remove(SelectedMember);
        }
    }
}
