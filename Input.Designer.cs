namespace Input
{
  partial class TInputForm
    {
        public System.Windows.Forms.Label lInput;
        public System.Windows.Forms.TextBox eInput;
        public System.Windows.Forms.Button bOK;
        public System.Windows.Forms.Button bCancel;
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
            this.lInput = new System.Windows.Forms.Label();
            this.eInput = new System.Windows.Forms.TextBox();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.Location  = new System.Drawing.Point(337, 266);
            this.ClientSize  = new System.Drawing.Size(213, 92);
            this.Font  = new System.Drawing.Font("MS Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point ,((byte)(1)));
            this.AutoScroll = true;
            this.Name = "InputForm";
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lInput.Size  = new System.Drawing.Size(77, 13);
            this.lInput.Location  = new System.Drawing.Point(18, 8);
            this.lInput.Text = "¬ведите число:";
            this.lInput.Enabled = true;
            this.lInput.Name = "lInput";
            this.eInput.Size  = new System.Drawing.Size(74, 21);
            this.eInput.Location  = new System.Drawing.Point(101, 5);
            this.eInput.TabIndex = 0;
            this.eInput.Text = "00000000000";
            this.eInput.Enabled = true;
            this.eInput.Name = "eInput";
            this.bOK.Size  = new System.Drawing.Size(75, 25);
            this.bOK.Location  = new System.Drawing.Point(4, 32);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "OK";
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Name = "bOK";
            this.bOK.Enabled = true;
            this.bOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancel.Size  = new System.Drawing.Size(75, 25);
            this.bCancel.Location  = new System.Drawing.Point(121, 32);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Name = "bCancel";
            this.bCancel.Enabled = true;
            this.bCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(lInput);
            this.Controls.Add(eInput);
            this.Controls.Add(bOK);
            this.Controls.Add(bCancel);
            this.ResumeLayout(false);
        }
#endregion

    }
}
