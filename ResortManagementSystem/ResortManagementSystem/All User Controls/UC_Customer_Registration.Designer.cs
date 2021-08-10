
namespace ResortManagementSystem.All_User_Controls
{
    partial class UC_Customer_Registration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtIDProof = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAllocateRoom = new Guna.UI2.WinForms.Guna2Button();
            this.txtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtRoomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MobileNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Of Birth";
            // 
            // txtDob
            // 
            this.txtDob.CheckedState.Parent = this.txtDob;
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDob.HoverState.Parent = this.txtDob;
            this.txtDob.Location = new System.Drawing.Point(37, 448);
            this.txtDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDob.Name = "txtDob";
            this.txtDob.ShadowDecoration.Parent = this.txtDob;
            this.txtDob.Size = new System.Drawing.Size(232, 36);
            this.txtDob.TabIndex = 6;
            this.txtDob.Value = new System.DateTime(2021, 8, 10, 0, 0, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(48, 97);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Name";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(221, 36);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 7;
            // 
            // txtMobile
            // 
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobile.DefaultText = "";
            this.txtMobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobile.DisabledState.Parent = this.txtMobile;
            this.txtMobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobile.FocusedState.Parent = this.txtMobile;
            this.txtMobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobile.HoverState.Parent = this.txtMobile;
            this.txtMobile.Location = new System.Drawing.Point(48, 183);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.PlaceholderText = "Enter Mobile";
            this.txtMobile.SelectedText = "";
            this.txtMobile.ShadowDecoration.Parent = this.txtMobile;
            this.txtMobile.Size = new System.Drawing.Size(221, 36);
            this.txtMobile.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMobile.TabIndex = 8;
            // 
            // txtNationality
            // 
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.Parent = this.txtNationality;
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.FocusedState.Parent = this.txtNationality;
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.HoverState.Parent = this.txtNationality;
            this.txtNationality.Location = new System.Drawing.Point(48, 264);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PasswordChar = '\0';
            this.txtNationality.PlaceholderText = "Enter Nationality";
            this.txtNationality.SelectedText = "";
            this.txtNationality.ShadowDecoration.Parent = this.txtNationality;
            this.txtNationality.Size = new System.Drawing.Size(221, 36);
            this.txtNationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNationality.TabIndex = 9;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.Empty;
            this.txtGender.FocusedState.Parent = this.txtGender;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtGender.FormattingEnabled = true;
            this.txtGender.HoverState.Parent = this.txtGender;
            this.txtGender.ItemHeight = 30;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.ItemsAppearance.Parent = this.txtGender;
            this.txtGender.Location = new System.Drawing.Point(48, 366);
            this.txtGender.Name = "txtGender";
            this.txtGender.ShadowDecoration.Parent = this.txtGender;
            this.txtGender.Size = new System.Drawing.Size(221, 36);
            this.txtGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGender.TabIndex = 10;
            // 
            // txtIDProof
            // 
            this.txtIDProof.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDProof.DefaultText = "";
            this.txtIDProof.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDProof.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDProof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProof.DisabledState.Parent = this.txtIDProof;
            this.txtIDProof.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDProof.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProof.FocusedState.Parent = this.txtIDProof;
            this.txtIDProof.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDProof.HoverState.Parent = this.txtIDProof;
            this.txtIDProof.Location = new System.Drawing.Point(394, 97);
            this.txtIDProof.Name = "txtIDProof";
            this.txtIDProof.PasswordChar = '\0';
            this.txtIDProof.PlaceholderText = "Enter ID";
            this.txtIDProof.SelectedText = "";
            this.txtIDProof.ShadowDecoration.Parent = this.txtIDProof;
            this.txtIDProof.Size = new System.Drawing.Size(221, 36);
            this.txtIDProof.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtIDProof.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID Proof";
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(394, 183);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Enter Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(221, 36);
            this.txtAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAddress.TabIndex = 14;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(390, 160);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(67, 20);
            this.Address.TabIndex = 13;
            this.Address.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(691, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "RoomNo";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(691, 160);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(79, 20);
            this.l.TabIndex = 17;
            this.l.Text = "RoomType";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(691, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Bed";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(695, 366);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Enter Price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(221, 36);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(691, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Price";
            // 
            // btnAllocateRoom
            // 
            this.btnAllocateRoom.BorderRadius = 25;
            this.btnAllocateRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAllocateRoom.CheckedState.Parent = this.btnAllocateRoom;
            this.btnAllocateRoom.CustomImages.Parent = this.btnAllocateRoom;
            this.btnAllocateRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllocateRoom.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocateRoom.ForeColor = System.Drawing.Color.White;
            this.btnAllocateRoom.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnAllocateRoom.HoverState.Parent = this.btnAllocateRoom;
            this.btnAllocateRoom.Location = new System.Drawing.Point(710, 448);
            this.btnAllocateRoom.Name = "btnAllocateRoom";
            this.btnAllocateRoom.ShadowDecoration.Parent = this.btnAllocateRoom;
            this.btnAllocateRoom.Size = new System.Drawing.Size(180, 45);
            this.btnAllocateRoom.TabIndex = 23;
            this.btnAllocateRoom.Text = "Allocate Room";
            this.btnAllocateRoom.Click += new System.EventHandler(this.btnAllocateRoom_Click);
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.CheckedState.Parent = this.txtCheckIn;
            this.txtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtCheckIn.HoverState.Parent = this.txtCheckIn;
            this.txtCheckIn.Location = new System.Drawing.Point(394, 283);
            this.txtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.ShadowDecoration.Parent = this.txtCheckIn;
            this.txtCheckIn.Size = new System.Drawing.Size(232, 36);
            this.txtCheckIn.TabIndex = 25;
            this.txtCheckIn.Value = new System.DateTime(2021, 8, 10, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(390, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Check In";
            // 
            // txtBed
            // 
            this.txtBed.BackColor = System.Drawing.Color.Transparent;
            this.txtBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBed.FocusedColor = System.Drawing.Color.Empty;
            this.txtBed.FocusedState.Parent = this.txtBed;
            this.txtBed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtBed.FormattingEnabled = true;
            this.txtBed.HoverState.Parent = this.txtBed;
            this.txtBed.ItemHeight = 30;
            this.txtBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Tripple"});
            this.txtBed.ItemsAppearance.Parent = this.txtBed;
            this.txtBed.Location = new System.Drawing.Point(695, 273);
            this.txtBed.Name = "txtBed";
            this.txtBed.ShadowDecoration.Parent = this.txtBed;
            this.txtBed.Size = new System.Drawing.Size(221, 36);
            this.txtBed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtBed.TabIndex = 27;
            this.txtBed.SelectedIndexChanged += new System.EventHandler(this.txtBed_SelectedIndexChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomNo.FocusedColor = System.Drawing.Color.Empty;
            this.txtRoomNo.FocusedState.Parent = this.txtRoomNo;
            this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtRoomNo.FormattingEnabled = true;
            this.txtRoomNo.HoverState.Parent = this.txtRoomNo;
            this.txtRoomNo.ItemHeight = 30;
            this.txtRoomNo.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.txtRoomNo.ItemsAppearance.Parent = this.txtRoomNo;
            this.txtRoomNo.Location = new System.Drawing.Point(685, 183);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.ShadowDecoration.Parent = this.txtRoomNo;
            this.txtRoomNo.Size = new System.Drawing.Size(332, 36);
            this.txtRoomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomNo.TabIndex = 38;
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.txtRoomType.FocusedState.Parent = this.txtRoomType;
            this.txtRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.HoverState.Parent = this.txtRoomType;
            this.txtRoomType.ItemHeight = 30;
            this.txtRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Tripple"});
            this.txtRoomType.ItemsAppearance.Parent = this.txtRoomType;
            this.txtRoomType.Location = new System.Drawing.Point(685, 97);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ShadowDecoration.Parent = this.txtRoomType;
            this.txtRoomType.Size = new System.Drawing.Size(332, 36);
            this.txtRoomType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomType.TabIndex = 37;
            // 
            // UC_Customer_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAllocateRoom);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.txtIDProof);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Customer_Registration";
            this.Size = new System.Drawing.Size(1274, 583);
            this.Leave += new System.EventHandler(this.UC_Customer_Registration_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDob;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private Guna.UI2.WinForms.Guna2TextBox txtIDProof;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button btnAllocateRoom;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckIn;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox txtBed;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomNo;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomType;
    }
}
