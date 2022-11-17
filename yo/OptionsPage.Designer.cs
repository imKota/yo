namespace OptionsPage
{
  partial class TOptionsForm
    {
        public System.Windows.Forms.TabControl PageControl1;
        public System.Windows.Forms.TabPage TabSheet1;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.CheckBox cbCheckYo;
        public System.Windows.Forms.CheckBox cbNoVarOnly;
        public System.Windows.Forms.CheckBox cbVarOnly;
        public System.Windows.Forms.CheckBox cbAlwaysAsk;
        public System.Windows.Forms.CheckBox cbToConfirmAbbr;
        public System.Windows.Forms.CheckBox cbToConfirmCap;
        public System.Windows.Forms.CheckBox cbToConfirmEllipsis;
        public System.Windows.Forms.CheckBox cbProposeLast;
        public System.Windows.Forms.CheckBox cbRegExprs;
        public System.Windows.Forms.CheckBox cbFBFormat;
        public System.Windows.Forms.TextBox eLinesBelow;
        public System.Windows.Forms.CheckBox cbFastScroll;
        public System.Windows.Forms.TabPage TabSheet2;
        public System.Windows.Forms.CheckBox cbMark;
        public System.Windows.Forms.CheckBox cbWordWrap;
        public System.Windows.Forms.CheckBox cbLastFile;
        public System.Windows.Forms.Button bFont;
        public System.Windows.Forms.RichTextBox SampleEditor;
        public System.Windows.Forms.Button bMark;
        public System.Windows.Forms.Button bBackMark;
        public System.Windows.Forms.CheckBox cbAutoUnicode;
        public System.Windows.Forms.CheckBox cbShowToolbar;
        public System.Windows.Forms.CheckBox cbToConfirmClose;
        public System.Windows.Forms.Panel Panel1;
        public System.Windows.Forms.Button bOK;
        public System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.Button bOKSave;
        public System.Windows.Forms.FontDialog FontDialog1;
        public System.Windows.Forms.ColorDialog ColorDialog1;
        public System.Windows.Forms.MainMenu MainMenu1;
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PageControl1 = new System.Windows.Forms.TabControl();
            this.TabSheet1 = new System.Windows.Forms.TabPage();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbCheckYo = new System.Windows.Forms.CheckBox();
            this.cbNoVarOnly = new System.Windows.Forms.CheckBox();
            this.cbVarOnly = new System.Windows.Forms.CheckBox();
            this.cbAlwaysAsk = new System.Windows.Forms.CheckBox();
            this.cbToConfirmAbbr = new System.Windows.Forms.CheckBox();
            this.cbToConfirmCap = new System.Windows.Forms.CheckBox();
            this.cbToConfirmEllipsis = new System.Windows.Forms.CheckBox();
            this.cbProposeLast = new System.Windows.Forms.CheckBox();
            this.cbRegExprs = new System.Windows.Forms.CheckBox();
            this.cbFBFormat = new System.Windows.Forms.CheckBox();
            this.eLinesBelow = new System.Windows.Forms.TextBox();
            this.cbFastScroll = new System.Windows.Forms.CheckBox();
            this.TabSheet2 = new System.Windows.Forms.TabPage();
            this.cbMark = new System.Windows.Forms.CheckBox();
            this.cbWordWrap = new System.Windows.Forms.CheckBox();
            this.cbLastFile = new System.Windows.Forms.CheckBox();
            this.bFont = new System.Windows.Forms.Button();
            this.SampleEditor = new System.Windows.Forms.RichTextBox();
            this.bMark = new System.Windows.Forms.Button();
            this.bBackMark = new System.Windows.Forms.Button();
            this.cbAutoUnicode = new System.Windows.Forms.CheckBox();
            this.cbShowToolbar = new System.Windows.Forms.CheckBox();
            this.cbToConfirmClose = new System.Windows.Forms.CheckBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOKSave = new System.Windows.Forms.Button();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.PageControl1.SuspendLayout();
            this.TabSheet1.SuspendLayout();
            this.TabSheet2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageControl1
            // 
            this.PageControl1.Controls.Add(this.TabSheet1);
            this.PageControl1.Controls.Add(this.TabSheet2);
            this.PageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageControl1.Location = new System.Drawing.Point(0, 0);
            this.PageControl1.Name = "PageControl1";
            this.PageControl1.SelectedIndex = 0;
            this.PageControl1.Size = new System.Drawing.Size(371, 349);
            this.PageControl1.TabIndex = 0;
            // 
            // TabSheet1
            // 
            this.TabSheet1.Controls.Add(this.Label1);
            this.TabSheet1.Controls.Add(this.cbCheckYo);
            this.TabSheet1.Controls.Add(this.cbNoVarOnly);
            this.TabSheet1.Controls.Add(this.cbVarOnly);
            this.TabSheet1.Controls.Add(this.cbAlwaysAsk);
            this.TabSheet1.Controls.Add(this.cbToConfirmAbbr);
            this.TabSheet1.Controls.Add(this.cbToConfirmCap);
            this.TabSheet1.Controls.Add(this.cbToConfirmEllipsis);
            this.TabSheet1.Controls.Add(this.cbProposeLast);
            this.TabSheet1.Controls.Add(this.cbRegExprs);
            this.TabSheet1.Controls.Add(this.cbFBFormat);
            this.TabSheet1.Controls.Add(this.eLinesBelow);
            this.TabSheet1.Controls.Add(this.cbFastScroll);
            this.TabSheet1.Location = new System.Drawing.Point(4, 22);
            this.TabSheet1.Name = "TabSheet1";
            this.TabSheet1.Size = new System.Drawing.Size(363, 323);
            this.TabSheet1.TabIndex = 0;
            this.TabSheet1.Text = "Ёфикация";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 253);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(153, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Количество строк промотки:";
            // 
            // cbCheckYo
            // 
            this.cbCheckYo.Location = new System.Drawing.Point(8, 68);
            this.cbCheckYo.Name = "cbCheckYo";
            this.cbCheckYo.Size = new System.Drawing.Size(300, 21);
            this.cbCheckYo.TabIndex = 3;
            this.cbCheckYo.Text = "Проверять расстановку \"ё\"";
            // 
            // cbNoVarOnly
            // 
            this.cbNoVarOnly.Location = new System.Drawing.Point(8, 24);
            this.cbNoVarOnly.Name = "cbNoVarOnly";
            this.cbNoVarOnly.Size = new System.Drawing.Size(300, 17);
            this.cbNoVarOnly.TabIndex = 1;
            this.cbNoVarOnly.Text = "Только бесспорные замены";
            this.cbNoVarOnly.Click += new System.EventHandler(this.cbClick);
            // 
            // cbVarOnly
            // 
            this.cbVarOnly.Location = new System.Drawing.Point(8, 46);
            this.cbVarOnly.Name = "cbVarOnly";
            this.cbVarOnly.Size = new System.Drawing.Size(300, 17);
            this.cbVarOnly.TabIndex = 2;
            this.cbVarOnly.Text = "Только интерактивные замены";
            this.cbVarOnly.Click += new System.EventHandler(this.cbClick);
            // 
            // cbAlwaysAsk
            // 
            this.cbAlwaysAsk.Location = new System.Drawing.Point(8, 91);
            this.cbAlwaysAsk.Name = "cbAlwaysAsk";
            this.cbAlwaysAsk.Size = new System.Drawing.Size(300, 17);
            this.cbAlwaysAsk.TabIndex = 4;
            this.cbAlwaysAsk.Text = "Всегда подтверждать замену";
            this.cbAlwaysAsk.Click += new System.EventHandler(this.cbClick);
            // 
            // cbToConfirmAbbr
            // 
            this.cbToConfirmAbbr.Location = new System.Drawing.Point(8, 113);
            this.cbToConfirmAbbr.Name = "cbToConfirmAbbr";
            this.cbToConfirmAbbr.Size = new System.Drawing.Size(300, 17);
            this.cbToConfirmAbbr.TabIndex = 5;
            this.cbToConfirmAbbr.Text = "Всегда подверждать замену для сокращений";
            // 
            // cbToConfirmCap
            // 
            this.cbToConfirmCap.Location = new System.Drawing.Point(8, 135);
            this.cbToConfirmCap.Name = "cbToConfirmCap";
            this.cbToConfirmCap.Size = new System.Drawing.Size(300, 17);
            this.cbToConfirmCap.TabIndex = 6;
            this.cbToConfirmCap.Text = "Всегда подтверждать замену для имён собственных";
            // 
            // cbToConfirmEllipsis
            // 
            this.cbToConfirmEllipsis.Location = new System.Drawing.Point(8, 158);
            this.cbToConfirmEllipsis.Name = "cbToConfirmEllipsis";
            this.cbToConfirmEllipsis.Size = new System.Drawing.Size(300, 17);
            this.cbToConfirmEllipsis.TabIndex = 7;
            this.cbToConfirmEllipsis.Text = "Всегда подтверждать замену для оборванных слов";
            // 
            // cbProposeLast
            // 
            this.cbProposeLast.Location = new System.Drawing.Point(8, 180);
            this.cbProposeLast.Name = "cbProposeLast";
            this.cbProposeLast.Size = new System.Drawing.Size(300, 17);
            this.cbProposeLast.TabIndex = 8;
            this.cbProposeLast.Text = "Предлагать последний вариант замены";
            // 
            // cbRegExprs
            // 
            this.cbRegExprs.Location = new System.Drawing.Point(8, 2);
            this.cbRegExprs.Name = "cbRegExprs";
            this.cbRegExprs.Size = new System.Drawing.Size(300, 17);
            this.cbRegExprs.TabIndex = 0;
            this.cbRegExprs.Text = "Использование словаря регулярных выражений";
            // 
            // cbFBFormat
            // 
            this.cbFBFormat.Location = new System.Drawing.Point(8, 202);
            this.cbFBFormat.Name = "cbFBFormat";
            this.cbFBFormat.Size = new System.Drawing.Size(300, 17);
            this.cbFBFormat.TabIndex = 9;
            this.cbFBFormat.Text = "Учитывать формат \"FictionBook\"";
            // 
            // eLinesBelow
            // 
            this.eLinesBelow.Location = new System.Drawing.Point(164, 249);
            this.eLinesBelow.Name = "eLinesBelow";
            this.eLinesBelow.Size = new System.Drawing.Size(49, 20);
            this.eLinesBelow.TabIndex = 11;
            // 
            // cbFastScroll
            // 
            this.cbFastScroll.Location = new System.Drawing.Point(8, 225);
            this.cbFastScroll.Name = "cbFastScroll";
            this.cbFastScroll.Size = new System.Drawing.Size(300, 17);
            this.cbFastScroll.TabIndex = 10;
            this.cbFastScroll.Text = "Быстрая промотка";
            // 
            // TabSheet2
            // 
            this.TabSheet2.Controls.Add(this.cbMark);
            this.TabSheet2.Controls.Add(this.cbWordWrap);
            this.TabSheet2.Controls.Add(this.cbLastFile);
            this.TabSheet2.Controls.Add(this.bFont);
            this.TabSheet2.Controls.Add(this.SampleEditor);
            this.TabSheet2.Controls.Add(this.bMark);
            this.TabSheet2.Controls.Add(this.bBackMark);
            this.TabSheet2.Controls.Add(this.cbAutoUnicode);
            this.TabSheet2.Controls.Add(this.cbShowToolbar);
            this.TabSheet2.Controls.Add(this.cbToConfirmClose);
            this.TabSheet2.ImageIndex = 1;
            this.TabSheet2.Location = new System.Drawing.Point(4, 22);
            this.TabSheet2.Name = "TabSheet2";
            this.TabSheet2.Size = new System.Drawing.Size(363, 323);
            this.TabSheet2.TabIndex = 1;
            this.TabSheet2.Text = "Редактор";
            // 
            // cbMark
            // 
            this.cbMark.Location = new System.Drawing.Point(8, 100);
            this.cbMark.Name = "cbMark";
            this.cbMark.Size = new System.Drawing.Size(155, 17);
            this.cbMark.TabIndex = 4;
            this.cbMark.Text = "Помечать исправленное";
            this.cbMark.Click += new System.EventHandler(this.cbClick);
            // 
            // cbWordWrap
            // 
            this.cbWordWrap.Location = new System.Drawing.Point(8, 78);
            this.cbWordWrap.Name = "cbWordWrap";
            this.cbWordWrap.Size = new System.Drawing.Size(300, 17);
            this.cbWordWrap.TabIndex = 3;
            this.cbWordWrap.Text = "Заворачивать текст (\"Word wrap\")";
            this.cbWordWrap.Click += new System.EventHandler(this.cbClick);
            // 
            // cbLastFile
            // 
            this.cbLastFile.Location = new System.Drawing.Point(8, 12);
            this.cbLastFile.Name = "cbLastFile";
            this.cbLastFile.Size = new System.Drawing.Size(300, 17);
            this.cbLastFile.TabIndex = 0;
            this.cbLastFile.Text = "Запоминать последний файл";
            // 
            // bFont
            // 
            this.bFont.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bFont.Location = new System.Drawing.Point(160, 293);
            this.bFont.Name = "bFont";
            this.bFont.Size = new System.Drawing.Size(45, 21);
            this.bFont.TabIndex = 8;
            this.bFont.Text = "Шрифт";
            this.bFont.UseVisualStyleBackColor = false;
            this.bFont.Click += new System.EventHandler(this.bFontClick);
            // 
            // SampleEditor
            // 
            this.SampleEditor.Location = new System.Drawing.Point(16, 135);
            this.SampleEditor.Name = "SampleEditor";
            this.SampleEditor.ReadOnly = true;
            this.SampleEditor.Size = new System.Drawing.Size(321, 72);
            this.SampleEditor.TabIndex = 7;
            this.SampleEditor.TabStop = false;
            this.SampleEditor.Text = "True";
            // 
            // bMark
            // 
            this.bMark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bMark.Location = new System.Drawing.Point(169, 97);
            this.bMark.Name = "bMark";
            this.bMark.Size = new System.Drawing.Size(45, 21);
            this.bMark.TabIndex = 5;
            this.bMark.Text = "Цвет";
            this.bMark.UseVisualStyleBackColor = false;
            this.bMark.Click += new System.EventHandler(this.bMarkClick);
            // 
            // bBackMark
            // 
            this.bBackMark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bBackMark.Location = new System.Drawing.Point(221, 97);
            this.bBackMark.Name = "bBackMark";
            this.bBackMark.Size = new System.Drawing.Size(45, 21);
            this.bBackMark.TabIndex = 6;
            this.bBackMark.Text = "Фон";
            this.bBackMark.UseVisualStyleBackColor = false;
            this.bBackMark.Click += new System.EventHandler(this.bBackMarkClick);
            // 
            // cbAutoUnicode
            // 
            this.cbAutoUnicode.Location = new System.Drawing.Point(8, 56);
            this.cbAutoUnicode.Name = "cbAutoUnicode";
            this.cbAutoUnicode.Size = new System.Drawing.Size(300, 17);
            this.cbAutoUnicode.TabIndex = 2;
            this.cbAutoUnicode.Text = "Автораспознавать формат Unicode";
            // 
            // cbShowToolbar
            // 
            this.cbShowToolbar.Location = new System.Drawing.Point(8, 214);
            this.cbShowToolbar.Name = "cbShowToolbar";
            this.cbShowToolbar.Size = new System.Drawing.Size(300, 17);
            this.cbShowToolbar.TabIndex = 9;
            this.cbShowToolbar.Text = "Показывать панель инструментов";
            // 
            // cbToConfirmClose
            // 
            this.cbToConfirmClose.Location = new System.Drawing.Point(8, 35);
            this.cbToConfirmClose.Name = "cbToConfirmClose";
            this.cbToConfirmClose.Size = new System.Drawing.Size(226, 17);
            this.cbToConfirmClose.TabIndex = 1;
            this.cbToConfirmClose.Text = "Не подтверждать закрытие программы";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Panel1.Controls.Add(this.bOK);
            this.Panel1.Controls.Add(this.bCancel);
            this.Panel1.Controls.Add(this.bOKSave);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 349);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(371, 49);
            this.Panel1.TabIndex = 1;
            // 
            // bOK
            // 
            this.bOK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bOK.Location = new System.Drawing.Point(15, 10);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 25);
            this.bOK.TabIndex = 0;
            this.bOK.Text = "Применить";
            this.bOK.UseVisualStyleBackColor = false;
            this.bOK.Click += new System.EventHandler(this.bOKClick);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancel.Location = new System.Drawing.Point(281, 10);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 25);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancelClick);
            // 
            // bOKSave
            // 
            this.bOKSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bOKSave.Location = new System.Drawing.Point(120, 10);
            this.bOKSave.Name = "bOKSave";
            this.bOKSave.Size = new System.Drawing.Size(150, 25);
            this.bOKSave.TabIndex = 2;
            this.bOKSave.Text = "Применить и запомнить";
            this.bOKSave.UseVisualStyleBackColor = false;
            this.bOKSave.Click += new System.EventHandler(this.bOKSaveClick);
            // 
            // FontDialog1
            // 
            this.FontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            // 
            // TOptionsForm
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(371, 398);
            this.Controls.Add(this.PageControl1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(607, 180);
            this.Menu = this.MainMenu1;
            this.Name = "TOptionsForm";
            this.Text = "Опции";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPress);
            this.PageControl1.ResumeLayout(false);
            this.TabSheet1.ResumeLayout(false);
            this.TabSheet1.PerformLayout();
            this.TabSheet2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.ComponentModel.IContainer components;
    }
}
