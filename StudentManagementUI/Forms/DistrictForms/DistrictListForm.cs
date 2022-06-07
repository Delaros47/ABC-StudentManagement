using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Commons.Functions;
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
        public static int CityId = -1;
        private readonly IDistrictService _districtService;
        private readonly ICityService _cityService;
        public DistrictListForm()
        {
            InitializeComponent();
            _districtService = InstanceFactory.GetInstance<IDistrictService>();
            _cityService = InstanceFactory.GetInstance<ICityService>();
        }

        private void DistrictListForm_Load(object sender, EventArgs e)
        {
            GetAllDistrictsByCityId();
        }

        private void GetAllDistrictsByCityId()
        {
            if (CityId!=-1)
            {
                gridControlDistricts.DataSource = _districtService.GetAllDistrictsByCityId(CityId).Data;
                this.Text ="District List - "+ _cityService.Get(CityId).Data.CityName;
            }
        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DistrictEditForm.CityId = CityId;
            CreateForms<DistrictEditForm>.ShowDialogEditForm();
        }

        private void GetAllActiveDistricts()
        {
            gridControlDistricts.DataSource = _districtService.GetAllActive().Data;
        }

        private void GetAllPassiveDistricts()
        {
            gridControlDistricts.DataSource = _districtService.GetAllPassive().Data;
        }

        private void gridViewDistricts_DoubleClick(object sender, EventArgs e)
        {
            DistrictEditForm.DistrictId = Convert.ToInt32(gridViewDistricts.GetFocusedRowCellValue("Id").ToString());
            CreateForms<DistrictEditForm>.ShowDialogEditForm();
        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Caption=="Passive List")
            {
                gridControlDistricts.DataSource = _districtService.GetAllPassive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                e.Item.Caption = "Passive List";
                gridControlDistricts.DataSource = _districtService.GetAllActive().Data;

            }
        }
    }
}