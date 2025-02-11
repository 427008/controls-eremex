using CommunityToolkit.Mvvm.ComponentModel;
using DemoCenter.DemoData;
using System.Collections.Generic;

namespace DemoCenter.ViewModels
{
    public partial class DataGridValidationViewModel : PageViewModelBase
    {   
        [ObservableProperty]
        IList<EmployeeValidationInfo> employees;

        public DataGridValidationViewModel()
        {
            Employees = EmployeesData.GenerateValidationEmployeeInfo();
        }
    }
}
