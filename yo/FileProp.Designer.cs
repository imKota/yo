namespace FileProp
{
  partial class TFilePropForm
    {
        public System.Windows.Forms.DataGrid sgProp;
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.ToolTip toolTip1 = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

#region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(this.GetType());
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sgProp = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            this.Location  = new System.Drawing.Point(287, 189);
            this.ClientSize  = new System.Drawing.Size(545, 172);
            this.Font  = new System.Drawing.Font("MS Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((byte)(1)));
            this.AutoScroll = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilePropForm";
            this.Text = "Ñגמיסעגא פאיכא";
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            ((System.ComponentModel.ISupportInitialize)(this.sgProp)).BeginInit();
            this.sgProp.Size  = new System.Drawing.Size(545, 172);
            this.sgProp.Location  = new System.Drawing.Point(0, 0);
            this.sgProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgProp.TabIndex = 0;
            this.sgProp.Name = "sgProp";
            this.sgProp.Enabled = true;
            this.sgProp.PreferredColumnWidth = (int)150;//264
            this.Controls.Add(sgProp);
            ((System.ComponentModel.ISupportInitialize)(this.sgProp)).EndInit();
            this.ResumeLayout(false);
        }
#endregion

    }
}
