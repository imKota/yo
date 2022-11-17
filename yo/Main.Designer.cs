using System.Windows.Forms;

namespace Main
{
  partial class TMainForm
    {
        public System.Windows.Forms.StatusBar StatusBar1;
        public System.Windows.Forms.StatusBarPanel _panel_2;
        public System.Windows.Forms.StatusBarPanel _panel_3;
        public System.Windows.Forms.Panel AskPanel;
        public System.Windows.Forms.GroupBox AskColorRect;
        public System.Windows.Forms.Control AskBevel;
        public System.Windows.Forms.Label lSample;
        public System.Windows.Forms.Label lCaption;
        public System.Windows.Forms.GroupBox AskRightRect;
        public System.Windows.Forms.GroupBox AskLeftRect;
        public System.Windows.Forms.Button bYe;
        public System.Windows.Forms.Button bYeAll;
        public System.Windows.Forms.Button bYo;
        public System.Windows.Forms.Button bUndo;
        public System.Windows.Forms.Button bYoAll;
        public System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.ToolBar ToolBar1;
        public System.Windows.Forms.MainMenu MainMenu1;
        public System.Windows.Forms.MenuItem File1;
        public System.Windows.Forms.MenuItem Open1;
        public System.Windows.Forms.MenuItem Save1;
        public System.Windows.Forms.MenuItem Saveas1;
        public System.Windows.Forms.MenuItem Close1;
        public System.Windows.Forms.MenuItem OpenDic1;
        public System.Windows.Forms.MenuItem OpenRegExprDic1;
        public System.Windows.Forms.MenuItem Clearfilelist1;
        public System.Windows.Forms.MenuItem Fileprop1;
        public System.Windows.Forms.MenuItem Exit1;
        public System.Windows.Forms.MenuItem Openfile0;
        public System.Windows.Forms.MenuItem Edit1;
        public System.Windows.Forms.MenuItem Cut1;
        public System.Windows.Forms.MenuItem Copy1;
        public System.Windows.Forms.MenuItem Paste1;
        public System.Windows.Forms.MenuItem Selectall1;
        public System.Windows.Forms.MenuItem N3;
        public System.Windows.Forms.MenuItem Undo1;
        public System.Windows.Forms.MenuItem N2;
        public System.Windows.Forms.MenuItem Find1;
        public System.Windows.Forms.MenuItem Findreg1;
        public System.Windows.Forms.MenuItem Findagain1;
        public System.Windows.Forms.MenuItem Findyyfwd1;
        public System.Windows.Forms.MenuItem Findyyback1;
        public System.Windows.Forms.MenuItem Yo1;
        public System.Windows.Forms.MenuItem Yopos1;
        public System.Windows.Forms.MenuItem Yobegin1;
        public System.Windows.Forms.MenuItem RemoveMarked1;
        public System.Windows.Forms.MenuItem Clearusersel1;
        public System.Windows.Forms.MenuItem Setting1;
        public System.Windows.Forms.MenuItem Options1;
        public System.Windows.Forms.MenuItem Help1;
        public System.Windows.Forms.MenuItem About1;
        public System.Windows.Forms.MenuItem Moreabout1;
        public System.Windows.Forms.CommonDialog FindDialog1;
        public System.Windows.Forms.OpenFileDialog odDic;
        public System.Windows.Forms.ContextMenu PopupMenu1;
        public System.Windows.Forms.MenuItem Cut2;
        public System.Windows.Forms.MenuItem Copy2;
        public System.Windows.Forms.MenuItem Paste2;
        public System.Object ActionList1;
        public System.Object EditPaste1;
        public System.Object WindowCascade1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMainForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this._panel_2 = new System.Windows.Forms.StatusBarPanel();
            this._panel_3 = new System.Windows.Forms.StatusBarPanel();
            this.AskPanel = new System.Windows.Forms.Panel();
            this.AskColorRect = new System.Windows.Forms.GroupBox();
            this.AskBevel = new System.Windows.Forms.Control();
            this.lSample = new System.Windows.Forms.Label();
            this.lCaption = new System.Windows.Forms.Label();
            this.AskRightRect = new System.Windows.Forms.GroupBox();
            this.AskLeftRect = new System.Windows.Forms.GroupBox();
            this.bYe = new System.Windows.Forms.Button();
            this.bYeAll = new System.Windows.Forms.Button();
            this.bYo = new System.Windows.Forms.Button();
            this.bUndo = new System.Windows.Forms.Button();
            this.bYoAll = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.ToolBar1 = new System.Windows.Forms.ToolBar();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.File1 = new System.Windows.Forms.MenuItem();
            this.Open1 = new System.Windows.Forms.MenuItem();
            this.Save1 = new System.Windows.Forms.MenuItem();
            this.Saveas1 = new System.Windows.Forms.MenuItem();
            this.Close1 = new System.Windows.Forms.MenuItem();
            this.OpenDic1 = new System.Windows.Forms.MenuItem();
            this.OpenRegExprDic1 = new System.Windows.Forms.MenuItem();
            this.Clearfilelist1 = new System.Windows.Forms.MenuItem();
            this.Fileprop1 = new System.Windows.Forms.MenuItem();
            this.Exit1 = new System.Windows.Forms.MenuItem();
            this.Openfile0 = new System.Windows.Forms.MenuItem();
            this.Edit1 = new System.Windows.Forms.MenuItem();
            this.Cut1 = new System.Windows.Forms.MenuItem();
            this.Copy1 = new System.Windows.Forms.MenuItem();
            this.Paste1 = new System.Windows.Forms.MenuItem();
            this.Selectall1 = new System.Windows.Forms.MenuItem();
            this.N3 = new System.Windows.Forms.MenuItem();
            this.Undo1 = new System.Windows.Forms.MenuItem();
            this.N2 = new System.Windows.Forms.MenuItem();
            this.Find1 = new System.Windows.Forms.MenuItem();
            this.Findreg1 = new System.Windows.Forms.MenuItem();
            this.Findagain1 = new System.Windows.Forms.MenuItem();
            this.Findyyfwd1 = new System.Windows.Forms.MenuItem();
            this.Findyyback1 = new System.Windows.Forms.MenuItem();
            this.Yo1 = new System.Windows.Forms.MenuItem();
            this.Yopos1 = new System.Windows.Forms.MenuItem();
            this.Yobegin1 = new System.Windows.Forms.MenuItem();
            this.RemoveMarked1 = new System.Windows.Forms.MenuItem();
            this.Clearusersel1 = new System.Windows.Forms.MenuItem();
            this.Setting1 = new System.Windows.Forms.MenuItem();
            this.Options1 = new System.Windows.Forms.MenuItem();
            this.Help1 = new System.Windows.Forms.MenuItem();
            this.About1 = new System.Windows.Forms.MenuItem();
            this.Moreabout1 = new System.Windows.Forms.MenuItem();
            this.odDic = new System.Windows.Forms.OpenFileDialog();
            this.PopupMenu1 = new System.Windows.Forms.ContextMenu();
            this.Cut2 = new System.Windows.Forms.MenuItem();
            this.Copy2 = new System.Windows.Forms.MenuItem();
            this.Paste2 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._panel_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._panel_3)).BeginInit();
            this.AskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar1
            // 
            this.StatusBar1.Location = new System.Drawing.Point(0, 336);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this._panel_2,
            this._panel_3});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(571, 19);
            this.StatusBar1.TabIndex = 0;
            // 
            // _panel_2
            // 
            this._panel_2.Name = "_panel_2";
            // 
            // _panel_3
            // 
            this._panel_3.Name = "_panel_3";
            // 
            // AskPanel
            // 
            this.AskPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AskPanel.Controls.Add(this.AskColorRect);
            this.AskPanel.Controls.Add(this.AskBevel);
            this.AskPanel.Controls.Add(this.lSample);
            this.AskPanel.Controls.Add(this.lCaption);
            this.AskPanel.Controls.Add(this.AskRightRect);
            this.AskPanel.Controls.Add(this.AskLeftRect);
            this.AskPanel.Controls.Add(this.bYe);
            this.AskPanel.Controls.Add(this.bYeAll);
            this.AskPanel.Controls.Add(this.bYo);
            this.AskPanel.Controls.Add(this.bUndo);
            this.AskPanel.Controls.Add(this.bYoAll);
            this.AskPanel.Controls.Add(this.bCancel);
            this.AskPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AskPanel.Location = new System.Drawing.Point(0, 355);
            this.AskPanel.Name = "AskPanel";
            this.AskPanel.Size = new System.Drawing.Size(571, 119);
            this.AskPanel.TabIndex = 1;
            // 
            // AskColorRect
            // 
            this.AskColorRect.Location = new System.Drawing.Point(0, 0);
            this.AskColorRect.Name = "AskColorRect";
            this.AskColorRect.Size = new System.Drawing.Size(561, 119);
            this.AskColorRect.TabIndex = 0;
            this.AskColorRect.TabStop = false;
            // 
            // AskBevel
            // 
            this.AskBevel.Location = new System.Drawing.Point(101, 1);
            this.AskBevel.Name = "AskBevel";
            this.AskBevel.Size = new System.Drawing.Size(360, 119);
            this.AskBevel.TabIndex = 1;
            // 
            // lSample
            // 
            this.lSample.Location = new System.Drawing.Point(107, 27);
            this.lSample.Name = "lSample";
            this.lSample.Size = new System.Drawing.Size(3, 13);
            this.lSample.TabIndex = 2;
            this.lSample.Visible = false;
            // 
            // lCaption
            // 
            this.lCaption.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lCaption.Location = new System.Drawing.Point(280, 27);
            this.lCaption.Name = "lCaption";
            this.lCaption.Size = new System.Drawing.Size(19, 16);
            this.lCaption.TabIndex = 3;
            this.lCaption.Text = "***";
            // 
            // AskRightRect
            // 
            this.AskRightRect.Location = new System.Drawing.Point(462, 0);
            this.AskRightRect.Name = "AskRightRect";
            this.AskRightRect.Size = new System.Drawing.Size(104, 119);
            this.AskRightRect.TabIndex = 4;
            this.AskRightRect.TabStop = false;
            // 
            // AskLeftRect
            // 
            this.AskLeftRect.Location = new System.Drawing.Point(0, 0);
            this.AskLeftRect.Name = "AskLeftRect";
            this.AskLeftRect.Size = new System.Drawing.Size(98, 119);
            this.AskLeftRect.TabIndex = 5;
            this.AskLeftRect.TabStop = false;
            // 
            // bYe
            // 
            this.bYe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bYe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bYe.Location = new System.Drawing.Point(106, 49);
            this.bYe.Name = "bYe";
            this.bYe.Size = new System.Drawing.Size(257, 20);
            this.bYe.TabIndex = 0;
            this.bYe.Text = "Е (&1)";
            this.bYe.UseVisualStyleBackColor = false;
            this.bYe.Click += new System.EventHandler(this.bYeClick);
            this.bYe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bYeMouseDown);
            // 
            // bYeAll
            // 
            this.bYeAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bYeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bYeAll.Location = new System.Drawing.Point(367, 49);
            this.bYeAll.Name = "bYeAll";
            this.bYeAll.Size = new System.Drawing.Size(85, 20);
            this.bYeAll.TabIndex = 1;
            this.bYeAll.Text = "Всегда Е (&3)";
            this.bYeAll.UseVisualStyleBackColor = false;
            this.bYeAll.Click += new System.EventHandler(this.bYeAllClick);
            this.bYeAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bYeAllMouseDown);
            // 
            // bYo
            // 
            this.bYo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bYo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bYo.Location = new System.Drawing.Point(105, 73);
            this.bYo.Name = "bYo";
            this.bYo.Size = new System.Drawing.Size(257, 20);
            this.bYo.TabIndex = 2;
            this.bYo.Text = "Ё (&2)";
            this.bYo.UseVisualStyleBackColor = false;
            this.bYo.Click += new System.EventHandler(this.bYoClick);
            this.bYo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bYoMouseDown);
            // 
            // bUndo
            // 
            this.bUndo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bUndo.Enabled = false;
            this.bUndo.Location = new System.Drawing.Point(106, 96);
            this.bUndo.Name = "bUndo";
            this.bUndo.Size = new System.Drawing.Size(257, 20);
            this.bUndo.TabIndex = 4;
            this.bUndo.Text = "Откат";
            this.bUndo.UseVisualStyleBackColor = false;
            this.bUndo.Click += new System.EventHandler(this.bUndoClick);
            // 
            // bYoAll
            // 
            this.bYoAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bYoAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.bYoAll.Location = new System.Drawing.Point(367, 72);
            this.bYoAll.Name = "bYoAll";
            this.bYoAll.Size = new System.Drawing.Size(85, 20);
            this.bYoAll.TabIndex = 3;
            this.bYoAll.Text = "Всегда Ё (&4)";
            this.bYoAll.UseVisualStyleBackColor = false;
            this.bYoAll.Click += new System.EventHandler(this.bYoAllClick);
            this.bYoAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bYoAllMouseDown);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancel.Location = new System.Drawing.Point(367, 96);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(85, 20);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Прервать (Esc)";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancelClick);
            // 
            // ToolBar1
            // 
            this.ToolBar1.DropDownArrows = true;
            this.ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.ToolBar1.Name = "ToolBar1";
            this.ToolBar1.ShowToolTips = true;
            this.ToolBar1.Size = new System.Drawing.Size(571, 42);
            this.ToolBar1.TabIndex = 2;
            this.ToolBar1.Visible = false;
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.File1,
            this.Edit1,
            this.Yo1,
            this.Setting1,
            this.Help1});
            // 
            // File1
            // 
            this.File1.Index = 0;
            this.File1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Open1,
            this.Save1,
            this.Saveas1,
            this.Close1,
            this.OpenDic1,
            this.OpenRegExprDic1,
            this.Clearfilelist1,
            this.Fileprop1,
            this.Exit1,
            this.Openfile0});
            this.File1.Text = "Файл";
            // 
            // Open1
            // 
            this.Open1.Index = 0;
            this.Open1.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.Open1.Text = "Загрузить текст";
            this.Open1.Click += new System.EventHandler(this.Open1Click);
            // 
            // Save1
            // 
            this.Save1.Enabled = false;
            this.Save1.Index = 1;
            this.Save1.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.Save1.Text = "Сохранить текст";
            this.Save1.Click += new System.EventHandler(this.Save1Click);
            // 
            // Saveas1
            // 
            this.Saveas1.Enabled = false;
            this.Saveas1.Index = 2;
            this.Saveas1.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
            this.Saveas1.Text = "Сохранить текст как";
            this.Saveas1.Click += new System.EventHandler(this.Saveas1Click);
            // 
            // Close1
            // 
            this.Close1.Enabled = false;
            this.Close1.Index = 3;
            this.Close1.Text = "Очистить текстовое окно";
            this.Close1.Click += new System.EventHandler(this.Close1Click);
            // 
            // OpenDic1
            // 
            this.OpenDic1.Index = 4;
            this.OpenDic1.Text = "Загрузить основной словарь";
            this.OpenDic1.Click += new System.EventHandler(this.OpenDic1Click);
            // 
            // OpenRegExprDic1
            // 
            this.OpenRegExprDic1.Index = 5;
            this.OpenRegExprDic1.Text = "Загрузить словарь регулярных выражений";
            this.OpenRegExprDic1.Click += new System.EventHandler(this.OpenRegExprDic1Click);
            // 
            // Clearfilelist1
            // 
            this.Clearfilelist1.Enabled = false;
            this.Clearfilelist1.Index = 6;
            this.Clearfilelist1.Text = "Очистить список последних файлов";
            this.Clearfilelist1.Click += new System.EventHandler(this.Clearfilelist1Click);
            // 
            // Fileprop1
            // 
            this.Fileprop1.Enabled = false;
            this.Fileprop1.Index = 7;
            this.Fileprop1.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.Fileprop1.Text = "Свойства файла";
            this.Fileprop1.Click += new System.EventHandler(this.Fileprop1Click);
            // 
            // Exit1
            // 
            this.Exit1.Index = 8;
            this.Exit1.Text = "Выход";
            this.Exit1.Click += new System.EventHandler(this.Exit1Click);
            // 
            // Openfile0
            // 
            this.Openfile0.Index = 9;
            this.Openfile0.Text = "Openfile0";
            this.Openfile0.Visible = false;
            // 
            // Edit1
            // 
            this.Edit1.Index = 1;
            this.Edit1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Cut1,
            this.Copy1,
            this.Paste1,
            this.Selectall1,
            this.N3,
            this.Undo1,
            this.N2,
            this.Find1,
            this.Findreg1,
            this.Findagain1,
            this.Findyyfwd1,
            this.Findyyback1});
            this.Edit1.Text = "Редактировать";
            // 
            // Cut1
            // 
            this.Cut1.Index = 0;
            this.Cut1.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.Cut1.Text = "Вырезать";
            this.Cut1.Click += new System.EventHandler(this.Cut1Click);
            // 
            // Copy1
            // 
            this.Copy1.Index = 1;
            this.Copy1.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.Copy1.Text = "Копировать";
            this.Copy1.Click += new System.EventHandler(this.Copy1Click);
            // 
            // Paste1
            // 
            this.Paste1.Index = 2;
            this.Paste1.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.Paste1.Text = "Вставить";
            this.Paste1.Click += new System.EventHandler(this.Paste1Click);
            // 
            // Selectall1
            // 
            this.Selectall1.Index = 3;
            this.Selectall1.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.Selectall1.Text = "Выделить всё";
            this.Selectall1.Click += new System.EventHandler(this.Selectall1Click);
            // 
            // N3
            // 
            this.N3.Index = 4;
            this.N3.Text = "-";
            // 
            // Undo1
            // 
            this.Undo1.Enabled = false;
            this.Undo1.Index = 5;
            this.Undo1.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.Undo1.Text = "Откат";
            this.Undo1.Click += new System.EventHandler(this.Undo1Click);
            // 
            // N2
            // 
            this.N2.Index = 6;
            this.N2.Text = "-";
            // 
            // Find1
            // 
            this.Find1.Index = 7;
            this.Find1.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.Find1.Text = "Найти";
            this.Find1.Click += new System.EventHandler(this.Find1Click);
            // 
            // Findreg1
            // 
            this.Findreg1.Index = 8;
            this.Findreg1.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
            this.Findreg1.Text = "Найти регулярное выражение";
            this.Findreg1.Click += new System.EventHandler(this.Findreg1Click);
            // 
            // Findagain1
            // 
            this.Findagain1.Enabled = false;
            this.Findagain1.Index = 9;
            this.Findagain1.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.Findagain1.Text = "Найти снова";
            this.Findagain1.Click += new System.EventHandler(this.Findagain1Click);
            // 
            // Findyyfwd1
            // 
            this.Findyyfwd1.Index = 10;
            this.Findyyfwd1.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.Findyyfwd1.Text = "Искать замену вперёд";
            this.Findyyfwd1.Click += new System.EventHandler(this.Findyyfwd1Click);
            // 
            // Findyyback1
            // 
            this.Findyyback1.Index = 11;
            this.Findyyback1.Shortcut = System.Windows.Forms.Shortcut.CtrlQ;
            this.Findyyback1.Text = "Искать замену назад";
            this.Findyyback1.Click += new System.EventHandler(this.Findyyback1Click);
            // 
            // Yo1
            // 
            this.Yo1.Index = 2;
            this.Yo1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Yopos1,
            this.Yobegin1,
            this.RemoveMarked1,
            this.Clearusersel1});
            this.Yo1.Text = "Ёфикация";
            // 
            // Yopos1
            // 
            this.Yopos1.Index = 0;
            this.Yopos1.Shortcut = System.Windows.Forms.Shortcut.F9;
            this.Yopos1.Text = "Ёфицировать с текущей позиции";
            this.Yopos1.Click += new System.EventHandler(this.Yopos1Click);
            // 
            // Yobegin1
            // 
            this.Yobegin1.Index = 1;
            this.Yobegin1.Shortcut = System.Windows.Forms.Shortcut.CtrlF9;
            this.Yobegin1.Text = "Ёфицировать с начала текста";
            this.Yobegin1.Click += new System.EventHandler(this.Yobegin1Click);
            // 
            // RemoveMarked1
            // 
            this.RemoveMarked1.Index = 2;
            this.RemoveMarked1.Shortcut = System.Windows.Forms.Shortcut.ShiftF10;
            this.RemoveMarked1.Text = "Убрать выделение";
            this.RemoveMarked1.Click += new System.EventHandler(this.RemoveMarked1Click);
            // 
            // Clearusersel1
            // 
            this.Clearusersel1.Enabled = false;
            this.Clearusersel1.Index = 3;
            this.Clearusersel1.Text = "Сбросить \"Всегда Е/Ё\"";
            this.Clearusersel1.Click += new System.EventHandler(this.Clearusersel1Click);
            // 
            // Setting1
            // 
            this.Setting1.Index = 3;
            this.Setting1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Options1});
            this.Setting1.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.Setting1.Text = "Настройки";
            // 
            // Options1
            // 
            this.Options1.Index = 0;
            this.Options1.Text = "Опции";
            this.Options1.Click += new System.EventHandler(this.Options1Click);
            // 
            // Help1
            // 
            this.Help1.Index = 4;
            this.Help1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.About1,
            this.Moreabout1});
            this.Help1.Text = "Помощь";
            // 
            // About1
            // 
            this.About1.Index = 0;
            this.About1.Text = "О программе";
            this.About1.Click += new System.EventHandler(this.About1Click);
            // 
            // Moreabout1
            // 
            this.Moreabout1.Index = 1;
            this.Moreabout1.Text = "Ещё о программе";
            this.Moreabout1.Click += new System.EventHandler(this.Moreabout1Click);
            // 
            // odDic
            // 
            this.odDic.Filter = "Dictionary|*.dat";
            // 
            // PopupMenu1
            // 
            this.PopupMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Cut2,
            this.Copy2,
            this.Paste2});
            // 
            // Cut2
            // 
            this.Cut2.Index = 0;
            this.Cut2.Text = "Вырезать";
            this.Cut2.Click += new System.EventHandler(this.Cut1Click);
            // 
            // Copy2
            // 
            this.Copy2.Index = 1;
            this.Copy2.Text = "Копировать";
            this.Copy2.Click += new System.EventHandler(this.Copy1Click);
            // 
            // Paste2
            // 
            this.Paste2.Index = 2;
            this.Paste2.Text = "Вставить";
            this.Paste2.Click += new System.EventHandler(this.Paste1Click);
            // 
            // TMainForm
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(571, 474);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.AskPanel);
            this.Controls.Add(this.ToolBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(306, 130);
            this.Menu = this.MainMenu1;
            this.Name = "TMainForm";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormCloseQuery);
            this.Closed += new System.EventHandler(this.FormClose);
            this.Load += new System.EventHandler(this.FormCreate);
            ((System.ComponentModel.ISupportInitialize)(this._panel_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._panel_3)).EndInit();
            this.AskPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.ComponentModel.IContainer components;
    }
}
