namespace WinFormAssignment3._4._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            coffeeBindingSource = new BindingSource(components);
            isDecafDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            varietyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeozDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packageTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            temperatureDegFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { isDecafDataGridViewCheckBoxColumn, varietyDataGridViewTextBoxColumn, roastDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, bevNameDataGridViewTextBoxColumn, sizeozDataGridViewTextBoxColumn, packageTypeDataGridViewTextBoxColumn, temperatureDegFDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = coffeeBindingSource;
            dataGridView1.Location = new Point(85, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(946, 310);
            dataGridView1.TabIndex = 0;
            // 
            // coffeeBindingSource
            // 
            coffeeBindingSource.DataSource = typeof(Coffee);
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            // 
            // varietyDataGridViewTextBoxColumn
            // 
            varietyDataGridViewTextBoxColumn.DataPropertyName = "Variety";
            varietyDataGridViewTextBoxColumn.HeaderText = "Variety";
            varietyDataGridViewTextBoxColumn.Name = "varietyDataGridViewTextBoxColumn";
            // 
            // roastDataGridViewTextBoxColumn
            // 
            roastDataGridViewTextBoxColumn.DataPropertyName = "Roast";
            roastDataGridViewTextBoxColumn.HeaderText = "Roast";
            roastDataGridViewTextBoxColumn.Name = "roastDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bevNameDataGridViewTextBoxColumn
            // 
            bevNameDataGridViewTextBoxColumn.DataPropertyName = "BevName";
            bevNameDataGridViewTextBoxColumn.HeaderText = "BevName";
            bevNameDataGridViewTextBoxColumn.Name = "bevNameDataGridViewTextBoxColumn";
            // 
            // sizeozDataGridViewTextBoxColumn
            // 
            sizeozDataGridViewTextBoxColumn.DataPropertyName = "Sizeoz";
            sizeozDataGridViewTextBoxColumn.HeaderText = "Sizeoz";
            sizeozDataGridViewTextBoxColumn.Name = "sizeozDataGridViewTextBoxColumn";
            // 
            // packageTypeDataGridViewTextBoxColumn
            // 
            packageTypeDataGridViewTextBoxColumn.DataPropertyName = "PackageType";
            packageTypeDataGridViewTextBoxColumn.HeaderText = "PackageType";
            packageTypeDataGridViewTextBoxColumn.Name = "packageTypeDataGridViewTextBoxColumn";
            // 
            // temperatureDegFDataGridViewTextBoxColumn
            // 
            temperatureDegFDataGridViewTextBoxColumn.DataPropertyName = "TemperatureDegF";
            temperatureDegFDataGridViewTextBoxColumn.HeaderText = "TemperatureDegF";
            temperatureDegFDataGridViewTextBoxColumn.Name = "temperatureDegFDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn varietyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roastDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeozDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperatureDegFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private BindingSource coffeeBindingSource;
    }
}
