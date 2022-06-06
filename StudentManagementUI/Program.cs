using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.CityForms;
using StudentManagementUI.Forms.GeneralForms;
using StudentManagementUI.Forms.SchoolForms;

namespace StudentManagementUI
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}