
namespace Form_with_Listbox
{
    partial class Form1
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
            this.groupBox_Form = new Guna.UI.WinForms.GunaGroupBox();
            this.txtBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.dtPicker_BirthDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btn_Add = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtBox_Email = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtBox_Surname = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtBox_Name = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lstbox_User = new System.Windows.Forms.ListBox();
            this.txtBox_FileName = new System.Windows.Forms.TextBox();
            this.btn_Load = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Form
            // 
            this.groupBox_Form.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Form.BaseColor = System.Drawing.Color.MediumSlateBlue;
            this.groupBox_Form.BorderColor = System.Drawing.Color.Red;
            this.groupBox_Form.Controls.Add(this.txtBox_Phone);
            this.groupBox_Form.Controls.Add(this.dtPicker_BirthDate);
            this.groupBox_Form.Controls.Add(this.btn_Add);
            this.groupBox_Form.Controls.Add(this.gunaLabel5);
            this.groupBox_Form.Controls.Add(this.gunaLabel4);
            this.groupBox_Form.Controls.Add(this.txtBox_Email);
            this.groupBox_Form.Controls.Add(this.gunaLabel3);
            this.groupBox_Form.Controls.Add(this.txtBox_Surname);
            this.groupBox_Form.Controls.Add(this.gunaLabel2);
            this.groupBox_Form.Controls.Add(this.txtBox_Name);
            this.groupBox_Form.Controls.Add(this.gunaLabel1);
            this.groupBox_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Form.LineColor = System.Drawing.Color.Honeydew;
            this.groupBox_Form.Location = new System.Drawing.Point(25, 21);
            this.groupBox_Form.Name = "groupBox_Form";
            this.groupBox_Form.Size = new System.Drawing.Size(360, 348);
            this.groupBox_Form.TabIndex = 0;
            this.groupBox_Form.Text = "Form";
            this.groupBox_Form.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Location = new System.Drawing.Point(69, 179);
            this.txtBox_Phone.Mask = "(999) 000-0000";
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.Size = new System.Drawing.Size(216, 29);
            this.txtBox_Phone.TabIndex = 11;
            // 
            // dtPicker_BirthDate
            // 
            this.dtPicker_BirthDate.BaseColor = System.Drawing.Color.White;
            this.dtPicker_BirthDate.BorderColor = System.Drawing.Color.Silver;
            this.dtPicker_BirthDate.CustomFormat = null;
            this.dtPicker_BirthDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPicker_BirthDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker_BirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPicker_BirthDate.ForeColor = System.Drawing.Color.Black;
            this.dtPicker_BirthDate.Location = new System.Drawing.Point(71, 222);
            this.dtPicker_BirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicker_BirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicker_BirthDate.Name = "dtPicker_BirthDate";
            this.dtPicker_BirthDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPicker_BirthDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker_BirthDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker_BirthDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtPicker_BirthDate.Size = new System.Drawing.Size(214, 29);
            this.dtPicker_BirthDate.TabIndex = 10;
            this.dtPicker_BirthDate.Text = "Monday, August 2, 2021";
            this.dtPicker_BirthDate.Value = new System.DateTime(2021, 8, 2, 1, 50, 4, 297);
            // 
            // btn_Add
            // 
            this.btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Add.Animated = true;
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Add.BorderColor = System.Drawing.Color.Black;
            this.btn_Add.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Add.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Add.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Add.CheckedImage = null;
            this.btn_Add.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = null;
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add.Location = new System.Drawing.Point(220, 294);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add.Size = new System.Drawing.Size(74, 42);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(-4, 222);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(77, 20);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "BirthDate";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(3, 185);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(53, 20);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Phone";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.BackColor = System.Drawing.Color.White;
            this.txtBox_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Email.FocusedLineColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBox_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBox_Email.LineColor = System.Drawing.Color.Gainsboro;
            this.txtBox_Email.Location = new System.Drawing.Point(69, 136);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.PasswordChar = '\0';
            this.txtBox_Email.SelectedText = "";
            this.txtBox_Email.Size = new System.Drawing.Size(216, 26);
            this.txtBox_Email.TabIndex = 6;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(3, 142);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(47, 20);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Email";
            // 
            // txtBox_Surname
            // 
            this.txtBox_Surname.BackColor = System.Drawing.Color.White;
            this.txtBox_Surname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Surname.FocusedLineColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBox_Surname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBox_Surname.LineColor = System.Drawing.Color.Gainsboro;
            this.txtBox_Surname.Location = new System.Drawing.Point(71, 93);
            this.txtBox_Surname.Name = "txtBox_Surname";
            this.txtBox_Surname.PasswordChar = '\0';
            this.txtBox_Surname.SelectedText = "";
            this.txtBox_Surname.Size = new System.Drawing.Size(216, 26);
            this.txtBox_Surname.TabIndex = 4;
            this.txtBox_Surname.TextChanged += new System.EventHandler(this.txtBox_Surname_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(3, 93);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(71, 20);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Surname";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.BackColor = System.Drawing.Color.White;
            this.txtBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Name.FocusedLineColor = System.Drawing.Color.DeepSkyBlue;
            this.txtBox_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBox_Name.LineColor = System.Drawing.Color.Gainsboro;
            this.txtBox_Name.Location = new System.Drawing.Point(71, 52);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.PasswordChar = '\0';
            this.txtBox_Name.SelectedText = "";
            this.txtBox_Name.Size = new System.Drawing.Size(216, 26);
            this.txtBox_Name.TabIndex = 2;
            this.txtBox_Name.TextChanged += new System.EventHandler(this.txtBox_Name_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(51, 20);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Name";
            // 
            // lstbox_User
            // 
            this.lstbox_User.BackColor = System.Drawing.Color.SlateBlue;
            this.lstbox_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox_User.FormattingEnabled = true;
            this.lstbox_User.ItemHeight = 20;
            this.lstbox_User.Location = new System.Drawing.Point(449, 33);
            this.lstbox_User.Name = "lstbox_User";
            this.lstbox_User.Size = new System.Drawing.Size(294, 324);
            this.lstbox_User.TabIndex = 1;
            this.lstbox_User.SelectedIndexChanged += new System.EventHandler(this.lstbox_User_SelectedIndexChanged);
            // 
            // txtBox_FileName
            // 
            this.txtBox_FileName.Location = new System.Drawing.Point(449, 374);
            this.txtBox_FileName.Name = "txtBox_FileName";
            this.txtBox_FileName.Size = new System.Drawing.Size(294, 20);
            this.txtBox_FileName.TabIndex = 2;
            // 
            // btn_Load
            // 
            this.btn_Load.Animated = true;
            this.btn_Load.AnimationHoverSpeed = 0.07F;
            this.btn_Load.AnimationSpeed = 0.03F;
            this.btn_Load.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btn_Load.BorderColor = System.Drawing.Color.Black;
            this.btn_Load.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Load.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Load.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Load.CheckedImage = null;
            this.btn_Load.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Load.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Load.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Load.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.Black;
            this.btn_Load.Image = null;
            this.btn_Load.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Load.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Load.Location = new System.Drawing.Point(449, 400);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Load.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Load.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Load.OnHoverImage = null;
            this.btn_Load.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Load.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Load.Size = new System.Drawing.Size(130, 42);
            this.btn_Load.TabIndex = 3;
            this.btn_Load.Text = "Load";
            this.btn_Load.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Animated = true;
            this.btn_Save.AnimationHoverSpeed = 0.07F;
            this.btn_Save.AnimationSpeed = 0.03F;
            this.btn_Save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(130)))), ((int)(((byte)(127)))));
            this.btn_Save.BorderColor = System.Drawing.Color.Black;
            this.btn_Save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Save.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Save.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Save.CheckedImage = null;
            this.btn_Save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Save.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Image = null;
            this.btn_Save.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Save.Location = new System.Drawing.Point(613, 400);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Save.OnHoverImage = null;
            this.btn_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Save.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Save.Size = new System.Drawing.Size(130, 42);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(747, 448);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txtBox_FileName);
            this.Controls.Add(this.lstbox_User);
            this.Controls.Add(this.groupBox_Form);
            this.MaximumSize = new System.Drawing.Size(763, 487);
            this.MinimumSize = new System.Drawing.Size(763, 487);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Form.ResumeLayout(false);
            this.groupBox_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox groupBox_Form;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtBox_Name;
        private Guna.UI.WinForms.GunaLineTextBox txtBox_Surname;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLineTextBox txtBox_Email;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add;
        private System.Windows.Forms.ListBox lstbox_User;
        private System.Windows.Forms.TextBox txtBox_FileName;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Load;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Save;
        private System.Windows.Forms.MaskedTextBox txtBox_Phone;
        private Guna.UI.WinForms.GunaDateTimePicker dtPicker_BirthDate;
    }
}

