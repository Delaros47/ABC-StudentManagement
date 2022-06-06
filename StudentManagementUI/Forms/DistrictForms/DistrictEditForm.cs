using Business.Abstract;
using Business.DependencyResolvers.AutoFac;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Entities.Concrete;
using StudentManagementUI.Commons.Functions;
using StudentManagementUI.Commons.Messages;
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
    public partial class DistrictEditForm : BaseEditForm
    {
        public static int CityId = -1;
        public static int DistrictId = -1;
        private readonly IDistrictService _districtService;
        public DistrictEditForm()
        {
            InitializeComponent();
            _districtService = InstanceFactory.GetInstance<IDistrictService>();
        }

        protected override void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        protected override void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = _districtService.Add(new District
            {
                PrivateCode = txtPrivateCode.Text,
                DistrictName = txtDistrictName.Text,
                Description = txtDescription.Text,
                State = tglState.IsOn,
                CityId = CityId
            });
            if (result.Success)
            {
                MyMessagesBox.AddedMessage(result.Message);
            }
        }

        protected override void btnClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            CleanAllComponants();
        }

        private void CleanAllComponants()
        {

            ClearAll.Clean(myDataLayoutControl1);
        }
    }
}