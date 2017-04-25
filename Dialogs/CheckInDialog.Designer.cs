namespace Final_Project.Dialogs
{
    partial class CheckInDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radExistingCustomer = new System.Windows.Forms.RadioButton();
            this.radNewCustomer = new System.Windows.Forms.RadioButton();
            this.groupNewCustomer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewCustName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewCustTelephone = new System.Windows.Forms.TextBox();
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupExistingCustomer = new System.Windows.Forms.GroupBox();
            this.lstExistingCustomers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupReservation = new System.Windows.Forms.GroupBox();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboRoomNum = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupNewCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).BeginInit();
            this.groupExistingCustomer.SuspendLayout();
            this.groupReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNewCustomer);
            this.groupBox1.Controls.Add(this.radExistingCustomer);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // radExistingCustomer
            // 
            this.radExistingCustomer.AutoSize = true;
            this.radExistingCustomer.Checked = true;
            this.radExistingCustomer.Location = new System.Drawing.Point(7, 20);
            this.radExistingCustomer.Name = "radExistingCustomer";
            this.radExistingCustomer.Size = new System.Drawing.Size(108, 17);
            this.radExistingCustomer.TabIndex = 0;
            this.radExistingCustomer.TabStop = true;
            this.radExistingCustomer.Text = "Existing Customer";
            this.radExistingCustomer.UseVisualStyleBackColor = true;
            this.radExistingCustomer.CheckedChanged += new System.EventHandler(this.radExistingCustomer_CheckedChanged);
            // 
            // radNewCustomer
            // 
            this.radNewCustomer.AutoSize = true;
            this.radNewCustomer.Location = new System.Drawing.Point(7, 44);
            this.radNewCustomer.Name = "radNewCustomer";
            this.radNewCustomer.Size = new System.Drawing.Size(94, 17);
            this.radNewCustomer.TabIndex = 1;
            this.radNewCustomer.Text = "New Customer";
            this.radNewCustomer.UseVisualStyleBackColor = true;
            this.radNewCustomer.CheckedChanged += new System.EventHandler(this.radNewCustomer_CheckedChanged);
            // 
            // groupNewCustomer
            // 
            this.groupNewCustomer.Controls.Add(this.txtNewCustTelephone);
            this.groupNewCustomer.Controls.Add(this.label2);
            this.groupNewCustomer.Controls.Add(this.txtNewCustName);
            this.groupNewCustomer.Controls.Add(this.label1);
            this.groupNewCustomer.Enabled = false;
            this.groupNewCustomer.Location = new System.Drawing.Point(179, 13);
            this.groupNewCustomer.Name = "groupNewCustomer";
            this.groupNewCustomer.Size = new System.Drawing.Size(227, 87);
            this.groupNewCustomer.TabIndex = 1;
            this.groupNewCustomer.TabStop = false;
            this.groupNewCustomer.Text = "New Customer Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // txtNewCustName
            // 
            this.txtNewCustName.Location = new System.Drawing.Point(69, 24);
            this.txtNewCustName.Name = "txtNewCustName";
            this.txtNewCustName.Size = new System.Drawing.Size(125, 20);
            this.txtNewCustName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telephone:";
            // 
            // txtNewCustTelephone
            // 
            this.txtNewCustTelephone.Location = new System.Drawing.Point(69, 52);
            this.txtNewCustTelephone.Name = "txtNewCustTelephone";
            this.txtNewCustTelephone.Size = new System.Drawing.Size(125, 20);
            this.txtNewCustTelephone.TabIndex = 3;
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // errPhone
            // 
            this.errPhone.ContainerControl = this;
            // 
            // groupExistingCustomer
            // 
            this.groupExistingCustomer.Controls.Add(this.lstExistingCustomers);
            this.groupExistingCustomer.Location = new System.Drawing.Point(13, 106);
            this.groupExistingCustomer.Name = "groupExistingCustomer";
            this.groupExistingCustomer.Size = new System.Drawing.Size(146, 230);
            this.groupExistingCustomer.TabIndex = 2;
            this.groupExistingCustomer.TabStop = false;
            this.groupExistingCustomer.Text = "Existing Customer";
            // 
            // lstExistingCustomers
            // 
            this.lstExistingCustomers.FormattingEnabled = true;
            this.lstExistingCustomers.Location = new System.Drawing.Point(7, 20);
            this.lstExistingCustomers.Name = "lstExistingCustomers";
            this.lstExistingCustomers.Size = new System.Drawing.Size(126, 199);
            this.lstExistingCustomers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Process Reservation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupReservation
            // 
            this.groupReservation.Controls.Add(this.comboRoomNum);
            this.groupReservation.Controls.Add(this.label5);
            this.groupReservation.Controls.Add(this.dateEnd);
            this.groupReservation.Controls.Add(this.label4);
            this.groupReservation.Controls.Add(this.label3);
            this.groupReservation.Controls.Add(this.dateBegin);
            this.groupReservation.Location = new System.Drawing.Point(179, 106);
            this.groupReservation.Name = "groupReservation";
            this.groupReservation.Size = new System.Drawing.Size(227, 180);
            this.groupReservation.TabIndex = 4;
            this.groupReservation.TabStop = false;
            this.groupReservation.Text = "Details of stay";
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(9, 36);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(200, 20);
            this.dateBegin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reservation begin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Reservation end";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(9, 75);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room to be reserved:";
            // 
            // comboRoomNum
            // 
            this.comboRoomNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomNum.FormattingEnabled = true;
            this.comboRoomNum.Location = new System.Drawing.Point(9, 115);
            this.comboRoomNum.Name = "comboRoomNum";
            this.comboRoomNum.Size = new System.Drawing.Size(200, 21);
            this.comboRoomNum.TabIndex = 5;
            // 
            // CheckInDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 348);
            this.Controls.Add(this.groupReservation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupExistingCustomer);
            this.Controls.Add(this.groupNewCustomer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckInDialog";
            this.Text = "Customer Check-In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupNewCustomer.ResumeLayout(false);
            this.groupNewCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).EndInit();
            this.groupExistingCustomer.ResumeLayout(false);
            this.groupReservation.ResumeLayout(false);
            this.groupReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNewCustomer;
        private System.Windows.Forms.RadioButton radExistingCustomer;
        private System.Windows.Forms.GroupBox groupNewCustomer;
        private System.Windows.Forms.TextBox txtNewCustTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.ErrorProvider errPhone;
        private System.Windows.Forms.GroupBox groupExistingCustomer;
        private System.Windows.Forms.ListBox lstExistingCustomers;
        private System.Windows.Forms.GroupBox groupReservation;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboRoomNum;
        private System.Windows.Forms.Label label5;
    }
}