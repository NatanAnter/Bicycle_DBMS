
namespace Bicycle_Forms
{
    partial class AccountWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountWin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarcodeText = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGrid_Account = new System.Windows.Forms.DataGridView();
            this.btnShowItems = new System.Windows.Forms.Button();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDayReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.singInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepairs = new System.Windows.Forms.Button();
            this.TotalPayment = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnCancelWholeSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Account)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarcodeText
            // 
            resources.ApplyResources(this.BarcodeText, "BarcodeText");
            this.BarcodeText.Name = "BarcodeText";
            this.BarcodeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeText_KeyPress);
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGrid_Account
            // 
            resources.ApplyResources(this.dataGrid_Account, "dataGrid_Account");
            this.dataGrid_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Account.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Account.Name = "dataGrid_Account";
            this.dataGrid_Account.ReadOnly = true;
            this.dataGrid_Account.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGrid_Account.RowTemplate.Height = 30;
            // 
            // btnShowItems
            // 
            resources.ApplyResources(this.btnShowItems, "btnShowItems");
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.BtnShowItems_Click);
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.newDayReportToolStripMenuItem,
            this.viewReportsToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            resources.ApplyResources(this.appToolStripMenuItem, "appToolStripMenuItem");
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // newDayReportToolStripMenuItem
            // 
            this.newDayReportToolStripMenuItem.Name = "newDayReportToolStripMenuItem";
            resources.ApplyResources(this.newDayReportToolStripMenuItem, "newDayReportToolStripMenuItem");
            this.newDayReportToolStripMenuItem.Click += new System.EventHandler(this.newDayReportToolStripMenuItem_Click);
            // 
            // viewReportsToolStripMenuItem
            // 
            this.viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            resources.ApplyResources(this.viewReportsToolStripMenuItem, "viewReportsToolStripMenuItem");
            this.viewReportsToolStripMenuItem.Click += new System.EventHandler(this.viewReportsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            resources.ApplyResources(this.translateToolStripMenuItem, "translateToolStripMenuItem");
            this.translateToolStripMenuItem.Click += new System.EventHandler(this.translateToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.translateToolStripMenuItem,
            this.singInToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // singInToolStripMenuItem
            // 
            this.singInToolStripMenuItem.Name = "singInToolStripMenuItem";
            resources.ApplyResources(this.singInToolStripMenuItem, "singInToolStripMenuItem");
            this.singInToolStripMenuItem.Click += new System.EventHandler(this.singInToolStripMenuItem_Click);
            // 
            // btnRepairs
            // 
            resources.ApplyResources(this.btnRepairs, "btnRepairs");
            this.btnRepairs.Name = "btnRepairs";
            this.btnRepairs.UseVisualStyleBackColor = true;
            this.btnRepairs.Click += new System.EventHandler(this.btnRepairs_Click);
            // 
            // TotalPayment
            // 
            resources.ApplyResources(this.TotalPayment, "TotalPayment");
            this.TotalPayment.Name = "TotalPayment";
            // 
            // btnEnd
            // 
            resources.ApplyResources(this.btnEnd, "btnEnd");
            this.btnEnd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // btnCancelWholeSale
            // 
            resources.ApplyResources(this.btnCancelWholeSale, "btnCancelWholeSale");
            this.btnCancelWholeSale.BackColor = System.Drawing.Color.Red;
            this.btnCancelWholeSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelWholeSale.Name = "btnCancelWholeSale";
            this.btnCancelWholeSale.UseVisualStyleBackColor = false;
            this.btnCancelWholeSale.Click += new System.EventHandler(this.BtnCancelWholeSale_Click);
            // 
            // AccountWin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelWholeSale);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.TotalPayment);
            this.Controls.Add(this.btnRepairs);
            this.Controls.Add(this.BarcodeText);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGrid_Account);
            this.Controls.Add(this.btnShowItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountWin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountWin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Account)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BarcodeText;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGrid_Account;
        private System.Windows.Forms.Button btnShowItems;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnRepairs;
        private System.Windows.Forms.Label TotalPayment;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnCancelWholeSale;
        private System.Windows.Forms.ToolStripMenuItem newDayReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singInToolStripMenuItem;
    }
}