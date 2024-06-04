
namespace Bicycle_Forms
{
    partial class DataGridItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_Item = new System.Windows.Forms.DataGridView();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showAllSaleDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startingInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchCostStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serchMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerchBox = new System.Windows.Forms.TextBox();
            this.seeSalesDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Item)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_Item
            // 
            this.dataGrid_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_Item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Item.Location = new System.Drawing.Point(12, 32);
            this.dataGrid_Item.Name = "dataGrid_Item";
            this.dataGrid_Item.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Item.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Item.RowTemplate.Height = 30;
            this.dataGrid_Item.Size = new System.Drawing.Size(807, 624);
            this.dataGrid_Item.TabIndex = 4;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteItem.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteItem.Location = new System.Drawing.Point(689, 662);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(130, 50);
            this.btnDeleteItem.TabIndex = 9;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsert.Location = new System.Drawing.Point(12, 662);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(130, 50);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(148, 662);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 50);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllSaleDaysToolStripMenuItem,
            this.generateNewItemToolStripMenuItem,
            this.serchToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toOrderToolStripMenuItem,
            this.allItemsToolStripMenuItem,
            this.seeSalesDayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 29);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showAllSaleDaysToolStripMenuItem
            // 
            this.showAllSaleDaysToolStripMenuItem.Name = "showAllSaleDaysToolStripMenuItem";
            this.showAllSaleDaysToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.showAllSaleDaysToolStripMenuItem.Text = "Show Sales";
            this.showAllSaleDaysToolStripMenuItem.Click += new System.EventHandler(this.showAllSaleDaysToolStripMenuItem_Click);
            // 
            // generateNewItemToolStripMenuItem
            // 
            this.generateNewItemToolStripMenuItem.Name = "generateNewItemToolStripMenuItem";
            this.generateNewItemToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.generateNewItemToolStripMenuItem.Text = "Generate Item";
            this.generateNewItemToolStripMenuItem.Click += new System.EventHandler(this.generateNewItemToolStripMenuItem_Click);
            // 
            // serchToolStripMenuItem
            // 
            this.serchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serchBarcodeToolStripMenuItem,
            this.serchNameToolStripMenuItem,
            this.serchPriceToolStripMenuItem,
            this.serchCostStripMenuItem,
            this.serchAmountToolStripMenuItem,
            this.serchMinToolStripMenuItem});
            this.serchToolStripMenuItem.Name = "serchToolStripMenuItem";
            this.serchToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.serchToolStripMenuItem.Text = "Serch";
            // 
            // serchBarcodeToolStripMenuItem
            // 
            this.serchBarcodeToolStripMenuItem.Name = "serchBarcodeToolStripMenuItem";
            this.serchBarcodeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.serchBarcodeToolStripMenuItem.Text = "serch barcode";
            this.serchBarcodeToolStripMenuItem.Click += new System.EventHandler(this.serchBarcodeToolStripMenuItem_Click);
            // 
            // serchNameToolStripMenuItem
            // 
            this.serchNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startingInToolStripMenuItem,
            this.hasToolStripMenuItem});
            this.serchNameToolStripMenuItem.Name = "serchNameToolStripMenuItem";
            this.serchNameToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.serchNameToolStripMenuItem.Text = "serch name";
            // 
            // startingInToolStripMenuItem
            // 
            this.startingInToolStripMenuItem.Name = "startingInToolStripMenuItem";
            this.startingInToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.startingInToolStripMenuItem.Text = "starting in";
            this.startingInToolStripMenuItem.Click += new System.EventHandler(this.startingInToolStripMenuItem_Click);
            // 
            // hasToolStripMenuItem
            // 
            this.hasToolStripMenuItem.Name = "hasToolStripMenuItem";
            this.hasToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.hasToolStripMenuItem.Text = "has";
            this.hasToolStripMenuItem.Click += new System.EventHandler(this.hasToolStripMenuItem_Click);
            // 
            // serchPriceToolStripMenuItem
            // 
            this.serchPriceToolStripMenuItem.Name = "serchPriceToolStripMenuItem";
            this.serchPriceToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.serchPriceToolStripMenuItem.Text = "serch price";
            this.serchPriceToolStripMenuItem.Click += new System.EventHandler(this.serchPriceToolStripMenuItem_Click);
            // 
            // serchCostStripMenuItem
            // 
            this.serchCostStripMenuItem.Name = "serchCostStripMenuItem";
            this.serchCostStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.serchCostStripMenuItem.Text = "serch cost";
            this.serchCostStripMenuItem.Click += new System.EventHandler(this.serchCostStripMenuItem_Click);
            // 
            // serchAmountToolStripMenuItem
            // 
            this.serchAmountToolStripMenuItem.Name = "serchAmountToolStripMenuItem";
            this.serchAmountToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.serchAmountToolStripMenuItem.Text = "serch amount";
            this.serchAmountToolStripMenuItem.Click += new System.EventHandler(this.serchAmountToolStripMenuItem_Click);
            // 
            // serchMinToolStripMenuItem
            // 
            this.serchMinToolStripMenuItem.Name = "serchMinToolStripMenuItem";
            this.serchMinToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.serchMinToolStripMenuItem.Text = "serch min";
            this.serchMinToolStripMenuItem.Click += new System.EventHandler(this.serchMinToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toOrderToolStripMenuItem
            // 
            this.toOrderToolStripMenuItem.Name = "toOrderToolStripMenuItem";
            this.toOrderToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.toOrderToolStripMenuItem.Text = "To order";
            this.toOrderToolStripMenuItem.Click += new System.EventHandler(this.toOrderToolStripMenuItem_Click);
            // 
            // allItemsToolStripMenuItem
            // 
            this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
            this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.allItemsToolStripMenuItem.Text = "All items";
            this.allItemsToolStripMenuItem.Click += new System.EventHandler(this.allItemsToolStripMenuItem_Click);
            // 
            // SerchBox
            // 
            this.SerchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SerchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SerchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerchBox.Location = new System.Drawing.Point(643, 3);
            this.SerchBox.Multiline = true;
            this.SerchBox.Name = "SerchBox";
            this.SerchBox.Size = new System.Drawing.Size(176, 21);
            this.SerchBox.TabIndex = 12;
            this.SerchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noGerash);
            // 
            // seeSalesDayToolStripMenuItem
            // 
            this.seeSalesDayToolStripMenuItem.Name = "seeSalesDayToolStripMenuItem";
            this.seeSalesDayToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.seeSalesDayToolStripMenuItem.Text = "See Sales day";
            this.seeSalesDayToolStripMenuItem.Click += new System.EventHandler(this.seeSalesDayToolStripMenuItem_Click);
            // 
            // DataGridItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 724);
            this.Controls.Add(this.SerchBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGrid_Item);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataGridItem";
            this.Text = "Items List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Item)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Item;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAllSaleDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchBarcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startingInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serchAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serchMinToolStripMenuItem;
        private System.Windows.Forms.TextBox SerchBox;
        private System.Windows.Forms.ToolStripMenuItem serchCostStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeSalesDayToolStripMenuItem;
    }
}