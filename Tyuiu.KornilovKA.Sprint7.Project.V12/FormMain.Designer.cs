
namespace Tyuiu.KornilovKA.Sprint7.Project.V12
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripUpperPanel_KKA = new System.Windows.Forms.ToolStrip();
            this.panelMenu_KKA = new System.Windows.Forms.Panel();
            this.panelDataGrid_KKA = new System.Windows.Forms.Panel();
            this.toolStripButtonInfoProgram_KKA = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTable_KKA = new System.Windows.Forms.DataGridView();
            this.toolStripUpperPanel_KKA.SuspendLayout();
            this.panelDataGrid_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KKA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripUpperPanel_KKA
            // 
            this.toolStripUpperPanel_KKA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInfoProgram_KKA});
            this.toolStripUpperPanel_KKA.Location = new System.Drawing.Point(0, 0);
            this.toolStripUpperPanel_KKA.Name = "toolStripUpperPanel_KKA";
            this.toolStripUpperPanel_KKA.Size = new System.Drawing.Size(800, 25);
            this.toolStripUpperPanel_KKA.TabIndex = 0;
            this.toolStripUpperPanel_KKA.Text = "toolStrip1";
            // 
            // panelMenu_KKA
            // 
            this.panelMenu_KKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu_KKA.Location = new System.Drawing.Point(0, 25);
            this.panelMenu_KKA.Name = "panelMenu_KKA";
            this.panelMenu_KKA.Size = new System.Drawing.Size(200, 425);
            this.panelMenu_KKA.TabIndex = 1;
            // 
            // panelDataGrid_KKA
            // 
            this.panelDataGrid_KKA.Controls.Add(this.dataGridViewTable_KKA);
            this.panelDataGrid_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid_KKA.Location = new System.Drawing.Point(200, 25);
            this.panelDataGrid_KKA.Name = "panelDataGrid_KKA";
            this.panelDataGrid_KKA.Size = new System.Drawing.Size(600, 425);
            this.panelDataGrid_KKA.TabIndex = 2;
            // 
            // toolStripButtonInfoProgram_KKA
            // 
            this.toolStripButtonInfoProgram_KKA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonInfoProgram_KKA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInfoProgram_KKA.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfoProgram_KKA.Image")));
            this.toolStripButtonInfoProgram_KKA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfoProgram_KKA.Name = "toolStripButtonInfoProgram_KKA";
            this.toolStripButtonInfoProgram_KKA.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonInfoProgram_KKA.Text = "О программе";
            this.toolStripButtonInfoProgram_KKA.Click += new System.EventHandler(this.toolStripButtonInfoProgram_KKA_Click);
            // 
            // dataGridViewTable_KKA
            // 
            this.dataGridViewTable_KKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTable_KKA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTable_KKA.Name = "dataGridViewTable_KKA";
            this.dataGridViewTable_KKA.Size = new System.Drawing.Size(600, 425);
            this.dataGridViewTable_KKA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDataGrid_KKA);
            this.Controls.Add(this.panelMenu_KKA);
            this.Controls.Add(this.toolStripUpperPanel_KKA);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStripUpperPanel_KKA.ResumeLayout(false);
            this.toolStripUpperPanel_KKA.PerformLayout();
            this.panelDataGrid_KKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUpperPanel_KKA;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfoProgram_KKA;
        private System.Windows.Forms.Panel panelMenu_KKA;
        private System.Windows.Forms.Panel panelDataGrid_KKA;
        private System.Windows.Forms.DataGridView dataGridViewTable_KKA;
    }
}

