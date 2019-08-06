using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public sealed class OrganizationViewModel : BaseViewModel<OrganizationModel>
    {
        private MemberViewModel _selectedMember;
        private ObservableCollection<MemberViewModel> _members;

        public OrganizationViewModel(OrganizationModel model) : base(model)
        {
            _members = new ObservableCollection<MemberViewModel>();

            foreach (Member member in model.Members)
            {
                var memberViewModel = new MemberViewModel(member);
                memberViewModel.PropertyChanged += MemberViewModel_PropertyChanged;
                _members.Add(memberViewModel);
            }
        }

        private void MemberViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //Model.UpdateMember(((MemberViewModel)sender).Model);
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
    }
}
