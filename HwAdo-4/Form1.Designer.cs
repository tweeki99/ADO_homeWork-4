namespace HwAdo_4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesDataSet = new HwAdo_4.SalesDataSet();
            this.buyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersTableAdapter = new HwAdo_4.SalesDataSetTableAdapters.BuyersTableAdapter();
            this.fKSalesBuyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new HwAdo_4.SalesDataSetTableAdapters.SalesTableAdapter();
            this.buyersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buyersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.salesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesBuyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(549, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "SalesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyersBindingSource
            // 
            this.buyersBindingSource.DataMember = "Buyers";
            this.buyersBindingSource.DataSource = this.salesDataSet;
            // 
            // buyersTableAdapter
            // 
            this.buyersTableAdapter.ClearBeforeFill = true;
            // 
            // fKSalesBuyersBindingSource
            // 
            this.fKSalesBuyersBindingSource.DataMember = "FK_Sales_Buyers";
            this.fKSalesBuyersBindingSource.DataSource = this.buyersBindingSource;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // buyersBindingSource1
            // 
            this.buyersBindingSource1.DataMember = "Buyers";
            this.buyersBindingSource1.DataSource = this.salesDataSet;
            // 
            // buyersBindingSource2
            // 
            this.buyersBindingSource2.DataMember = "Buyers";
            this.buyersBindingSource2.DataSource = this.salesDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // salesDataSetBindingSource
            // 
            this.salesDataSetBindingSource.DataSource = this.salesDataSet;
            this.salesDataSetBindingSource.Position = 0;
            // 
            // buyersBindingSource3
            // 
            this.buyersBindingSource3.DataMember = "Buyers";
            this.buyersBindingSource3.DataSource = this.salesDataSetBindingSource;
            // 
            // salesDataSetBindingSource1
            // 
            this.salesDataSetBindingSource1.DataSource = this.salesDataSet;
            this.salesDataSetBindingSource1.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesBuyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalesDataSet salesDataSet;
        private System.Windows.Forms.BindingSource buyersBindingSource;
        private SalesDataSetTableAdapters.BuyersTableAdapter buyersTableAdapter;
        private System.Windows.Forms.BindingSource fKSalesBuyersBindingSource;
        private SalesDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource buyersBindingSource2;
        private System.Windows.Forms.BindingSource buyersBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource salesDataSetBindingSource;
        private System.Windows.Forms.BindingSource buyersBindingSource3;
        private System.Windows.Forms.BindingSource salesDataSetBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}

