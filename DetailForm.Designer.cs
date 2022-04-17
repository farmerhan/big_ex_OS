
namespace ProcessesManangement
{
    partial class DetailForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGridGeneral = new System.Windows.Forms.PropertyGrid();
            this.propertyGridStartInfo = new System.Windows.Forms.PropertyGrid();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, 22);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGridGeneral);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyGridStartInfo);
            this.splitContainer1.Size = new System.Drawing.Size(789, 416);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // propertyGridGeneral
            // 
            this.propertyGridGeneral.Location = new System.Drawing.Point(13, 0);
            this.propertyGridGeneral.Name = "propertyGridGeneral";
            this.propertyGridGeneral.Size = new System.Drawing.Size(251, 409);
            this.propertyGridGeneral.TabIndex = 0;
            // 
            // propertyGridStartInfo
            // 
            this.propertyGridStartInfo.Location = new System.Drawing.Point(1, 0);
            this.propertyGridStartInfo.Name = "propertyGridStartInfo";
            this.propertyGridStartInfo.Size = new System.Drawing.Size(519, 409);
            this.propertyGridStartInfo.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(646, 447);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(142, 38);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DetailForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid propertyGridGeneral;
        private System.Windows.Forms.PropertyGrid propertyGridStartInfo;
        private System.Windows.Forms.Button btn_Close;
    }
}