using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
using StudentManagementUI.Forms.BaseForms;
using StudentManagementUI.Forms.DistrictForms;
using StudentManagementUI.Forms.SchoolForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementUI.Forms.CityForms
{
    public partial class CityListForm : BaseListForm
    {
        public static int CityId = -1;
        private readonly ICityService _cityService;
        public CityListForm()
        {
            InitializeComponent();
            _cityService = InstanceFactory.GetInstance<ICityService>();
            btnConnectedCards.Caption = "Districts";
            btnConnectedCards.Visibility = BarItemVisibility.Always;
        }

        public void CityListForm_Load(object sender, EventArgs e)
        {
            GetAllCities();
            GetNavigator();

        }

        private void GetAllCities()
        {
            gridControlCities.DataSource = _cityService.GetAllActive().Data;
        }

        private void GetNavigator()
        {
            ControlNavigator Navigator = new ControlNavigator();
            Navigator.NavigatableControl = gridControlCities;
            Navigator = longNavigator.controlNavigator;

        }

        protected override void btnActivePassiveList_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (e.Item.Caption == "Passive List")
            {
                gridControlCities.DataSource = _cityService.GetAllPassive().Data;
                e.Item.Caption = "Active List";
            }
            else
            {
                gridControlCities.DataSource = _cityService.GetAllActive().Data;
                e.Item.Caption = "Passive List";
            }

        }

        protected override void btnConnectedCards_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Convert.ToInt32(gridViewCities.GetFocusedRowCellValue("Id").ToString()) > 0)
            {
                DistrictListForm.CityId = Convert.ToInt32(gridViewCities.GetFocusedRowCellValue("Id").ToString());
                CreateForms<DistrictListForm>.ShowDialogListForm();
            }

        }

        protected override void btnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            CityEditForm.Id = -1;
            CreateForms<CityEditForm>.ShowDialogEditForm();
        }

        private void gridViewCities_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewCities.FocusedRowHandle >= 0)
            {
                CityId = Convert.ToInt32(gridViewCities.GetFocusedRowCellValue("Id").ToString());
                CityEditForm.Id = CityId;
                if (SchoolEditForm.ControlForm)
                {
                    SchoolEditForm.CityId = CityId;
                    SchoolEditForm.ControlForm = false;
                    this.Close();
                }
                else
                {
                    CreateForms<CityEditForm>.ShowDialogEditForm();
                }

            }
            else
            {
                MyMessagesBox.GridRowWrongSelectedMessage();
            }

        }


    }
}