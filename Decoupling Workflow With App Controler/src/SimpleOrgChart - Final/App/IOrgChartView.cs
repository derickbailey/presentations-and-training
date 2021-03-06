using System.Collections.Generic;
using SimpleOrgChart___Final.Model;

namespace SimpleOrgChart___Final.App
{
	public interface IOrgChartView
	{
		void DisplayEmployeeHierarchy(IList<Employee> employees);
		OrgChartPresenter Presenter { get; set; }
	}
}