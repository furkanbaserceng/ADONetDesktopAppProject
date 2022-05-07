namespace ADONetProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblStockAmountAdd = new System.Windows.Forms.Label();
            this.tbxProductStockAmountAdd = new System.Windows.Forms.TextBox();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.tbxProductUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.gbxProductUpdateAndDelete = new System.Windows.Forms.GroupBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.tbxProductIdUpdate = new System.Windows.Forms.TextBox();
            this.lblIdUpdate = new System.Windows.Forms.Label();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxProductStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxProductUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdateAndDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(8, 22);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwProducts.RowTemplate.Height = 25;
            this.dgwProducts.Size = new System.Drawing.Size(994, 244);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.lblStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductStockAmountAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblNameAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.btnProductAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(159, 284);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(348, 231);
            this.gbxProductAdd.TabIndex = 1;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Product Add";
            // 
            // lblStockAmountAdd
            // 
            this.lblStockAmountAdd.AutoSize = true;
            this.lblStockAmountAdd.Location = new System.Drawing.Point(11, 115);
            this.lblStockAmountAdd.Name = "lblStockAmountAdd";
            this.lblStockAmountAdd.Size = new System.Drawing.Size(86, 15);
            this.lblStockAmountAdd.TabIndex = 6;
            this.lblStockAmountAdd.Text = "Stock Amount:";
            // 
            // tbxProductStockAmountAdd
            // 
            this.tbxProductStockAmountAdd.Location = new System.Drawing.Point(103, 112);
            this.tbxProductStockAmountAdd.Name = "tbxProductStockAmountAdd";
            this.tbxProductStockAmountAdd.Size = new System.Drawing.Size(239, 23);
            this.tbxProductStockAmountAdd.TabIndex = 5;
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(36, 86);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(61, 15);
            this.lblUnitPriceAdd.TabIndex = 4;
            this.lblUnitPriceAdd.Text = "Unit Price:";
            // 
            // tbxProductUnitPriceAdd
            // 
            this.tbxProductUnitPriceAdd.Location = new System.Drawing.Point(103, 83);
            this.tbxProductUnitPriceAdd.Name = "tbxProductUnitPriceAdd";
            this.tbxProductUnitPriceAdd.Size = new System.Drawing.Size(239, 23);
            this.tbxProductUnitPriceAdd.TabIndex = 3;
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(45, 57);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(42, 15);
            this.lblNameAdd.TabIndex = 2;
            this.lblNameAdd.Text = "Name:";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(103, 54);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(239, 23);
            this.tbxProductNameAdd.TabIndex = 1;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(103, 155);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(100, 38);
            this.btnProductAdd.TabIndex = 0;
            this.btnProductAdd.Text = "Add";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // gbxProductUpdateAndDelete
            // 
            this.gbxProductUpdateAndDelete.Controls.Add(this.btnProductDelete);
            this.gbxProductUpdateAndDelete.Controls.Add(this.tbxProductIdUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.lblIdUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.lblStockAmountUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.tbxProductStockAmountUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.tbxProductUnitPriceUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.lblNameUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdateAndDelete.Controls.Add(this.btnProductUpdate);
            this.gbxProductUpdateAndDelete.Location = new System.Drawing.Point(527, 284);
            this.gbxProductUpdateAndDelete.Name = "gbxProductUpdateAndDelete";
            this.gbxProductUpdateAndDelete.Size = new System.Drawing.Size(348, 231);
            this.gbxProductUpdateAndDelete.TabIndex = 2;
            this.gbxProductUpdateAndDelete.TabStop = false;
            this.gbxProductUpdateAndDelete.Text = "Product Update and Delete";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(242, 155);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(100, 38);
            this.btnProductDelete.TabIndex = 9;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // tbxProductIdUpdate
            // 
            this.tbxProductIdUpdate.Location = new System.Drawing.Point(103, 25);
            this.tbxProductIdUpdate.Name = "tbxProductIdUpdate";
            this.tbxProductIdUpdate.Size = new System.Drawing.Size(239, 23);
            this.tbxProductIdUpdate.TabIndex = 8;
            // 
            // lblIdUpdate
            // 
            this.lblIdUpdate.AutoSize = true;
            this.lblIdUpdate.Location = new System.Drawing.Point(77, 28);
            this.lblIdUpdate.Name = "lblIdUpdate";
            this.lblIdUpdate.Size = new System.Drawing.Size(20, 15);
            this.lblIdUpdate.TabIndex = 7;
            this.lblIdUpdate.Text = "Id:";
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(11, 115);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(86, 15);
            this.lblStockAmountUpdate.TabIndex = 6;
            this.lblStockAmountUpdate.Text = "Stock Amount:";
            // 
            // tbxProductStockAmountUpdate
            // 
            this.tbxProductStockAmountUpdate.Location = new System.Drawing.Point(103, 112);
            this.tbxProductStockAmountUpdate.Name = "tbxProductStockAmountUpdate";
            this.tbxProductStockAmountUpdate.Size = new System.Drawing.Size(239, 23);
            this.tbxProductStockAmountUpdate.TabIndex = 5;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(36, 86);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(61, 15);
            this.lblUnitPriceUpdate.TabIndex = 4;
            this.lblUnitPriceUpdate.Text = "Unit Price:";
            // 
            // tbxProductUnitPriceUpdate
            // 
            this.tbxProductUnitPriceUpdate.Location = new System.Drawing.Point(103, 83);
            this.tbxProductUnitPriceUpdate.Name = "tbxProductUnitPriceUpdate";
            this.tbxProductUnitPriceUpdate.Size = new System.Drawing.Size(239, 23);
            this.tbxProductUnitPriceUpdate.TabIndex = 3;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(55, 57);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(42, 15);
            this.lblNameUpdate.TabIndex = 2;
            this.lblNameUpdate.Text = "Name:";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(103, 54);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(239, 23);
            this.tbxProductNameUpdate.TabIndex = 1;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(103, 155);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(100, 38);
            this.btnProductUpdate.TabIndex = 0;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1011, 564);
            this.Controls.Add(this.gbxProductUpdateAndDelete);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.dgwProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdoNetSimple";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdateAndDelete.ResumeLayout(false);
            this.gbxProductUpdateAndDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxProductAdd;
        private Label lblUnitPriceAdd;
        private TextBox tbxProductUnitPriceAdd;
        private Label lblNameAdd;
        private TextBox tbxProductNameAdd;
        private Button btnProductAdd;
        private Label lblStockAmountAdd;
        private TextBox tbxProductStockAmountAdd;
        private GroupBox gbxProductUpdateAndDelete;
        private Label lblStockAmountUpdate;
        private TextBox tbxProductStockAmountUpdate;
        private Label lblUnitPriceUpdate;
        private TextBox tbxProductUnitPriceUpdate;
        private Label lblNameUpdate;
        private TextBox tbxProductNameUpdate;
        private Button btnProductUpdate;
        private TextBox tbxProductIdUpdate;
        private Label lblIdUpdate;
        private Button btnProductDelete;
    }
}