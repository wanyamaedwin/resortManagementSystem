
namespace ResortManagementSystem
{
    partial class Dashboard
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
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_CustomerDetails1 = new ResortManagementSystem.All_User_Controls.UC_CustomerDetails();
            this.uC_CheckOut1 = new ResortManagementSystem.All_User_Controls.UC_CheckOut();
            this.uC_Customer_Registration1 = new ResortManagementSystem.All_User_Controls.UC_Customer_Registration();
            this.uC_AddRoom1 = new ResortManagementSystem.All_User_Controls.UC_AddRoom();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Employee1 = new ResortManagementSystem.All_User_Controls.UC_Employee();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(-1, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(44, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Gray;
            this.btnMinimize.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(-1, 35);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(44, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.btnEmployee);
            this.guna2Panel1.Controls.Add(this.btnCustomerDetails);
            this.guna2Panel1.Controls.Add(this.btnCustomerRegistration);
            this.guna2Panel1.Controls.Add(this.btnCheckOut);
            this.guna2Panel1.Controls.Add(this.btnAddRoom);
            this.guna2Panel1.Location = new System.Drawing.Point(49, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1260, 130);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderColor = System.Drawing.Color.Teal;
            this.btnEmployee.BorderRadius = 25;
            this.btnEmployee.BorderThickness = 1;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEmployee.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Location = new System.Drawing.Point(996, 23);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(236, 85);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BorderColor = System.Drawing.Color.Teal;
            this.btnCustomerDetails.BorderRadius = 25;
            this.btnCustomerDetails.BorderThickness = 1;
            this.btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCustomerDetails.CheckedState.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.CustomImages.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetails.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerDetails.HoverState.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.Location = new System.Drawing.Point(754, 23);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.ShadowDecoration.Parent = this.btnCustomerDetails;
            this.btnCustomerDetails.Size = new System.Drawing.Size(236, 85);
            this.btnCustomerDetails.TabIndex = 3;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.BorderColor = System.Drawing.Color.Teal;
            this.btnCustomerRegistration.BorderRadius = 25;
            this.btnCustomerRegistration.BorderThickness = 1;
            this.btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCustomerRegistration.CheckedState.Parent = this.btnCustomerRegistration;
            this.btnCustomerRegistration.CustomImages.Parent = this.btnCustomerRegistration;
            this.btnCustomerRegistration.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerRegistration.HoverState.Parent = this.btnCustomerRegistration;
            this.btnCustomerRegistration.Location = new System.Drawing.Point(274, 23);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.ShadowDecoration.Parent = this.btnCustomerRegistration;
            this.btnCustomerRegistration.Size = new System.Drawing.Size(236, 85);
            this.btnCustomerRegistration.TabIndex = 2;
            this.btnCustomerRegistration.Text = "CustomerRegistration";
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderColor = System.Drawing.Color.Teal;
            this.btnCheckOut.BorderRadius = 25;
            this.btnCheckOut.BorderThickness = 1;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCheckOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Location = new System.Drawing.Point(512, 23);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(236, 85);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderColor = System.Drawing.Color.Teal;
            this.btnAddRoom.BorderRadius = 25;
            this.btnAddRoom.BorderThickness = 1;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnAddRoom.CheckedState.Parent = this.btnAddRoom;
            this.btnAddRoom.CustomImages.Parent = this.btnAddRoom;
            this.btnAddRoom.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddRoom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.HoverState.Parent = this.btnAddRoom;
            this.btnAddRoom.Location = new System.Drawing.Point(32, 23);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.ShadowDecoration.Parent = this.btnAddRoom;
            this.btnAddRoom.Size = new System.Drawing.Size(236, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.uC_Employee1);
            this.guna2Panel2.Controls.Add(this.uC_CustomerDetails1);
            this.guna2Panel2.Controls.Add(this.uC_CheckOut1);
            this.guna2Panel2.Controls.Add(this.uC_Customer_Registration1);
            this.guna2Panel2.Controls.Add(this.uC_AddRoom1);
            this.guna2Panel2.Location = new System.Drawing.Point(12, 135);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1297, 505);
            this.guna2Panel2.TabIndex = 3;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1342, 558);
            this.uC_CustomerDetails1.TabIndex = 3;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.Location = new System.Drawing.Point(0, 0);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1297, 563);
            this.uC_CheckOut1.TabIndex = 2;
            // 
            // uC_Customer_Registration1
            // 
            this.uC_Customer_Registration1.Location = new System.Drawing.Point(3, 3);
            this.uC_Customer_Registration1.Name = "uC_Customer_Registration1";
            this.uC_Customer_Registration1.Size = new System.Drawing.Size(1286, 583);
            this.uC_Customer_Registration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(3, 3);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1286, 524);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.Load += new System.EventHandler(this.uC_AddRoom1_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1342, 583);
            this.uC_Employee1.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1313, 640);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Controls.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Controls.UC_Customer_Registration uC_Customer_Registration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Controls.UC_CheckOut uC_CheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Controls.UC_CustomerDetails uC_CustomerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Controls.UC_Employee uC_Employee1;
    }
}