namespace ProcessesManangement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView_showProcs = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBarcpu = new System.Windows.Forms.ProgressBar();
            this.lbcpu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarram = new System.Windows.Forms.ProgressBar();
            this.lbram = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "";
            columnHeader1.Width = 100;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 462);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_showProcs);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(807, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dtails";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listView_showProcs
            // 
            this.listView_showProcs.BackColor = System.Drawing.SystemColors.Menu;
            this.listView_showProcs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_showProcs.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_showProcs.FullRowSelect = true;
            this.listView_showProcs.HideSelection = false;
            this.listView_showProcs.Location = new System.Drawing.Point(7, 7);
            this.listView_showProcs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_showProcs.Name = "listView_showProcs";
            this.listView_showProcs.Size = new System.Drawing.Size(788, 421);
            this.listView_showProcs.TabIndex = 1;
            this.listView_showProcs.UseCompatibleStateImageBehavior = false;
            this.listView_showProcs.View = System.Windows.Forms.View.Details;
            this.listView_showProcs.SelectedIndexChanged += new System.EventHandler(this.listView_showProcs_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Username";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Memory";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.chart1);
            this.tab2.Controls.Add(this.progressBarcpu);
            this.tab2.Controls.Add(this.lbcpu);
            this.tab2.Controls.Add(this.label3);
            this.tab2.Controls.Add(this.progressBarram);
            this.tab2.Controls.Add(this.lbram);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Controls.Add(this.label1);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(4);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(4);
            this.tab2.Size = new System.Drawing.Size(807, 433);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Performance";
            this.tab2.UseVisualStyleBackColor = true;
            this.tab2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(137, 148);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "CPU";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "RAM";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(603, 260);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // progressBarcpu
            // 
            this.progressBarcpu.Location = new System.Drawing.Point(137, 22);
            this.progressBarcpu.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarcpu.Name = "progressBarcpu";
            this.progressBarcpu.Size = new System.Drawing.Size(487, 33);
            this.progressBarcpu.TabIndex = 8;
            this.progressBarcpu.Click += new System.EventHandler(this.progressBarcpu_Click);
            // 
            // lbcpu
            // 
            this.lbcpu.AutoSize = true;
            this.lbcpu.Location = new System.Drawing.Point(665, 39);
            this.lbcpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcpu.Name = "lbcpu";
            this.lbcpu.Size = new System.Drawing.Size(28, 17);
            this.lbcpu.TabIndex = 4;
            this.lbcpu.Text = "0%";
            this.lbcpu.Click += new System.EventHandler(this.lbcpu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPU";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBarram
            // 
            this.progressBarram.Location = new System.Drawing.Point(137, 86);
            this.progressBarram.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarram.Name = "progressBarram";
            this.progressBarram.Size = new System.Drawing.Size(487, 33);
            this.progressBarram.TabIndex = 9;
            this.progressBarram.Click += new System.EventHandler(this.progressBarram_Click);
            // 
            // lbram
            // 
            this.lbram.AutoSize = true;
            this.lbram.Location = new System.Drawing.Point(665, 103);
            this.lbram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbram.Name = "lbram";
            this.lbram.Size = new System.Drawing.Size(28, 17);
            this.lbram.TabIndex = 6;
            this.lbram.Text = "0%";
            this.lbram.Click += new System.EventHandler(this.lbram_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "RAM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes in Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 453);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView_showProcs;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.ProgressBar progressBarcpu;
        private System.Windows.Forms.Label lbcpu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarram;
        private System.Windows.Forms.Label lbram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    }
}

