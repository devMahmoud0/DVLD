namespace DVLD.People
{
    partial class frmListPeople
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new ReaLTaiizor.Controls.MaterialButton();
            this.btnShowDetails = new ReaLTaiizor.Controls.MaterialButton();
            this.btnAddNewPerson = new ReaLTaiizor.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtSearch = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cbFilterBy = new ReaLTaiizor.Controls.MaterialComboBox();
            this.btnDelete = new ReaLTaiizor.Controls.MaterialButton();
            this.dgvAllPeople = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.formContextMenuStrip1 = new ReaLTaiizor.Controls.FormContextMenuStrip();
            this.tsmiShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tttadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).BeginInit();
            this.formContextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.bigLabel1.Location = new System.Drawing.Point(-206, -163);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(259, 45);
            this.bigLabel1.TabIndex = 10;
            this.bigLabel1.Text = "Manage People";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 9;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnEdit, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnShowDetails, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddNewPerson, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mtxtSearch, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbFilterBy, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 6, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 140);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1352, 54);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSize = false;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEdit.Depth = 0;
            this.btnEdit.HighEmphasis = true;
            this.btnEdit.Icon = global::DVLD.Properties.Resources.edit;
            this.btnEdit.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEdit.Location = new System.Drawing.Point(1152, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEdit.Size = new System.Drawing.Size(88, 36);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEdit.UseAccentColor = false;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDetails.AutoSize = false;
            this.btnShowDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDetails.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowDetails.Depth = 0;
            this.btnShowDetails.HighEmphasis = true;
            this.btnShowDetails.Icon = global::DVLD.Properties.Resources.ShowDetails;
            this.btnShowDetails.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnShowDetails.Location = new System.Drawing.Point(988, 6);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowDetails.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowDetails.Size = new System.Drawing.Size(156, 36);
            this.btnShowDetails.TabIndex = 9;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowDetails.UseAccentColor = false;
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.AutoSize = false;
            this.btnAddNewPerson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewPerson.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddNewPerson.Depth = 0;
            this.btnAddNewPerson.HighEmphasis = true;
            this.btnAddNewPerson.Icon = global::DVLD.Properties.Resources.add_person;
            this.btnAddNewPerson.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnAddNewPerson.Location = new System.Drawing.Point(799, 6);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewPerson.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddNewPerson.Size = new System.Drawing.Size(180, 36);
            this.btnAddNewPerson.TabIndex = 10;
            this.btnAddNewPerson.Text = "Add New Person";
            this.btnAddNewPerson.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNewPerson.UseAccentColor = false;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter By:";
            // 
            // mtxtSearch
            // 
            this.mtxtSearch.AllowPromptAsInput = true;
            this.mtxtSearch.AnimateReadOnly = false;
            this.mtxtSearch.AsciiOnly = false;
            this.mtxtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtSearch.BeepOnError = false;
            this.mtxtSearch.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSearch.Depth = 0;
            this.mtxtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtSearch.HidePromptOnLeave = false;
            this.mtxtSearch.HideSelection = true;
            this.mtxtSearch.Hint = "Type to search";
            this.mtxtSearch.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtxtSearch.LeadingIcon = null;
            this.mtxtSearch.Location = new System.Drawing.Point(308, 3);
            this.mtxtSearch.Mask = "";
            this.mtxtSearch.MaxLength = 32767;
            this.mtxtSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.mtxtSearch.Name = "mtxtSearch";
            this.mtxtSearch.PasswordChar = '\0';
            this.mtxtSearch.PrefixSuffixText = null;
            this.mtxtSearch.PromptChar = '_';
            this.mtxtSearch.ReadOnly = false;
            this.mtxtSearch.RejectInputOnFirstFailure = false;
            this.mtxtSearch.ResetOnPrompt = true;
            this.mtxtSearch.ResetOnSpace = true;
            this.mtxtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtSearch.SelectedText = "";
            this.mtxtSearch.SelectionLength = 0;
            this.mtxtSearch.SelectionStart = 0;
            this.mtxtSearch.ShortcutsEnabled = true;
            this.mtxtSearch.ShowAssistiveText = true;
            this.mtxtSearch.Size = new System.Drawing.Size(202, 52);
            this.mtxtSearch.SkipLiterals = true;
            this.mtxtSearch.TabIndex = 7;
            this.mtxtSearch.TabStop = false;
            this.mtxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtxtSearch.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtxtSearch.TrailingIcon = null;
            this.mtxtSearch.UseSystemPasswordChar = false;
            this.mtxtSearch.UseTallSize = false;
            this.mtxtSearch.ValidatingType = null;
            this.mtxtSearch.Visible = false;
            this.mtxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtSearch_KeyPress);
            this.mtxtSearch.TextChanged += new System.EventHandler(this.mtxtSearch_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.AutoResize = false;
            this.cbFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Depth = 0;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFilterBy.DropDownHeight = 118;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.DropDownWidth = 121;
            this.cbFilterBy.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.IntegralHeight = false;
            this.cbFilterBy.ItemHeight = 29;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(97, 3);
            this.cbFilterBy.MaxDropDownItems = 4;
            this.cbFilterBy.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(202, 35);
            this.cbFilterBy.StartIndex = 0;
            this.cbFilterBy.TabIndex = 8;
            this.cbFilterBy.UseTallSize = false;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = global::DVLD.Properties.Resources.trash;
            this.btnDelete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnDelete.Location = new System.Drawing.Point(1248, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvAllPeople
            // 
            this.dgvAllPeople.AllowUserToAddRows = false;
            this.dgvAllPeople.AllowUserToDeleteRows = false;
            this.dgvAllPeople.AllowUserToResizeRows = false;
            this.dgvAllPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAllPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPeople.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllPeople.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllPeople.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAllPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPeople.ContextMenuStrip = this.formContextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllPeople.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllPeople.EnableHeadersVisualStyles = false;
            this.dgvAllPeople.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAllPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllPeople.Location = new System.Drawing.Point(0, 196);
            this.dgvAllPeople.MultiSelect = false;
            this.dgvAllPeople.Name = "dgvAllPeople";
            this.dgvAllPeople.ReadOnly = true;
            this.dgvAllPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPeople.Size = new System.Drawing.Size(1352, 560);
            this.dgvAllPeople.TabIndex = 9;
            this.dgvAllPeople.DoubleClick += new System.EventHandler(this.dgvAllPeople_DoubleClick);
            // 
            // formContextMenuStrip1
            // 
            this.formContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.formContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowDetails,
            this.toolStripSeparator4,
            this.tsmiAddNewPerson,
            this.tttadToolStripMenuItem,
            this.tsmiDelete,
            this.toolStripSeparator3,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.formContextMenuStrip1.Name = "formContextMenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.formContextMenuStrip1.Renderer = controlRenderer1;
            this.formContextMenuStrip1.Size = new System.Drawing.Size(188, 160);
            // 
            // tsmiShowDetails
            // 
            this.tsmiShowDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmiShowDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tsmiShowDetails.Image = global::DVLD.Properties.Resources.ShowDetails;
            this.tsmiShowDetails.Name = "tsmiShowDetails";
            this.tsmiShowDetails.Size = new System.Drawing.Size(187, 24);
            this.tsmiShowDetails.Text = "Show Details";
            this.tsmiShowDetails.Click += new System.EventHandler(this.tsmiShowDetails_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmiAddNewPerson
            // 
            this.tsmiAddNewPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tsmiAddNewPerson.Image = global::DVLD.Properties.Resources.add_person;
            this.tsmiAddNewPerson.Name = "tsmiAddNewPerson";
            this.tsmiAddNewPerson.Size = new System.Drawing.Size(187, 24);
            this.tsmiAddNewPerson.Text = "Add New Person";
            this.tsmiAddNewPerson.Click += new System.EventHandler(this.tsmiAddNewPerson_Click);
            // 
            // tttadToolStripMenuItem
            // 
            this.tttadToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tttadToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit;
            this.tttadToolStripMenuItem.Name = "tttadToolStripMenuItem";
            this.tttadToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.tttadToolStripMenuItem.Text = "Edit";
            this.tttadToolStripMenuItem.Click += new System.EventHandler(this.tttadToolStripMenuItem_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tsmiDelete.Image = global::DVLD.Properties.Resources.trash;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(187, 24);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.email;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.phoneCallToolStripMenuItem.Image = global::DVLD.Properties.Resources.phone_call;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1266F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblNumberOfRecords, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 756);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1352, 54);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(89, 4);
            this.lblNumberOfRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(135, 32);
            this.lblNumberOfRecords.TabIndex = 8;
            this.lblNumberOfRecords.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "# Records:";
            // 
            // bigLabel2
            // 
            this.bigLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.bigLabel2.Location = new System.Drawing.Point(3, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(1346, 45);
            this.bigLabel2.TabIndex = 3;
            this.bigLabel2.Text = "Manage People";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bigLabel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 48);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 950);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dgvAllPeople);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormStyle = ReaLTaiizor.Enum.Material.FormStyles.StatusAndActionBar_None;
            this.Name = "frmListPeople";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "frmListPeople";
            this.Load += new System.EventHandler(this.frmListPeople_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPeople)).EndInit();
            this.formContextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.MaterialButton btnDelete;
        private ReaLTaiizor.Controls.MaterialButton btnEdit;
        private ReaLTaiizor.Controls.MaterialButton btnShowDetails;
        private ReaLTaiizor.Controls.MaterialButton btnAddNewPerson;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtxtSearch;
        private ReaLTaiizor.Controls.MaterialComboBox cbFilterBy;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvAllPeople;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.FormContextMenuStrip formContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem tttadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}