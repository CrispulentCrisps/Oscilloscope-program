namespace Oscilloscope
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earthTonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seaGreendefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chocolateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seaGreenDefaultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brightPastelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.LoadLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QualityDrop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SampRateDrop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1377, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            this.fIleToolStripMenuItem.Click += new System.EventHandler(this.fIleToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // tODOToolStripMenuItem
            // 
            this.tODOToolStripMenuItem.Name = "tODOToolStripMenuItem";
            this.tODOToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.tODOToolStripMenuItem.Text = "mp3";
            this.tODOToolStripMenuItem.Click += new System.EventHandler(this.tODOToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.palleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // palleteToolStripMenuItem
            // 
            this.palleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.pastelToolStripMenuItem,
            this.earthTonesToolStripMenuItem,
            this.seaGreendefaultToolStripMenuItem,
            this.berryToolStripMenuItem,
            this.chocolateToolStripMenuItem,
            this.fireToolStripMenuItem,
            this.seaGreenDefaultToolStripMenuItem1,
            this.brightPastelToolStripMenuItem});
            this.palleteToolStripMenuItem.Name = "palleteToolStripMenuItem";
            this.palleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.palleteToolStripMenuItem.Text = "Pallette";
            // 
            // brightToolStripMenuItem
            // 
            this.brightToolStripMenuItem.Name = "brightToolStripMenuItem";
            this.brightToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.brightToolStripMenuItem.Text = "Bright";
            this.brightToolStripMenuItem.Click += new System.EventHandler(this.brightToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // pastelToolStripMenuItem
            // 
            this.pastelToolStripMenuItem.Name = "pastelToolStripMenuItem";
            this.pastelToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pastelToolStripMenuItem.Text = "Pastel";
            this.pastelToolStripMenuItem.Click += new System.EventHandler(this.pastelToolStripMenuItem_Click);
            // 
            // earthTonesToolStripMenuItem
            // 
            this.earthTonesToolStripMenuItem.Name = "earthTonesToolStripMenuItem";
            this.earthTonesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.earthTonesToolStripMenuItem.Text = "Earth tones";
            this.earthTonesToolStripMenuItem.Click += new System.EventHandler(this.earthTonesToolStripMenuItem_Click);
            // 
            // seaGreendefaultToolStripMenuItem
            // 
            this.seaGreendefaultToolStripMenuItem.Name = "seaGreendefaultToolStripMenuItem";
            this.seaGreendefaultToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.seaGreendefaultToolStripMenuItem.Text = "Semi-transparent";
            this.seaGreendefaultToolStripMenuItem.Click += new System.EventHandler(this.seaGreendefaultToolStripMenuItem_Click);
            // 
            // berryToolStripMenuItem
            // 
            this.berryToolStripMenuItem.Name = "berryToolStripMenuItem";
            this.berryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.berryToolStripMenuItem.Text = "Berry";
            this.berryToolStripMenuItem.Click += new System.EventHandler(this.berryToolStripMenuItem_Click);
            // 
            // chocolateToolStripMenuItem
            // 
            this.chocolateToolStripMenuItem.Name = "chocolateToolStripMenuItem";
            this.chocolateToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.chocolateToolStripMenuItem.Text = "Chocolate";
            this.chocolateToolStripMenuItem.Click += new System.EventHandler(this.chocolateToolStripMenuItem_Click);
            // 
            // fireToolStripMenuItem
            // 
            this.fireToolStripMenuItem.Name = "fireToolStripMenuItem";
            this.fireToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fireToolStripMenuItem.Text = "Fire";
            this.fireToolStripMenuItem.Click += new System.EventHandler(this.fireToolStripMenuItem_Click);
            // 
            // seaGreenDefaultToolStripMenuItem1
            // 
            this.seaGreenDefaultToolStripMenuItem1.Name = "seaGreenDefaultToolStripMenuItem1";
            this.seaGreenDefaultToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.seaGreenDefaultToolStripMenuItem1.Text = "Sea green (Default)";
            this.seaGreenDefaultToolStripMenuItem1.Click += new System.EventHandler(this.seaGreenDefaultToolStripMenuItem1_Click);
            // 
            // brightPastelToolStripMenuItem
            // 
            this.brightPastelToolStripMenuItem.Name = "brightPastelToolStripMenuItem";
            this.brightPastelToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.brightPastelToolStripMenuItem.Text = "Bright pastel";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // chart1
            // 
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 27);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1211, 920);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadingLabel.Location = new System.Drawing.Point(644, 480);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(109, 26);
            this.LoadingLabel.TabIndex = 2;
            this.LoadingLabel.Text = "Loading file\r\nThis may take a while\r\n";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadingLabel.Visible = false;
            // 
            // LoadLabel
            // 
            this.LoadLabel.AutoSize = true;
            this.LoadLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadLabel.Location = new System.Drawing.Point(600, 467);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.Size = new System.Drawing.Size(180, 13);
            this.LoadLabel.TabIndex = 3;
            this.LoadLabel.Text = "Please load a file to see a waveform.";
            this.LoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1214, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Options take effect when \r\nnew sample is loaded";
            this.label1.Visible = false;
            // 
            // QualityDrop
            // 
            this.QualityDrop.FormattingEnabled = true;
            this.QualityDrop.Items.AddRange(new object[] {
            "16 bit",
            "32 bit"});
            this.QualityDrop.Location = new System.Drawing.Point(1222, 120);
            this.QualityDrop.Name = "QualityDrop";
            this.QualityDrop.Size = new System.Drawing.Size(121, 21);
            this.QualityDrop.TabIndex = 6;
            this.QualityDrop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1219, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Byte length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1219, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sampling Multiplier \r\n(Higher = better quality)";
            // 
            // SampRateDrop
            // 
            this.SampRateDrop.FormattingEnabled = true;
            this.SampRateDrop.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.SampRateDrop.Location = new System.Drawing.Point(1222, 177);
            this.SampRateDrop.Name = "SampRateDrop";
            this.SampRateDrop.Size = new System.Drawing.Size(121, 21);
            this.SampRateDrop.TabIndex = 8;
            this.SampRateDrop.SelectedIndexChanged += new System.EventHandler(this.SampRateDrop_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1222, 898);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Play \r\nwaveform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1377, 945);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SampRateDrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QualityDrop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadLabel);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Oscilloscope";
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palleteToolStripMenuItem;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.ToolStripMenuItem brightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earthTonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seaGreendefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chocolateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seaGreenDefaultToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brightPastelToolStripMenuItem;
        private System.Windows.Forms.Label LoadLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox QualityDrop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SampRateDrop;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tODOToolStripMenuItem;
    }
}
