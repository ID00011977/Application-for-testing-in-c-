
namespace FunPro.CW1._11977
{
    partial class TestlistForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quest1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quest2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quest3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quest1DataGridViewTextBoxColumn,
            this.answer1DataGridViewTextBoxColumn,
            this.quest2DataGridViewTextBoxColumn,
            this.answer2DataGridViewTextBoxColumn,
            this.quest3DataGridViewTextBoxColumn,
            this.answer3DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.testBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(899, 334);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quest1DataGridViewTextBoxColumn
            // 
            this.quest1DataGridViewTextBoxColumn.DataPropertyName = "Quest1";
            this.quest1DataGridViewTextBoxColumn.HeaderText = "Quest1";
            this.quest1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quest1DataGridViewTextBoxColumn.Name = "quest1DataGridViewTextBoxColumn";
            this.quest1DataGridViewTextBoxColumn.ReadOnly = true;
            this.quest1DataGridViewTextBoxColumn.Width = 125;
            // 
            // answer1DataGridViewTextBoxColumn
            // 
            this.answer1DataGridViewTextBoxColumn.DataPropertyName = "Answer1";
            this.answer1DataGridViewTextBoxColumn.HeaderText = "Answer1";
            this.answer1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answer1DataGridViewTextBoxColumn.Name = "answer1DataGridViewTextBoxColumn";
            this.answer1DataGridViewTextBoxColumn.ReadOnly = true;
            this.answer1DataGridViewTextBoxColumn.Width = 125;
            // 
            // quest2DataGridViewTextBoxColumn
            // 
            this.quest2DataGridViewTextBoxColumn.DataPropertyName = "Quest2";
            this.quest2DataGridViewTextBoxColumn.HeaderText = "Quest2";
            this.quest2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quest2DataGridViewTextBoxColumn.Name = "quest2DataGridViewTextBoxColumn";
            this.quest2DataGridViewTextBoxColumn.ReadOnly = true;
            this.quest2DataGridViewTextBoxColumn.Width = 125;
            // 
            // answer2DataGridViewTextBoxColumn
            // 
            this.answer2DataGridViewTextBoxColumn.DataPropertyName = "Answer2";
            this.answer2DataGridViewTextBoxColumn.HeaderText = "Answer2";
            this.answer2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answer2DataGridViewTextBoxColumn.Name = "answer2DataGridViewTextBoxColumn";
            this.answer2DataGridViewTextBoxColumn.ReadOnly = true;
            this.answer2DataGridViewTextBoxColumn.Width = 125;
            // 
            // quest3DataGridViewTextBoxColumn
            // 
            this.quest3DataGridViewTextBoxColumn.DataPropertyName = "Quest3";
            this.quest3DataGridViewTextBoxColumn.HeaderText = "Quest3";
            this.quest3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quest3DataGridViewTextBoxColumn.Name = "quest3DataGridViewTextBoxColumn";
            this.quest3DataGridViewTextBoxColumn.ReadOnly = true;
            this.quest3DataGridViewTextBoxColumn.Width = 125;
            // 
            // answer3DataGridViewTextBoxColumn
            // 
            this.answer3DataGridViewTextBoxColumn.DataPropertyName = "Answer3";
            this.answer3DataGridViewTextBoxColumn.HeaderText = "Answer3";
            this.answer3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answer3DataGridViewTextBoxColumn.Name = "answer3DataGridViewTextBoxColumn";
            this.answer3DataGridViewTextBoxColumn.ReadOnly = true;
            this.answer3DataGridViewTextBoxColumn.Width = 125;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(CW.DAL.Test);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(917, 168);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 30);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(917, 118);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(917, 62);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(917, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // TestlistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Name = "TestlistForm";
            this.Text = "TestlistForm";
            this.Load += new System.EventHandler(this.TestlistForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quest1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quest2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quest3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer3DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}