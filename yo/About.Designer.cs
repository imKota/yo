namespace About
{
  partial class TAboutForm
    {
        public System.Windows.Forms.Button Button1;
        public System.Windows.Forms.TabControl PageControl1;
        public System.Windows.Forms.TabPage TabSheet1;
        public System.Windows.Forms.Control Bevel1;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label lCopyleft;
        public System.Windows.Forms.Label lEmail;
        public System.Windows.Forms.Label lURL;
        public System.Windows.Forms.PictureBox Image1;
        public System.Windows.Forms.Panel Panel1;
        public System.Windows.Forms.Label lVersion;
        public System.Windows.Forms.Label lDictionary;
        public System.Windows.Forms.Label lRegExprDic;
        public System.Windows.Forms.TabPage TabSheet2;
        public System.Windows.Forms.TextBox Memo1;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAboutForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Button1 = new System.Windows.Forms.Button();
            this.PageControl1 = new System.Windows.Forms.TabControl();
            this.TabSheet1 = new System.Windows.Forms.TabPage();
            this.Bevel1 = new System.Windows.Forms.Control();
            this.Label1 = new System.Windows.Forms.Label();
            this.lCopyleft = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lURL = new System.Windows.Forms.Label();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lVersion = new System.Windows.Forms.Label();
            this.lDictionary = new System.Windows.Forms.Label();
            this.lRegExprDic = new System.Windows.Forms.Label();
            this.TabSheet2 = new System.Windows.Forms.TabPage();
            this.Memo1 = new System.Windows.Forms.TextBox();
            this.PageControl1.SuspendLayout();
            this.TabSheet1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.TabSheet2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button1.Location = new System.Drawing.Point(130, 279);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 24);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // PageControl1
            // 
            this.PageControl1.Controls.Add(this.TabSheet1);
            this.PageControl1.Controls.Add(this.TabSheet2);
            this.PageControl1.Location = new System.Drawing.Point(0, -1);
            this.PageControl1.Name = "PageControl1";
            this.PageControl1.SelectedIndex = 0;
            this.PageControl1.Size = new System.Drawing.Size(326, 258);
            this.PageControl1.TabIndex = 1;
            // 
            // TabSheet1
            // 
            this.TabSheet1.Controls.Add(this.Bevel1);
            this.TabSheet1.Controls.Add(this.Label1);
            this.TabSheet1.Controls.Add(this.lCopyleft);
            this.TabSheet1.Controls.Add(this.lEmail);
            this.TabSheet1.Controls.Add(this.lURL);
            this.TabSheet1.Controls.Add(this.Image1);
            this.TabSheet1.Controls.Add(this.Panel1);
            this.TabSheet1.Location = new System.Drawing.Point(4, 22);
            this.TabSheet1.Name = "TabSheet1";
            this.TabSheet1.Size = new System.Drawing.Size(318, 232);
            this.TabSheet1.TabIndex = 0;
            this.TabSheet1.Text = "О программе";
            // 
            // Bevel1
            // 
            this.Bevel1.Location = new System.Drawing.Point(138, 12);
            this.Bevel1.Name = "Bevel1";
            this.Bevel1.Size = new System.Drawing.Size(40, 40);
            this.Bevel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(49, 57);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(258, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Программа ёфикации русских текстов";
            // 
            // lCopyleft
            // 
            this.lCopyleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lCopyleft.Location = new System.Drawing.Point(148, 153);
            this.lCopyleft.Name = "lCopyleft";
            this.lCopyleft.Size = new System.Drawing.Size(137, 13);
            this.lCopyleft.TabIndex = 2;
            this.lCopyleft.Text = "© Владимир Иванов, 2003-";
            // 
            // lEmail
            // 
            this.lEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.lEmail.Location = new System.Drawing.Point(148, 177);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(137, 13);
            this.lEmail.TabIndex = 3;
            this.lEmail.Text = "E-mail: vgivanov@mail.ru";
            this.lEmail.DoubleClick += new System.EventHandler(this.lEmailDblClick);
            // 
            // lURL
            // 
            this.lURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
            this.lURL.Location = new System.Drawing.Point(148, 200);
            this.lURL.Name = "lURL";
            this.lURL.Size = new System.Drawing.Size(170, 13);
            this.lURL.TabIndex = 4;
            this.lURL.Text = "URL: http://vgiv.narod.ru/yo.html";
            this.lURL.DoubleClick += new System.EventHandler(this.lURLDblClick);
            // 
            // Image1
            // 
            this.Image1.Location = new System.Drawing.Point(142, 16);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(32, 32);
            this.Image1.TabIndex = 5;
            this.Image1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel1.Controls.Add(this.lVersion);
            this.Panel1.Controls.Add(this.lDictionary);
            this.Panel1.Controls.Add(this.lRegExprDic);
            this.Panel1.Location = new System.Drawing.Point(5, 78);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(308, 57);
            this.Panel1.TabIndex = 0;
            // 
            // lVersion
            // 
            this.lVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lVersion.Location = new System.Drawing.Point(8, 2);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(120, 13);
            this.lVersion.TabIndex = 0;
            this.lVersion.Text = "Версия программы: *.**";
            // 
            // lDictionary
            // 
            this.lDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lDictionary.Location = new System.Drawing.Point(8, 20);
            this.lDictionary.Name = "lDictionary";
            this.lDictionary.Size = new System.Drawing.Size(124, 13);
            this.lDictionary.TabIndex = 1;
            this.lDictionary.Text = "Основной словарь: **.***";
            // 
            // lRegExprDic
            // 
            this.lRegExprDic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lRegExprDic.Location = new System.Drawing.Point(8, 38);
            this.lRegExprDic.Name = "lRegExprDic";
            this.lRegExprDic.Size = new System.Drawing.Size(50, 13);
            this.lRegExprDic.TabIndex = 2;
            this.lRegExprDic.Text = "СРВ: **.***";
            // 
            // TabSheet2
            // 
            this.TabSheet2.Controls.Add(this.Memo1);
            this.TabSheet2.Enabled = false;
            this.TabSheet2.ImageIndex = 1;
            this.TabSheet2.Location = new System.Drawing.Point(4, 22);
            this.TabSheet2.Name = "TabSheet2";
            this.TabSheet2.Size = new System.Drawing.Size(318, 232);
            this.TabSheet2.TabIndex = 1;
            this.TabSheet2.Text = "Условия распространения";
            // 
            // Memo1
            // 
            this.Memo1.BackColor = System.Drawing.SystemColors.Info;
            this.Memo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Memo1.Location = new System.Drawing.Point(8, 8);
            this.Memo1.Multiline = true;
            this.Memo1.Name = "Memo1";
            this.Memo1.ReadOnly = true;
            this.Memo1.Size = new System.Drawing.Size(297, 177);
            this.Memo1.TabIndex = 0;
            this.Memo1.Text = resources.GetString("Memo1.Text");
            // 
            // TAboutForm
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(326, 316);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.PageControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(265, 295);
            this.Name = "TAboutForm";
            this.Text = "О программе";
            this.PageControl1.ResumeLayout(false);
            this.TabSheet1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.TabSheet2.ResumeLayout(false);
            this.TabSheet2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.ComponentModel.IContainer components;
    }
}
