﻿using System.Windows.Forms;
using SimpleOrgChart_Start.App;

namespace SimpleOrgChart_Start.View
{
	public partial class ViewEmployeeDetailControl : UserControl, IEmployeeDetailView
	{
		public ViewEmployeeDetailControl()
		{
			InitializeComponent();
		}

		public void DisplayEmployeeName(string firstName, string lastName)
		{
			EmployeeName.Text = string.Format("{1}, {0}", firstName, lastName);
		}

		public void DisplayEmployeeEmail(string email)
		{
			Email.Text = email;
		}
	}
}