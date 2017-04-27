namespace Final_Project {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.roomsNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Final_Project.HotelDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.roomSaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.roomsTable = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReservedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedUntilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservedByCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeStatus = new System.Windows.Forms.Label();
            this.lblEmployeeDateHired = new System.Windows.Forms.Label();
            this.lblEmployeeTelephone = new System.Windows.Forms.Label();
            this.lblEmployeePosition = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstEmpoloyees = new System.Windows.Forms.ListBox();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.panelCustomers = new System.Windows.Forms.Panel();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCustomerFilter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radDisplayOutstandingBalance = new System.Windows.Forms.RadioButton();
            this.radDisplayAllCustomers = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutCustomerDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerBalance = new System.Windows.Forms.Label();
            this.lblCustomerRoom = new System.Windows.Forms.Label();
            this.lblCustomerTelephone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.roomsTableAdapter = new Final_Project.HotelDataSetTableAdapters.RoomsTableAdapter();
            this.tabControlMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.tabRooms.SuspendLayout();
            this.panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNavigator)).BeginInit();
            this.roomsNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTable)).BeginInit();
            this.tabEmployees.SuspendLayout();
            this.panelEmployees.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.panelCustomers.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutCustomerDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabLogin);
            this.tabControlMain.Controls.Add(this.tabRooms);
            this.tabControlMain.Controls.Add(this.tabEmployees);
            this.tabControlMain.Controls.Add(this.tabCustomers);
            this.tabControlMain.Location = new System.Drawing.Point(6, 6);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(579, 396);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.panelLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(2);
            this.tabLogin.Size = new System.Drawing.Size(571, 370);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hotel Management Software 1.0";
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogin.Controls.Add(this.btnLogout);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(102, 36);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(368, 154);
            this.panelLogin.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(68, 101);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 25);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(154, 101);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(146, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(154, 61);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(154, 29);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this.panelRooms);
            this.tabRooms.Location = new System.Drawing.Point(4, 22);
            this.tabRooms.Margin = new System.Windows.Forms.Padding(2);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(2);
            this.tabRooms.Size = new System.Drawing.Size(571, 370);
            this.tabRooms.TabIndex = 1;
            this.tabRooms.Text = "Room Management";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // panelRooms
            // 
            this.panelRooms.BackColor = System.Drawing.SystemColors.Control;
            this.panelRooms.Controls.Add(this.roomsNavigator);
            this.panelRooms.Controls.Add(this.roomsTable);
            this.panelRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRooms.Enabled = false;
            this.panelRooms.Location = new System.Drawing.Point(2, 2);
            this.panelRooms.Margin = new System.Windows.Forms.Padding(2);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(567, 366);
            this.panelRooms.TabIndex = 0;
            // 
            // roomsNavigator
            // 
            this.roomsNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roomsNavigator.BindingSource = this.roomsBindingSource;
            this.roomsNavigator.CountItem = this.bindingNavigatorCountItem;
            this.roomsNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roomsNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.roomsNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.openToolStripButton,
            this.roomSaveToolStripButton,
            this.toolStripSeparator1});
            this.roomsNavigator.Location = new System.Drawing.Point(3, 341);
            this.roomsNavigator.MoveFirstItem = null;
            this.roomsNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.roomsNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.roomsNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.roomsNavigator.Name = "roomsNavigator";
            this.roomsNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.roomsNavigator.Size = new System.Drawing.Size(284, 25);
            this.roomsNavigator.TabIndex = 1;
            this.roomsNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // roomSaveToolStripButton
            // 
            this.roomSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roomSaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("roomSaveToolStripButton.Image")));
            this.roomSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.roomSaveToolStripButton.Name = "roomSaveToolStripButton";
            this.roomSaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.roomSaveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // roomsTable
            // 
            this.roomsTable.AllowUserToDeleteRows = false;
            this.roomsTable.AutoGenerateColumns = false;
            this.roomsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.reservedDataGridViewTextBoxColumn,
            this.availableDataGridViewTextBoxColumn,
            this.dateReservedDataGridViewTextBoxColumn,
            this.reservedUntilDataGridViewTextBoxColumn,
            this.reservedByCustomerDataGridViewTextBoxColumn});
            this.roomsTable.DataSource = this.roomsBindingSource;
            this.roomsTable.Location = new System.Drawing.Point(3, 3);
            this.roomsTable.Name = "roomsTable";
            this.roomsTable.Size = new System.Drawing.Size(558, 335);
            this.roomsTable.TabIndex = 0;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // reservedDataGridViewTextBoxColumn
            // 
            this.reservedDataGridViewTextBoxColumn.DataPropertyName = "Reserved";
            this.reservedDataGridViewTextBoxColumn.HeaderText = "Reserved";
            this.reservedDataGridViewTextBoxColumn.Name = "reservedDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewTextBoxColumn
            // 
            this.availableDataGridViewTextBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewTextBoxColumn.HeaderText = "Available";
            this.availableDataGridViewTextBoxColumn.Name = "availableDataGridViewTextBoxColumn";
            // 
            // dateReservedDataGridViewTextBoxColumn
            // 
            this.dateReservedDataGridViewTextBoxColumn.DataPropertyName = "DateReserved";
            this.dateReservedDataGridViewTextBoxColumn.HeaderText = "DateReserved";
            this.dateReservedDataGridViewTextBoxColumn.Name = "dateReservedDataGridViewTextBoxColumn";
            // 
            // reservedUntilDataGridViewTextBoxColumn
            // 
            this.reservedUntilDataGridViewTextBoxColumn.DataPropertyName = "ReservedUntil";
            this.reservedUntilDataGridViewTextBoxColumn.HeaderText = "ReservedUntil";
            this.reservedUntilDataGridViewTextBoxColumn.Name = "reservedUntilDataGridViewTextBoxColumn";
            // 
            // reservedByCustomerDataGridViewTextBoxColumn
            // 
            this.reservedByCustomerDataGridViewTextBoxColumn.DataPropertyName = "ReservedByCustomer";
            this.reservedByCustomerDataGridViewTextBoxColumn.HeaderText = "ReservedByCustomer";
            this.reservedByCustomerDataGridViewTextBoxColumn.Name = "reservedByCustomerDataGridViewTextBoxColumn";
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.panelEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(571, 370);
            this.tabEmployees.TabIndex = 2;
            this.tabEmployees.Text = "Employee Management";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // panelEmployees
            // 
            this.panelEmployees.BackColor = System.Drawing.SystemColors.Control;
            this.panelEmployees.Controls.Add(this.btnManageEmployees);
            this.panelEmployees.Controls.Add(this.groupBox5);
            this.panelEmployees.Controls.Add(this.lstEmpoloyees);
            this.panelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployees.Enabled = false;
            this.panelEmployees.Location = new System.Drawing.Point(0, 0);
            this.panelEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(571, 370);
            this.panelEmployees.TabIndex = 0;
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.Location = new System.Drawing.Point(171, 320);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(156, 39);
            this.btnManageEmployees.TabIndex = 3;
            this.btnManageEmployees.Text = "Add or Edit Employees";
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel2);
            this.groupBox5.Location = new System.Drawing.Point(169, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(395, 170);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeStatus, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeDateHired, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeTelephone, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeePosition, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblEmployeeID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 153);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblEmployeeStatus
            // 
            this.lblEmployeeStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeStatus.Location = new System.Drawing.Point(146, 125);
            this.lblEmployeeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeStatus.Name = "lblEmployeeStatus";
            this.lblEmployeeStatus.Size = new System.Drawing.Size(256, 23);
            this.lblEmployeeStatus.TabIndex = 11;
            this.lblEmployeeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeDateHired
            // 
            this.lblEmployeeDateHired.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeDateHired.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDateHired.Location = new System.Drawing.Point(146, 100);
            this.lblEmployeeDateHired.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeDateHired.Name = "lblEmployeeDateHired";
            this.lblEmployeeDateHired.Size = new System.Drawing.Size(256, 25);
            this.lblEmployeeDateHired.TabIndex = 9;
            this.lblEmployeeDateHired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeTelephone
            // 
            this.lblEmployeeTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeTelephone.Location = new System.Drawing.Point(146, 75);
            this.lblEmployeeTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeTelephone.Name = "lblEmployeeTelephone";
            this.lblEmployeeTelephone.Size = new System.Drawing.Size(256, 25);
            this.lblEmployeeTelephone.TabIndex = 8;
            this.lblEmployeeTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeePosition
            // 
            this.lblEmployeePosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePosition.Location = new System.Drawing.Point(146, 50);
            this.lblEmployeePosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.Size = new System.Drawing.Size(256, 25);
            this.lblEmployeePosition.TabIndex = 7;
            this.lblEmployeePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(146, 25);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(256, 25);
            this.lblEmployeeName.TabIndex = 6;
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(115, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(81, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 24);
            this.label16.TabIndex = 1;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(66, 50);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "Position";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(2, 75);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 24);
            this.label18.TabIndex = 3;
            this.label18.Text = "Phone Number";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(146, 0);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(256, 25);
            this.lblEmployeeID.TabIndex = 5;
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(43, 100);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "Date Hired";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Status";
            // 
            // lstEmpoloyees
            // 
            this.lstEmpoloyees.FormattingEnabled = true;
            this.lstEmpoloyees.Location = new System.Drawing.Point(15, 17);
            this.lstEmpoloyees.Name = "lstEmpoloyees";
            this.lstEmpoloyees.Size = new System.Drawing.Size(146, 342);
            this.lstEmpoloyees.TabIndex = 1;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.panelCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Size = new System.Drawing.Size(571, 370);
            this.tabCustomers.TabIndex = 3;
            this.tabCustomers.Text = "Customer Management";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // panelCustomers
            // 
            this.panelCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.panelCustomers.Controls.Add(this.btnManageCustomers);
            this.panelCustomers.Controls.Add(this.groupBox4);
            this.panelCustomers.Controls.Add(this.groupBox3);
            this.panelCustomers.Controls.Add(this.groupBox2);
            this.panelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomers.Enabled = false;
            this.panelCustomers.Location = new System.Drawing.Point(2, 2);
            this.panelCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.panelCustomers.Name = "panelCustomers";
            this.panelCustomers.Size = new System.Drawing.Size(567, 366);
            this.panelCustomers.TabIndex = 0;
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(395, 301);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(161, 46);
            this.btnManageCustomers.TabIndex = 3;
            this.btnManageCustomers.Text = "Add / Edit Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCustomerFilter);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.radDisplayOutstandingBalance);
            this.groupBox4.Controls.Add(this.radDisplayAllCustomers);
            this.groupBox4.Location = new System.Drawing.Point(162, 243);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(134, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display";
            // 
            // txtCustomerFilter
            // 
            this.txtCustomerFilter.Location = new System.Drawing.Point(8, 84);
            this.txtCustomerFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerFilter.Name = "txtCustomerFilter";
            this.txtCustomerFilter.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerFilter.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Filter:";
            // 
            // radDisplayOutstandingBalance
            // 
            this.radDisplayOutstandingBalance.AutoSize = true;
            this.radDisplayOutstandingBalance.Location = new System.Drawing.Point(8, 43);
            this.radDisplayOutstandingBalance.Margin = new System.Windows.Forms.Padding(2);
            this.radDisplayOutstandingBalance.Name = "radDisplayOutstandingBalance";
            this.radDisplayOutstandingBalance.Size = new System.Drawing.Size(124, 17);
            this.radDisplayOutstandingBalance.TabIndex = 1;
            this.radDisplayOutstandingBalance.TabStop = true;
            this.radDisplayOutstandingBalance.Text = "Outstanding Balance";
            this.radDisplayOutstandingBalance.UseVisualStyleBackColor = true;
            // 
            // radDisplayAllCustomers
            // 
            this.radDisplayAllCustomers.AutoSize = true;
            this.radDisplayAllCustomers.Checked = true;
            this.radDisplayAllCustomers.Location = new System.Drawing.Point(8, 24);
            this.radDisplayAllCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.radDisplayAllCustomers.Name = "radDisplayAllCustomers";
            this.radDisplayAllCustomers.Size = new System.Drawing.Size(36, 17);
            this.radDisplayAllCustomers.TabIndex = 0;
            this.radDisplayAllCustomers.TabStop = true;
            this.radDisplayAllCustomers.Text = "All";
            this.radDisplayAllCustomers.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutCustomerDetails);
            this.groupBox3.Location = new System.Drawing.Point(161, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(395, 153);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Details";
            // 
            // tableLayoutCustomerDetails
            // 
            this.tableLayoutCustomerDetails.ColumnCount = 2;
            this.tableLayoutCustomerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutCustomerDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutCustomerDetails.Controls.Add(this.lblCustomerBalance, 1, 4);
            this.tableLayoutCustomerDetails.Controls.Add(this.lblCustomerRoom, 1, 3);
            this.tableLayoutCustomerDetails.Controls.Add(this.lblCustomerTelephone, 1, 2);
            this.tableLayoutCustomerDetails.Controls.Add(this.lblCustomerName, 1, 1);
            this.tableLayoutCustomerDetails.Controls.Add(this.label4, 0, 0);
            this.tableLayoutCustomerDetails.Controls.Add(this.label5, 0, 1);
            this.tableLayoutCustomerDetails.Controls.Add(this.label6, 0, 2);
            this.tableLayoutCustomerDetails.Controls.Add(this.label7, 0, 3);
            this.tableLayoutCustomerDetails.Controls.Add(this.label8, 0, 4);
            this.tableLayoutCustomerDetails.Controls.Add(this.lblCustomerID, 1, 0);
            this.tableLayoutCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutCustomerDetails.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutCustomerDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutCustomerDetails.Name = "tableLayoutCustomerDetails";
            this.tableLayoutCustomerDetails.RowCount = 5;
            this.tableLayoutCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutCustomerDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutCustomerDetails.Size = new System.Drawing.Size(391, 136);
            this.tableLayoutCustomerDetails.TabIndex = 0;
            // 
            // lblCustomerBalance
            // 
            this.lblCustomerBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerBalance.Location = new System.Drawing.Point(146, 108);
            this.lblCustomerBalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerBalance.Name = "lblCustomerBalance";
            this.lblCustomerBalance.Size = new System.Drawing.Size(256, 27);
            this.lblCustomerBalance.TabIndex = 9;
            this.lblCustomerBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerRoom
            // 
            this.lblCustomerRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRoom.Location = new System.Drawing.Point(146, 81);
            this.lblCustomerRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerRoom.Name = "lblCustomerRoom";
            this.lblCustomerRoom.Size = new System.Drawing.Size(256, 27);
            this.lblCustomerRoom.TabIndex = 8;
            this.lblCustomerRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerTelephone
            // 
            this.lblCustomerTelephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTelephone.Location = new System.Drawing.Point(146, 54);
            this.lblCustomerTelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerTelephone.Name = "lblCustomerTelephone";
            this.lblCustomerTelephone.Size = new System.Drawing.Size(256, 27);
            this.lblCustomerTelephone.TabIndex = 7;
            this.lblCustomerTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(146, 27);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(256, 27);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Current Room";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 110);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Balance Due";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(146, 0);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(256, 27);
            this.lblCustomerID.TabIndex = 5;
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCustomers);
            this.groupBox2.Location = new System.Drawing.Point(14, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(144, 348);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customers";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 16;
            this.lstCustomers.Location = new System.Drawing.Point(2, 15);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(140, 331);
            this.lstCustomers.TabIndex = 0;
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoginStatus});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 407);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(585, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(83, 17);
            this.lblLoginStatus.Text = "Not Logged In";
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 429);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management Software";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.tabRooms.ResumeLayout(false);
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNavigator)).EndInit();
            this.roomsNavigator.ResumeLayout(false);
            this.roomsNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTable)).EndInit();
            this.tabEmployees.ResumeLayout(false);
            this.panelEmployees.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabCustomers.ResumeLayout(false);
            this.panelCustomers.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutCustomerDetails.ResumeLayout(false);
            this.tableLayoutCustomerDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.MaskedTextBox txtPassword;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripStatusLabel lblLoginStatus;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Panel panelRooms;
        public System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.TabPage tabCustomers;
        public System.Windows.Forms.Panel panelCustomers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutCustomerDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ListBox lstCustomers;
        public System.Windows.Forms.Label lblCustomerBalance;
        public System.Windows.Forms.Label lblCustomerRoom;
        public System.Windows.Forms.Label lblCustomerTelephone;
        public System.Windows.Forms.Label lblCustomerName;
        public System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.RadioButton radDisplayOutstandingBalance;
        public System.Windows.Forms.RadioButton radDisplayAllCustomers;
        public System.Windows.Forms.TextBox txtCustomerFilter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label lblEmployeeDateHired;
        public System.Windows.Forms.Label lblEmployeeTelephone;
        public System.Windows.Forms.Label lblEmployeePosition;
        public System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ListBox lstEmpoloyees;
        public System.Windows.Forms.Label lblEmployeeStatus;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.BindingNavigator roomsNavigator;
        public System.Windows.Forms.DataGridView roomsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReservedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedUntilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservedByCustomerDataGridViewTextBoxColumn;
        public System.Windows.Forms.ToolStripButton roomSaveToolStripButton;
        public System.Windows.Forms.BindingSource roomsBindingSource;
        public HotelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        public HotelDataSet hotelDataSet;
    }
}

