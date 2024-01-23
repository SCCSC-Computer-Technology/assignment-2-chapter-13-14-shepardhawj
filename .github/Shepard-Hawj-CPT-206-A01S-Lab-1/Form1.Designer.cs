
namespace Shepard_Hawj_CPT_206_A01S_Lab_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDBDataSet = new Shepard_Hawj_CPT_206_A01S_Lab_1.ProductDBDataSet();
            this.productTableAdapter = new Shepard_Hawj_CPT_206_A01S_Lab_1.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.productNumTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.productDesTextBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.moreTextBox = new System.Windows.Forms.TextBox();
            this.lessTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear_2 = new System.Windows.Forms.Button();
            this.btnSearch_2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear_1 = new System.Windows.Forms.Button();
            this.btnSearch_1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch_3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputListBox2 = new System.Windows.Forms.ListBox();
            this.outputListBox3 = new System.Windows.Forms.ListBox();
            this.btnClear_3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsOnHandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(882, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            this.unitsOnHandDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productNumTextBox
            // 
            this.productNumTextBox.Location = new System.Drawing.Point(20, 58);
            this.productNumTextBox.Name = "productNumTextBox";
            this.productNumTextBox.Size = new System.Drawing.Size(196, 26);
            this.productNumTextBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1019, 595);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 20;
            this.outputListBox.Location = new System.Drawing.Point(43, 169);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(374, 264);
            this.outputListBox.TabIndex = 3;
            // 
            // productDesTextBox
            // 
            this.productDesTextBox.Location = new System.Drawing.Point(261, 58);
            this.productDesTextBox.Name = "productDesTextBox";
            this.productDesTextBox.Size = new System.Drawing.Size(227, 26);
            this.productDesTextBox.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1137, 595);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 38);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Description:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1247, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // moreTextBox
            // 
            this.moreTextBox.Location = new System.Drawing.Point(29, 56);
            this.moreTextBox.Name = "moreTextBox";
            this.moreTextBox.Size = new System.Drawing.Size(100, 26);
            this.moreTextBox.TabIndex = 9;
            // 
            // lessTextBox
            // 
            this.lessTextBox.Location = new System.Drawing.Point(171, 56);
            this.lessTextBox.Name = "lessTextBox";
            this.lessTextBox.Size = new System.Drawing.Size(100, 26);
            this.lessTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "More Than:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Less Than:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear_2);
            this.groupBox1.Controls.Add(this.btnSearch_2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.moreTextBox);
            this.groupBox1.Controls.Add(this.lessTextBox);
            this.groupBox1.Location = new System.Drawing.Point(599, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 148);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Units On Hand Search";
            // 
            // btnClear_2
            // 
            this.btnClear_2.Location = new System.Drawing.Point(154, 100);
            this.btnClear_2.Name = "btnClear_2";
            this.btnClear_2.Size = new System.Drawing.Size(72, 38);
            this.btnClear_2.TabIndex = 19;
            this.btnClear_2.Text = "Clear";
            this.btnClear_2.UseVisualStyleBackColor = true;
            this.btnClear_2.Click += new System.EventHandler(this.btnClear_2_Click);
            // 
            // btnSearch_2
            // 
            this.btnSearch_2.Location = new System.Drawing.Point(48, 100);
            this.btnSearch_2.Name = "btnSearch_2";
            this.btnSearch_2.Size = new System.Drawing.Size(81, 40);
            this.btnSearch_2.TabIndex = 13;
            this.btnSearch_2.Text = "Search";
            this.btnSearch_2.UseVisualStyleBackColor = true;
            this.btnSearch_2.Click += new System.EventHandler(this.btnSearch_2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear_1);
            this.groupBox2.Controls.Add(this.btnSearch_1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.productNumTextBox);
            this.groupBox2.Controls.Add(this.productDesTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 148);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Search";
            // 
            // btnClear_1
            // 
            this.btnClear_1.Location = new System.Drawing.Point(238, 100);
            this.btnClear_1.Name = "btnClear_1";
            this.btnClear_1.Size = new System.Drawing.Size(72, 38);
            this.btnClear_1.TabIndex = 18;
            this.btnClear_1.Text = "Clear";
            this.btnClear_1.UseVisualStyleBackColor = true;
            this.btnClear_1.Click += new System.EventHandler(this.btnClear_1_Click);
            // 
            // btnSearch_1
            // 
            this.btnSearch_1.Location = new System.Drawing.Point(132, 100);
            this.btnSearch_1.Name = "btnSearch_1";
            this.btnSearch_1.Size = new System.Drawing.Size(81, 40);
            this.btnSearch_1.TabIndex = 8;
            this.btnSearch_1.Text = "Search";
            this.btnSearch_1.UseVisualStyleBackColor = true;
            this.btnSearch_1.Click += new System.EventHandler(this.btnSearch_1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear_3);
            this.groupBox3.Controls.Add(this.maxTextBox);
            this.groupBox3.Controls.Add(this.minTextBox);
            this.groupBox3.Controls.Add(this.btnSearch_3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1065, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 148);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Price Search";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(174, 58);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 26);
            this.maxTextBox.TabIndex = 16;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(30, 58);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 26);
            this.minTextBox.TabIndex = 15;
            // 
            // btnSearch_3
            // 
            this.btnSearch_3.Location = new System.Drawing.Point(63, 100);
            this.btnSearch_3.Name = "btnSearch_3";
            this.btnSearch_3.Size = new System.Drawing.Size(81, 40);
            this.btnSearch_3.TabIndex = 14;
            this.btnSearch_3.Text = "Search";
            this.btnSearch_3.UseVisualStyleBackColor = true;
            this.btnSearch_3.Click += new System.EventHandler(this.btnSearch_3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Maximum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Minimum:";
            // 
            // outputListBox2
            // 
            this.outputListBox2.FormattingEnabled = true;
            this.outputListBox2.ItemHeight = 20;
            this.outputListBox2.Location = new System.Drawing.Point(599, 166);
            this.outputListBox2.Name = "outputListBox2";
            this.outputListBox2.Size = new System.Drawing.Size(375, 264);
            this.outputListBox2.TabIndex = 16;
            // 
            // outputListBox3
            // 
            this.outputListBox3.FormattingEnabled = true;
            this.outputListBox3.ItemHeight = 20;
            this.outputListBox3.Location = new System.Drawing.Point(1065, 169);
            this.outputListBox3.Name = "outputListBox3";
            this.outputListBox3.Size = new System.Drawing.Size(375, 264);
            this.outputListBox3.TabIndex = 17;
            // 
            // btnClear_3
            // 
            this.btnClear_3.Location = new System.Drawing.Point(160, 100);
            this.btnClear_3.Name = "btnClear_3";
            this.btnClear_3.Size = new System.Drawing.Size(72, 38);
            this.btnClear_3.TabIndex = 20;
            this.btnClear_3.Text = "Clear";
            this.btnClear_3.UseVisualStyleBackColor = true;
            this.btnClear_3.Click += new System.EventHandler(this.btnClear_3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 743);
            this.Controls.Add(this.outputListBox3);
            this.Controls.Add(this.outputListBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox productNumTextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.TextBox productDesTextBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox moreTextBox;
        private System.Windows.Forms.TextBox lessTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox outputListBox2;
        private System.Windows.Forms.ListBox outputListBox3;
        private System.Windows.Forms.Button btnSearch_2;
        private System.Windows.Forms.Button btnSearch_3;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Button btnClear_1;
        private System.Windows.Forms.Button btnClear_2;
        private System.Windows.Forms.Button btnClear_3;
    }
}

