namespace StudentManagementUI.UserControls.Navigators
{
    partial class SmallNavigator
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallNavigator));
            this.controlNavigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator
            // 
            this.controlNavigator.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.controlNavigator.Appearance.Options.UseForeColor = true;
            this.controlNavigator.Buttons.Append.Visible = false;
            this.controlNavigator.Buttons.CancelEdit.Visible = false;
            this.controlNavigator.Buttons.Edit.Visible = false;
            this.controlNavigator.Buttons.EndEdit.Visible = false;
            this.controlNavigator.Buttons.First.ImageIndex = 0;
            this.controlNavigator.Buttons.ImageList = this.imageCollection;
            this.controlNavigator.Buttons.Last.ImageIndex = 3;
            this.controlNavigator.Buttons.Next.ImageIndex = 2;
            this.controlNavigator.Buttons.NextPage.Visible = false;
            this.controlNavigator.Buttons.Prev.ImageIndex = 1;
            this.controlNavigator.Buttons.PrevPage.Visible = false;
            this.controlNavigator.Buttons.Remove.Visible = false;
            this.controlNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator.Name = "controlNavigator";
            this.controlNavigator.Size = new System.Drawing.Size(600, 24);
            this.controlNavigator.TabIndex = 0;
            this.controlNavigator.Text = "controlNavigator1";
            this.controlNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Begin;
            this.controlNavigator.TextStringFormat = "Record ({0} / {1})";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "first_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "prev_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "next_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "last_16x16.png");
            // 
            // SmallNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator);
            this.Name = "SmallNavigator";
            this.Size = new System.Drawing.Size(600, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ImageCollection imageCollection;
        public DevExpress.XtraEditors.ControlNavigator controlNavigator;
    }
}
