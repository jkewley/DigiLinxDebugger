namespace NetStreamsDebugger {
    partial class ManageFilters {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFilters));
            this.dgvwFilters = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patternDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInclude = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colExclude = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.regularExpressionsHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatIsThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).BeginInit();
            this.theStatusStrip.SuspendLayout();
            this.pnlHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvwFilters
            // 
            this.dgvwFilters.AllowUserToOrderColumns = true;
            this.dgvwFilters.AutoGenerateColumns = false;
            this.dgvwFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwFilters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.patternDataGridViewTextBoxColumn,
            this.colInclude,
            this.colExclude});
            this.dgvwFilters.DataSource = this.filterBindingSource;
            this.dgvwFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvwFilters.Location = new System.Drawing.Point(0, 0);
            this.dgvwFilters.MultiSelect = false;
            this.dgvwFilters.Name = "dgvwFilters";
            this.dgvwFilters.RowHeadersWidth = 28;
            this.dgvwFilters.Size = new System.Drawing.Size(597, 267);
            this.dgvwFilters.TabIndex = 0;
            this.dgvwFilters.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ValidateCellValue);
            this.dgvwFilters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegexEdited);
            this.dgvwFilters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValidateCellValue);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // patternDataGridViewTextBoxColumn
            // 
            this.patternDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patternDataGridViewTextBoxColumn.DataPropertyName = "Pattern";
            this.patternDataGridViewTextBoxColumn.HeaderText = "Pattern";
            this.patternDataGridViewTextBoxColumn.Name = "patternDataGridViewTextBoxColumn";
            // 
            // colInclude
            // 
            this.colInclude.DataPropertyName = "Include";
            this.colInclude.HeaderText = "Include";
            this.colInclude.Name = "colInclude";
            this.colInclude.ToolTipText = "Select more than one included filter to accept messages with different signatures" +
                "";
            this.colInclude.Width = 60;
            // 
            // colExclude
            // 
            this.colExclude.DataPropertyName = "Exclude";
            this.colExclude.HeaderText = "Exclude";
            this.colExclude.Name = "colExclude";
            this.colExclude.ToolTipText = "Exclude certain messages";
            this.colExclude.Width = 60;
            // 
            // filterBindingSource
            // 
            this.filterBindingSource.AllowNew = true;
            this.filterBindingSource.DataSource = typeof(NetStreamsDebugger.Support.Filter);
            // 
            // theStatusStrip
            // 
            this.theStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.theStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.theStatusStrip.Location = new System.Drawing.Point(0, 267);
            this.theStatusStrip.Name = "theStatusStrip";
            this.theStatusStrip.Size = new System.Drawing.Size(597, 22);
            this.theStatusStrip.TabIndex = 1;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularExpressionsHelpToolStripMenuItem,
            this.whatIsThisToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // regularExpressionsHelpToolStripMenuItem
            // 
            this.regularExpressionsHelpToolStripMenuItem.Name = "regularExpressionsHelpToolStripMenuItem";
            this.regularExpressionsHelpToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.regularExpressionsHelpToolStripMenuItem.Text = "Regular Expressions Help";
            this.regularExpressionsHelpToolStripMenuItem.Click += new System.EventHandler(this.regularExpressionsHelpToolStripMenuItem_Click);
            // 
            // whatIsThisToolStripMenuItem
            // 
            this.whatIsThisToolStripMenuItem.Name = "whatIsThisToolStripMenuItem";
            this.whatIsThisToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.whatIsThisToolStripMenuItem.Text = "What is This?";
            this.whatIsThisToolStripMenuItem.Click += new System.EventHandler(this.whatIsThisToolStripMenuItem_Click);
            // 
            // pnlHelp
            // 
            this.pnlHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHelp.BackgroundImage = global::NetStreamsDebugger.Properties.Resources.OptionsBackground;
            this.pnlHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHelp.Controls.Add(this.linkLabel1);
            this.pnlHelp.Controls.Add(this.label1);
            this.pnlHelp.Controls.Add(this.lblIntro);
            this.pnlHelp.Location = new System.Drawing.Point(77, 50);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(428, 206);
            this.pnlHelp.TabIndex = 3;
            this.pnlHelp.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(381, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Close";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Using Filters";
            // 
            // lblIntro
            // 
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(3, 37);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(422, 169);
            this.lblIntro.TabIndex = 3;
            this.lblIntro.Text = resources.GetString("lblIntro.Text");
            // 
            // butClose
            // 
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.butClose.Location = new System.Drawing.Point(491, 268);
            this.butClose.Margin = new System.Windows.Forms.Padding(0);
            this.butClose.Name = "butClose";
            this.butClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butClose.Size = new System.Drawing.Size(78, 21);
            this.butClose.TabIndex = 4;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = false;
            // 
            // ManageFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(597, 289);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.pnlHelp);
            this.Controls.Add(this.dgvwFilters);
            this.Controls.Add(this.theStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageFilters";
            this.Text = "Custom Filters";
            ((System.ComponentModel.ISupportInitialize)(this.dgvwFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterBindingSource)).EndInit();
            this.theStatusStrip.ResumeLayout(false);
            this.theStatusStrip.PerformLayout();
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource filterBindingSource;
        private System.Windows.Forms.DataGridView dgvwFilters;
        private System.Windows.Forms.StatusStrip theStatusStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem regularExpressionsHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatIsThisToolStripMenuItem;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patternDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInclude;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExclude;
        private System.Windows.Forms.Button butClose;
    }
}