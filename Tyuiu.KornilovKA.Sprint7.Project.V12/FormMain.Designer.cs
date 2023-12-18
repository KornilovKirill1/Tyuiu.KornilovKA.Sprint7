
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
            this.buttonManual_KKA = new System.Windows.Forms.Button();
            this.buttonChangedMainOnManufacturer_KKA = new System.Windows.Forms.Button();
            this.panelDataGrid_KKA = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddNewPC_KKA = new System.Windows.Forms.Button();
            this.textBoxClockFrequency_KKA = new System.Windows.Forms.TextBox();
            this.textBoxTypeCPU_KKA = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer_KKA = new System.Windows.Forms.TextBox();
            this.dataGridViewTable_KKA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTable_KKA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogNewData_KKA = new System.Windows.Forms.SaveFileDialog();
            this.numericUpDownCountCore_KKA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCountMemory_KKA = new System.Windows.Forms.NumericUpDown();
            this.textBoxCountDisk_KKA = new System.Windows.Forms.TextBox();
            this.dateTimePickerRelease_KKA = new System.Windows.Forms.DateTimePicker();
            this.buttonChangedMainonPC_KKA = new System.Windows.Forms.Button();
            this.toolStripButtonInfoProgram_KKA = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonFile_KKA = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemOpen_KKA = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave_KKA = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPrice_KKA = new System.Windows.Forms.TextBox();
            this.toolStripUpperPanel_KKA.SuspendLayout();
            this.panelMenu_KKA.SuspendLayout();
            this.panelDataGrid_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCore_KKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountMemory_KKA)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripUpperPanel_KKA
            // 
            this.toolStripUpperPanel_KKA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInfoProgram_KKA,
            this.toolStripDropDownButtonFile_KKA});
            this.toolStripUpperPanel_KKA.Location = new System.Drawing.Point(0, 0);
            this.toolStripUpperPanel_KKA.Name = "toolStripUpperPanel_KKA";
            this.toolStripUpperPanel_KKA.Size = new System.Drawing.Size(928, 25);
            this.toolStripUpperPanel_KKA.TabIndex = 0;
            this.toolStripUpperPanel_KKA.Text = "toolStrip1";
            // 
            // panelMenu_KKA
            // 
            this.panelMenu_KKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu_KKA.Controls.Add(this.buttonManual_KKA);
            this.panelMenu_KKA.Controls.Add(this.buttonChangedMainOnManufacturer_KKA);
            this.panelMenu_KKA.Controls.Add(this.buttonChangedMainonPC_KKA);
            this.panelMenu_KKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu_KKA.Location = new System.Drawing.Point(0, 25);
            this.panelMenu_KKA.Name = "panelMenu_KKA";
            this.panelMenu_KKA.Size = new System.Drawing.Size(200, 425);
            this.panelMenu_KKA.TabIndex = 1;
            // 
            // buttonManual_KKA
            // 
            this.buttonManual_KKA.Location = new System.Drawing.Point(0, 382);
            this.buttonManual_KKA.Name = "buttonManual_KKA";
            this.buttonManual_KKA.Size = new System.Drawing.Size(200, 44);
            this.buttonManual_KKA.TabIndex = 2;
            this.buttonManual_KKA.Text = "Руководство пользователя";
            this.buttonManual_KKA.UseVisualStyleBackColor = true;
            // 
            // buttonChangedMainOnManufacturer_KKA
            // 
            this.buttonChangedMainOnManufacturer_KKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangedMainOnManufacturer_KKA.Location = new System.Drawing.Point(0, 44);
            this.buttonChangedMainOnManufacturer_KKA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChangedMainOnManufacturer_KKA.Name = "buttonChangedMainOnManufacturer_KKA";
            this.buttonChangedMainOnManufacturer_KKA.Size = new System.Drawing.Size(198, 44);
            this.buttonChangedMainOnManufacturer_KKA.TabIndex = 1;
            this.buttonChangedMainOnManufacturer_KKA.Text = "Производитель";
            this.buttonChangedMainOnManufacturer_KKA.UseVisualStyleBackColor = true;
            this.buttonChangedMainOnManufacturer_KKA.Click += new System.EventHandler(this.buttonChangedMainOnManufacturer_KKA_Click);
            // 
            // panelDataGrid_KKA
            // 
            this.panelDataGrid_KKA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataGrid_KKA.Controls.Add(this.textBoxPrice_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.dateTimePickerRelease_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.textBoxCountDisk_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.numericUpDownCountMemory_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.numericUpDownCountCore_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.button2);
            this.panelDataGrid_KKA.Controls.Add(this.buttonAddNewPC_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.textBoxClockFrequency_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.textBoxTypeCPU_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.textBoxManufacturer_KKA);
            this.panelDataGrid_KKA.Controls.Add(this.dataGridViewTable_KKA);
            this.panelDataGrid_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid_KKA.Location = new System.Drawing.Point(200, 25);
            this.panelDataGrid_KKA.Name = "panelDataGrid_KKA";
            this.panelDataGrid_KKA.Size = new System.Drawing.Size(728, 425);
            this.panelDataGrid_KKA.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewPC_KKA
            // 
            this.buttonAddNewPC_KKA.Location = new System.Drawing.Point(20, 389);
            this.buttonAddNewPC_KKA.Name = "buttonAddNewPC_KKA";
            this.buttonAddNewPC_KKA.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewPC_KKA.TabIndex = 5;
            this.buttonAddNewPC_KKA.Text = "Добавить";
            this.buttonAddNewPC_KKA.UseVisualStyleBackColor = true;
            this.buttonAddNewPC_KKA.Click += new System.EventHandler(this.buttonAddNewPC_KKA_Click);
            // 
            // textBoxClockFrequency_KKA
            // 
            this.textBoxClockFrequency_KKA.Location = new System.Drawing.Point(276, 343);
            this.textBoxClockFrequency_KKA.Name = "textBoxClockFrequency_KKA";
            this.textBoxClockFrequency_KKA.Size = new System.Drawing.Size(50, 20);
            this.textBoxClockFrequency_KKA.TabIndex = 4;
            // 
            // textBoxTypeCPU_KKA
            // 
            this.textBoxTypeCPU_KKA.Location = new System.Drawing.Point(113, 343);
            this.textBoxTypeCPU_KKA.Name = "textBoxTypeCPU_KKA";
            this.textBoxTypeCPU_KKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeCPU_KKA.TabIndex = 3;
            // 
            // textBoxManufacturer_KKA
            // 
            this.textBoxManufacturer_KKA.Location = new System.Drawing.Point(7, 343);
            this.textBoxManufacturer_KKA.Name = "textBoxManufacturer_KKA";
            this.textBoxManufacturer_KKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxManufacturer_KKA.TabIndex = 1;
            // 
            // dataGridViewTable_KKA
            // 
            this.dataGridViewTable_KKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_KKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewTable_KKA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTable_KKA.Name = "dataGridViewTable_KKA";
            this.dataGridViewTable_KKA.Size = new System.Drawing.Size(726, 312);
            this.dataGridViewTable_KKA.TabIndex = 0;
            // 
            // openFileDialogTable_KKA
            // 
            this.openFileDialogTable_KKA.FileName = "openFileDialog1";
            // 
            // numericUpDownCountCore_KKA
            // 
            this.numericUpDownCountCore_KKA.Location = new System.Drawing.Point(219, 343);
            this.numericUpDownCountCore_KKA.Name = "numericUpDownCountCore_KKA";
            this.numericUpDownCountCore_KKA.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCountCore_KKA.TabIndex = 7;
            // 
            // numericUpDownCountMemory_KKA
            // 
            this.numericUpDownCountMemory_KKA.Location = new System.Drawing.Point(333, 343);
            this.numericUpDownCountMemory_KKA.Name = "numericUpDownCountMemory_KKA";
            this.numericUpDownCountMemory_KKA.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCountMemory_KKA.TabIndex = 8;
            // 
            // textBoxCountDisk_KKA
            // 
            this.textBoxCountDisk_KKA.Location = new System.Drawing.Point(390, 343);
            this.textBoxCountDisk_KKA.Name = "textBoxCountDisk_KKA";
            this.textBoxCountDisk_KKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountDisk_KKA.TabIndex = 9;
            // 
            // dateTimePickerRelease_KKA
            // 
            this.dateTimePickerRelease_KKA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRelease_KKA.Location = new System.Drawing.Point(496, 343);
            this.dateTimePickerRelease_KKA.Name = "dateTimePickerRelease_KKA";
            this.dateTimePickerRelease_KKA.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerRelease_KKA.TabIndex = 10;
            // 
            // buttonChangedMainonPC_KKA
            // 
            this.buttonChangedMainonPC_KKA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangedMainonPC_KKA.Location = new System.Drawing.Point(0, 0);
            this.buttonChangedMainonPC_KKA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChangedMainonPC_KKA.Name = "buttonChangedMainonPC_KKA";
            this.buttonChangedMainonPC_KKA.Size = new System.Drawing.Size(198, 44);
            this.buttonChangedMainonPC_KKA.TabIndex = 0;
            this.buttonChangedMainonPC_KKA.Text = "ЭВМ";
            this.buttonChangedMainonPC_KKA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonChangedMainonPC_KKA.UseVisualStyleBackColor = true;
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
            // toolStripDropDownButtonFile_KKA
            // 
            this.toolStripDropDownButtonFile_KKA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile_KKA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpen_KKA,
            this.ToolStripMenuItemSave_KKA});
            this.toolStripDropDownButtonFile_KKA.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile_KKA.Image")));
            this.toolStripDropDownButtonFile_KKA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile_KKA.Name = "toolStripDropDownButtonFile_KKA";
            this.toolStripDropDownButtonFile_KKA.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButtonFile_KKA.Text = "Файл";
            // 
            // ToolStripMenuItemOpen_KKA
            // 
            this.ToolStripMenuItemOpen_KKA.Name = "ToolStripMenuItemOpen_KKA";
            this.ToolStripMenuItemOpen_KKA.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemOpen_KKA.Text = "Открыть";
            this.ToolStripMenuItemOpen_KKA.Click += new System.EventHandler(this.ToolStripMenuItemOpen_KKA_Click);
            // 
            // ToolStripMenuItemSave_KKA
            // 
            this.ToolStripMenuItemSave_KKA.Name = "ToolStripMenuItemSave_KKA";
            this.ToolStripMenuItemSave_KKA.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSave_KKA.Text = "Сохранить";
            // 
            // textBoxPrice_KKA
            // 
            this.textBoxPrice_KKA.Location = new System.Drawing.Point(599, 343);
            this.textBoxPrice_KKA.Name = "textBoxPrice_KKA";
            this.textBoxPrice_KKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice_KKA.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.panelDataGrid_KKA);
            this.Controls.Add(this.panelMenu_KKA);
            this.Controls.Add(this.toolStripUpperPanel_KKA);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт ЭВМ";
            this.toolStripUpperPanel_KKA.ResumeLayout(false);
            this.toolStripUpperPanel_KKA.PerformLayout();
            this.panelMenu_KKA.ResumeLayout(false);
            this.panelDataGrid_KKA.ResumeLayout(false);
            this.panelDataGrid_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCore_KKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountMemory_KKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUpperPanel_KKA;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfoProgram_KKA;
        private System.Windows.Forms.Panel panelMenu_KKA;
        private System.Windows.Forms.Panel panelDataGrid_KKA;
        private System.Windows.Forms.DataGridView dataGridViewTable_KKA;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile_KKA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen_KKA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave_KKA;
        private System.Windows.Forms.Button buttonChangedMainOnManufacturer_KKA;
        private System.Windows.Forms.Button buttonChangedMainonPC_KKA;
        private System.Windows.Forms.Button buttonManual_KKA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddNewPC_KKA;
        private System.Windows.Forms.TextBox textBoxClockFrequency_KKA;
        private System.Windows.Forms.TextBox textBoxTypeCPU_KKA;
        private System.Windows.Forms.TextBox textBoxManufacturer_KKA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_KKA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogNewData_KKA;
        private System.Windows.Forms.NumericUpDown numericUpDownCountCore_KKA;
        private System.Windows.Forms.DateTimePicker dateTimePickerRelease_KKA;
        private System.Windows.Forms.TextBox textBoxCountDisk_KKA;
        private System.Windows.Forms.NumericUpDown numericUpDownCountMemory_KKA;
        private System.Windows.Forms.TextBox textBoxPrice_KKA;
    }
}

