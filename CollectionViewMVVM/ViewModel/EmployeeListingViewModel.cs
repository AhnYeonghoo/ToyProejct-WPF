﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using


using System.ComponentModel;
using System.Windows.Data;

namespace CollectionViewMVVM.VIewModels
{
    public class EmployeeListingViewModel : ViewModelBase
    {
        private readonly List<EmployeeViewModel> _employeeViewModels;
        public ICollectionView EmployeesCollectionView { get; }
        private string _employeesFilter = string.Empty;
        public string EmployeesFilter
        {
            get
            {
                return _employeesFilter;
            }
            set
            {
                _employeesFilter = value;
                OnPropertyChanged(nameof(EmployeesFilter));
                EmployeesCollectionView.Refresh();
            }
        }

        public EmployeeListingViewModel()
        {
            _employeeViewModels = new List<EmployeeViewModel>();
            foreach (EmployeeViewModel employeeViewModel in GetEmployeeViewModels())
            {
                _employeeViewModels.Add(employeeViewModel);
            }

            EmployeesCollectionView = CollectionViewSource.GetDefaultView(_employeeViewModels);

            EmployeesCollectionView.Filter = FilterEmployees;
            EmployeesCollectionView.GroupDescriptions.Add(new PropertyGroupDescription(nameof(EmployeeListingViewModel.JobTitle)));
            EmployeesCollectionView.ShortDescriptions.Add(new SortDescription(nameof(EmployeeListingViewModel.Name), ListSortDirection.Ascending));
        }

        private bool FilterEmployees(object obj)
        {
            if (obj is EmployeeViewModel employeeViewModel)
            {
                return employeeViewModel.Name.Contains(EmployeesFilter, StringComparison.InvariantCultureIgnoreCase) ||
                    employeeViewModel.JobTitle.Contains(EmployeesFilter, StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }

        private IEnumerable<EmployeeListingViewModel> GetEmployeeViewModels()
        {
            yield return new EmployeeViewModel("Sean", "Doctor");
            yield return new EmployeeViewModel("Joe", "Web Developer");
            yield return new EmployeeViewModel("Abby", "Web Developer");
            yield return new EmployeeViewModel("Frank", "Construction Worker");
            yield return new EmployeeViewModel("Kate", "Cashier");
            yield return new EmployeeViewMode("Adam", "Doctor");
            yield return new EmployeeViewMode("Mary", "Doctor");
            yield return new EmployeeViewModel("Tony", "Guitar Player");
        }
    }
}