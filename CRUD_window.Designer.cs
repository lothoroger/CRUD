namespace BuyProduct
{
    partial class CRUD_window
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
            this.textID = new System.Windows.Forms.TextBox();
            this.IDL = new System.Windows.Forms.Label();
            this.FullNameL = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.DescriptionL = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Image = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productStoreDataSet = new BuyProduct.ProductStoreDataSet();
            this.productTableTableAdapter = new BuyProduct.ProductStoreDataSetTableAdapters.ProductTableTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(193, 49);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(293, 29);
            this.textID.TabIndex = 0;
            // 
            // IDL
            // 
            this.IDL.AutoSize = true;
            this.IDL.Location = new System.Drawing.Point(57, 49);
            this.IDL.Name = "IDL";
            this.IDL.Size = new System.Drawing.Size(37, 25);
            this.IDL.TabIndex = 1;
            this.IDL.Text = "ID:";
            // 
            // FullNameL
            // 
            this.FullNameL.AutoSize = true;
            this.FullNameL.Location = new System.Drawing.Point(57, 94);
            this.FullNameL.Name = "FullNameL";
            this.FullNameL.Size = new System.Drawing.Size(70, 25);
            this.FullNameL.TabIndex = 4;
            this.FullNameL.Text = "Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(193, 94);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(293, 29);
            this.textName.TabIndex = 3;
            // 
            // DescriptionL
            // 
            this.DescriptionL.AutoSize = true;
            this.DescriptionL.Location = new System.Drawing.Point(57, 165);
            this.DescriptionL.Name = "DescriptionL";
            this.DescriptionL.Size = new System.Drawing.Size(115, 25);
            this.DescriptionL.TabIndex = 6;
            this.DescriptionL.Text = "Description:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(193, 165);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(293, 158);
            this.textDescription.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(62, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Image
            // 
            this.BTN_Image.Location = new System.Drawing.Point(207, 572);
            this.BTN_Image.Name = "BTN_Image";
            this.BTN_Image.Size = new System.Drawing.Size(122, 48);
            this.BTN_Image.TabIndex = 10;
            this.BTN_Image.Text = "/////";
            this.BTN_Image.UseVisualStyleBackColor = true;
            this.BTN_Image.Click += new System.EventHandler(this.BTN_Image_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(545, 49);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(81, 44);
            this.F.TabIndex = 11;
            this.F.Text = "Find";
            this.F.UseVisualStyleBackColor = true;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(545, 217);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(130, 54);
            this.btn_Insert.TabIndex = 13;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(545, 329);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 50);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.AllowDrop = true;
            this.btn_Update.Location = new System.Drawing.Point(545, 277);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(130, 46);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.productImageDataGridViewImageColumn,
            this.linkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(816, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(906, 717);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // productImageDataGridViewImageColumn
            // 
            this.productImageDataGridViewImageColumn.DataPropertyName = "ProductImage";
            this.productImageDataGridViewImageColumn.HeaderText = "ProductImage";
            this.productImageDataGridViewImageColumn.Name = "productImageDataGridViewImageColumn";
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "ProductTable";
            this.productTableBindingSource.DataSource = this.productStoreDataSet;
            // 
            // productStoreDataSet
            // 
            this.productStoreDataSet.DataSetName = "ProductStoreDataSet";
            this.productStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableTableAdapter
            // 
            this.productTableTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fillBy1ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 757);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1859, 33);
            this.fillBy1ToolStrip.TabIndex = 0;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // CRUD_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1859, 790);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.F);
            this.Controls.Add(this.BTN_Image);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DescriptionL);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.FullNameL);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.IDL);
            this.Controls.Add(this.textID);
            this.Name = "CRUD_window";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label IDL;
        private System.Windows.Forms.Label FullNameL;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label DescriptionL;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Image;
        private ProductStoreDataSet productStoreDataSet;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private ProductStoreDataSetTableAdapters.ProductTableTableAdapter productTableTableAdapter;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}

