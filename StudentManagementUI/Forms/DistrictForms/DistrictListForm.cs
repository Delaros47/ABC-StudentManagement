using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraEditors;
using StudentManagementUI.Forms.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.DistrictForms
{
    public partial class DistrictListForm : BaseListForm
    {
        private readonly IDistrictService _districtService;
        public DistrictListForm()
        {
            InitializeComponent();
            _districtService = InstanceFactory.GetInstance<IDistrictService>();
        }

        private void DistrictListForm_Load(object sender, EventArgs e)
        {
            GetAllActiveDistricts();
        }

        private void GetAllActiveDistricts()
        {
            gridControlDistricts.DataSource = _districtService.GetAllActive().Data;
        }

        private void GetAllPassiveDistricts()
        {
            gridControlDistricts.DataSource = _districtService.GetAllPassive().Data;
        }

    }
}