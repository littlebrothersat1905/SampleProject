namespace DemoGUI
{
    partial class MainActivity
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.FileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AllTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcelTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CFGBox = new System.Windows.Forms.GroupBox();
            this.BTNCFG = new System.Windows.Forms.Button();
            this.BoxMMN = new System.Windows.Forms.TextBox();
            this.BoxMFN = new System.Windows.Forms.TextBox();
            this.BoxCL = new System.Windows.Forms.TextBox();
            this.LabelMMN = new System.Windows.Forms.Label();
            this.LabelMFN = new System.Windows.Forms.Label();
            this.LabelCL = new System.Windows.Forms.Label();
            this.LabelVN = new System.Windows.Forms.Label();
            this.AnalyzeBox = new System.Windows.Forms.GroupBox();
            this.BTNAll = new System.Windows.Forms.Button();
            this.BTNDistance = new System.Windows.Forms.Button();
            this.BYNAnalyze = new System.Windows.Forms.Button();
            this.BTNYolo = new System.Windows.Forms.Button();
            this.ListBoxInfo = new System.Windows.Forms.ListBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MenuBar.SuspendLayout();
            this.CFGBox.SuspendLayout();
            this.AnalyzeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTool,
            this.ViewTool,
            this.SearchTool});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(800, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "Menu";
            // 
            // FileTool
            // 
            this.FileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTool,
            this.SaveMenu,
            this.toolStripSeparator2,
            this.ExitTool});
            this.FileTool.Name = "FileTool";
            this.FileTool.Size = new System.Drawing.Size(37, 20);
            this.FileTool.Text = "File";
            // 
            // OpenTool
            // 
            this.OpenTool.Name = "OpenTool";
            this.OpenTool.Size = new System.Drawing.Size(103, 22);
            this.OpenTool.Text = "Open";
            this.OpenTool.Click += new System.EventHandler(this.OpenTool_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllTool,
            this.toolStripSeparator1,
            this.ExcelTool,
            this.DatabaseTool});
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(103, 22);
            this.SaveMenu.Text = "Save";
            // 
            // AllTool
            // 
            this.AllTool.Name = "AllTool";
            this.AllTool.Size = new System.Drawing.Size(122, 22);
            this.AllTool.Text = "All";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // ExcelTool
            // 
            this.ExcelTool.Name = "ExcelTool";
            this.ExcelTool.Size = new System.Drawing.Size(122, 22);
            this.ExcelTool.Text = "Excel";
            this.ExcelTool.Click += new System.EventHandler(this.ExcelTool_Click);
            // 
            // DatabaseTool
            // 
            this.DatabaseTool.Name = "DatabaseTool";
            this.DatabaseTool.Size = new System.Drawing.Size(122, 22);
            this.DatabaseTool.Text = "Database";
            this.DatabaseTool.Click += new System.EventHandler(this.DatabaseTool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // ExitTool
            // 
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(103, 22);
            this.ExitTool.Text = "Exit";
            this.ExitTool.Click += new System.EventHandler(this.ExitTool_Click);
            // 
            // ViewTool
            // 
            this.ViewTool.Name = "ViewTool";
            this.ViewTool.Size = new System.Drawing.Size(44, 20);
            this.ViewTool.Text = "View";
            // 
            // SearchTool
            // 
            this.SearchTool.Name = "SearchTool";
            this.SearchTool.Size = new System.Drawing.Size(54, 20);
            this.SearchTool.Text = "Search";
            this.SearchTool.Click += new System.EventHandler(this.SearchTool_Click);
            // 
            // CFGBox
            // 
            this.CFGBox.Controls.Add(this.BTNCFG);
            this.CFGBox.Controls.Add(this.BoxMMN);
            this.CFGBox.Controls.Add(this.BoxMFN);
            this.CFGBox.Controls.Add(this.BoxCL);
            this.CFGBox.Controls.Add(this.LabelMMN);
            this.CFGBox.Controls.Add(this.LabelMFN);
            this.CFGBox.Controls.Add(this.LabelCL);
            this.CFGBox.Controls.Add(this.LabelVN);
            this.CFGBox.Location = new System.Drawing.Point(545, 65);
            this.CFGBox.Name = "CFGBox";
            this.CFGBox.Size = new System.Drawing.Size(240, 165);
            this.CFGBox.TabIndex = 1;
            this.CFGBox.TabStop = false;
            this.CFGBox.Text = "Configuration";
            // 
            // BTNCFG
            // 
            this.BTNCFG.Location = new System.Drawing.Point(75, 125);
            this.BTNCFG.Name = "BTNCFG";
            this.BTNCFG.Size = new System.Drawing.Size(75, 25);
            this.BTNCFG.TabIndex = 7;
            this.BTNCFG.Text = "Confirm";
            this.BTNCFG.UseVisualStyleBackColor = true;
            this.BTNCFG.Click += new System.EventHandler(this.ButtonCFG_Click);
            // 
            // BoxMMN
            // 
            this.BoxMMN.Location = new System.Drawing.Point(110, 100);
            this.BoxMMN.Name = "BoxMMN";
            this.BoxMMN.Size = new System.Drawing.Size(100, 20);
            this.BoxMMN.TabIndex = 6;
            // 
            // BoxMFN
            // 
            this.BoxMFN.Location = new System.Drawing.Point(110, 75);
            this.BoxMFN.Name = "BoxMFN";
            this.BoxMFN.Size = new System.Drawing.Size(100, 20);
            this.BoxMFN.TabIndex = 5;
            // 
            // BoxCL
            // 
            this.BoxCL.Location = new System.Drawing.Point(110, 50);
            this.BoxCL.Name = "BoxCL";
            this.BoxCL.Size = new System.Drawing.Size(100, 20);
            this.BoxCL.TabIndex = 4;
            // 
            // LabelMMN
            // 
            this.LabelMMN.AutoSize = true;
            this.LabelMMN.Location = new System.Drawing.Point(7, 100);
            this.LabelMMN.Name = "LabelMMN";
            this.LabelMMN.Size = new System.Drawing.Size(92, 13);
            this.LabelMMN.TabIndex = 3;
            this.LabelMMN.Text = "Merge Meter Num";
            // 
            // LabelMFN
            // 
            this.LabelMFN.AutoSize = true;
            this.LabelMFN.Location = new System.Drawing.Point(7, 75);
            this.LabelMFN.Name = "LabelMFN";
            this.LabelMFN.Size = new System.Drawing.Size(94, 13);
            this.LabelMFN.TabIndex = 2;
            this.LabelMFN.Text = "Merge Frame Num";
            // 
            // LabelCL
            // 
            this.LabelCL.AutoSize = true;
            this.LabelCL.Location = new System.Drawing.Point(7, 50);
            this.LabelCL.Name = "LabelCL";
            this.LabelCL.Size = new System.Drawing.Size(90, 13);
            this.LabelCL.TabIndex = 1;
            this.LabelCL.Text = "Confidence Level";
            // 
            // LabelVN
            // 
            this.LabelVN.AutoSize = true;
            this.LabelVN.Location = new System.Drawing.Point(7, 25);
            this.LabelVN.Name = "LabelVN";
            this.LabelVN.Size = new System.Drawing.Size(65, 13);
            this.LabelVN.TabIndex = 0;
            this.LabelVN.Text = "Video Name";
            this.LabelVN.Visible = false;
            // 
            // AnalyzeBox
            // 
            this.AnalyzeBox.Controls.Add(this.BTNAll);
            this.AnalyzeBox.Controls.Add(this.BTNDistance);
            this.AnalyzeBox.Controls.Add(this.BYNAnalyze);
            this.AnalyzeBox.Controls.Add(this.BTNYolo);
            this.AnalyzeBox.Location = new System.Drawing.Point(545, 290);
            this.AnalyzeBox.Name = "AnalyzeBox";
            this.AnalyzeBox.Size = new System.Drawing.Size(240, 100);
            this.AnalyzeBox.TabIndex = 2;
            this.AnalyzeBox.TabStop = false;
            // 
            // BTNAll
            // 
            this.BTNAll.Location = new System.Drawing.Point(120, 60);
            this.BTNAll.Name = "BTNAll";
            this.BTNAll.Size = new System.Drawing.Size(100, 25);
            this.BTNAll.TabIndex = 3;
            this.BTNAll.Text = "Run All";
            this.BTNAll.UseVisualStyleBackColor = true;
            this.BTNAll.Click += new System.EventHandler(this.BTNAll_Click);
            // 
            // BTNDistance
            // 
            this.BTNDistance.Location = new System.Drawing.Point(10, 60);
            this.BTNDistance.Name = "BTNDistance";
            this.BTNDistance.Size = new System.Drawing.Size(100, 25);
            this.BTNDistance.TabIndex = 2;
            this.BTNDistance.Text = "Get Distance";
            this.BTNDistance.UseVisualStyleBackColor = true;
            this.BTNDistance.Click += new System.EventHandler(this.BTNDistance_Click);
            // 
            // BYNAnalyze
            // 
            this.BYNAnalyze.Location = new System.Drawing.Point(120, 20);
            this.BYNAnalyze.Name = "BYNAnalyze";
            this.BYNAnalyze.Size = new System.Drawing.Size(100, 25);
            this.BYNAnalyze.TabIndex = 1;
            this.BYNAnalyze.Text = "Analyze Yolo";
            this.BYNAnalyze.UseVisualStyleBackColor = true;
            this.BYNAnalyze.Click += new System.EventHandler(this.BYNAnalyze_Click);
            // 
            // BTNYolo
            // 
            this.BTNYolo.Location = new System.Drawing.Point(10, 20);
            this.BTNYolo.Name = "BTNYolo";
            this.BTNYolo.Size = new System.Drawing.Size(100, 25);
            this.BTNYolo.TabIndex = 0;
            this.BTNYolo.Text = "Run Yolo";
            this.BTNYolo.UseVisualStyleBackColor = true;
            this.BTNYolo.Click += new System.EventHandler(this.BTNYolo_Click);
            // 
            // ListBoxInfo
            // 
            this.ListBoxInfo.FormattingEnabled = true;
            this.ListBoxInfo.Location = new System.Drawing.Point(25, 65);
            this.ListBoxInfo.Name = "ListBoxInfo";
            this.ListBoxInfo.Size = new System.Drawing.Size(450, 277);
            this.ListBoxInfo.TabIndex = 3;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(25, 366);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(450, 23);
            this.ProgressBar.TabIndex = 4;

            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ListBoxInfo);
            this.Controls.Add(this.AnalyzeBox);
            this.Controls.Add(this.CFGBox);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "MainActivity";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.MainActivity_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.CFGBox.ResumeLayout(false);
            this.CFGBox.PerformLayout();
            this.AnalyzeBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem FileTool;
        private System.Windows.Forms.ToolStripMenuItem OpenTool;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem AllTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExcelTool;
        private System.Windows.Forms.ToolStripMenuItem DatabaseTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitTool;
        private System.Windows.Forms.ToolStripMenuItem ViewTool;
        private System.Windows.Forms.ToolStripMenuItem SearchTool;
        private System.Windows.Forms.GroupBox CFGBox;
        private System.Windows.Forms.Label LabelVN;
        private System.Windows.Forms.Label LabelCL;
        private System.Windows.Forms.Label LabelMFN;
        private System.Windows.Forms.Label LabelMMN;
        private System.Windows.Forms.TextBox BoxMMN;
        private System.Windows.Forms.TextBox BoxMFN;
        private System.Windows.Forms.TextBox BoxCL;
        private System.Windows.Forms.Button BTNCFG;
        private System.Windows.Forms.GroupBox AnalyzeBox;
        private System.Windows.Forms.Button BTNYolo;
        private System.Windows.Forms.Button BYNAnalyze;
        private System.Windows.Forms.Button BTNDistance;
        private System.Windows.Forms.Button BTNAll;
        private System.Windows.Forms.ListBox ListBoxInfo;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

