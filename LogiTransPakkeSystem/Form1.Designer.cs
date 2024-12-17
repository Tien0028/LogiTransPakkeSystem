namespace Shipments_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstBox_Packs = new System.Windows.Forms.ListBox();
            this.txtbox_Height = new System.Windows.Forms.TextBox();
            this.txtbox_Width = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Savepath = new System.Windows.Forms.Label();
            this.btn_SavePath = new System.Windows.Forms.Button();
            this.txtBox_SavePath = new System.Windows.Forms.TextBox();
            this.txtbox_Remarks = new System.Windows.Forms.TextBox();
            this.btn_showPackLists = new System.Windows.Forms.Button();
            this.btn_PakkerByCity = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtbox_ReceiverAddress = new System.Windows.Forms.TextBox();
            this.txtbox_Weight = new System.Windows.Forms.TextBox();
            this.txtbox_Length = new System.Windows.Forms.TextBox();
            this.txtbox_EmployeeID = new System.Windows.Forms.TextBox();
            this.txtbox_SenderAddress = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstBox_Packs
            // 
            this.lstBox_Packs.FormattingEnabled = true;
            this.lstBox_Packs.Location = new System.Drawing.Point(492, 9);
            this.lstBox_Packs.Name = "lstBox_Packs";
            this.lstBox_Packs.Size = new System.Drawing.Size(297, 329);
            this.lstBox_Packs.TabIndex = 11;
            // 
            // txtbox_Height
            // 
            this.txtbox_Height.Location = new System.Drawing.Point(318, 131);
            this.txtbox_Height.Name = "txtbox_Height";
            this.txtbox_Height.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Height.TabIndex = 45;
            this.txtbox_Height.Enter += new System.EventHandler(this.txtbox_Height_Enter);
            this.txtbox_Height.Leave += new System.EventHandler(this.txtbox_Height_Leave);
            // 
            // txtbox_Width
            // 
            this.txtbox_Width.Location = new System.Drawing.Point(212, 131);
            this.txtbox_Width.Name = "txtbox_Width";
            this.txtbox_Width.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Width.TabIndex = 44;
            this.txtbox_Width.Enter += new System.EventHandler(this.txtbox_Width_Enter);
            this.txtbox_Width.Leave += new System.EventHandler(this.txtbox_Width_Leave);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(413, 228);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 43;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Remarks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Dimensions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Weight (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Receiver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sender:";
            // 
            // lbl_Savepath
            // 
            this.lbl_Savepath.AutoSize = true;
            this.lbl_Savepath.Location = new System.Drawing.Point(12, 286);
            this.lbl_Savepath.Name = "lbl_Savepath";
            this.lbl_Savepath.Size = new System.Drawing.Size(72, 13);
            this.lbl_Savepath.TabIndex = 36;
            this.lbl_Savepath.Text = "Din Gemmesti";
            // 
            // btn_SavePath
            // 
            this.btn_SavePath.Location = new System.Drawing.Point(104, 257);
            this.btn_SavePath.Name = "btn_SavePath";
            this.btn_SavePath.Size = new System.Drawing.Size(139, 23);
            this.btn_SavePath.TabIndex = 35;
            this.btn_SavePath.Text = "Vælg Gemmesti";
            this.btn_SavePath.UseVisualStyleBackColor = true;
            this.btn_SavePath.Click += new System.EventHandler(this.btn_SavePath_Click);
            // 
            // txtBox_SavePath
            // 
            this.txtBox_SavePath.Location = new System.Drawing.Point(104, 286);
            this.txtBox_SavePath.Name = "txtBox_SavePath";
            this.txtBox_SavePath.Size = new System.Drawing.Size(384, 20);
            this.txtBox_SavePath.TabIndex = 34;
            // 
            // txtbox_Remarks
            // 
            this.txtbox_Remarks.Location = new System.Drawing.Point(104, 211);
            this.txtbox_Remarks.Name = "txtbox_Remarks";
            this.txtbox_Remarks.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Remarks.TabIndex = 32;
            // 
            // btn_showPackLists
            // 
            this.btn_showPackLists.Location = new System.Drawing.Point(413, 53);
            this.btn_showPackLists.Name = "btn_showPackLists";
            this.btn_showPackLists.Size = new System.Drawing.Size(75, 23);
            this.btn_showPackLists.TabIndex = 31;
            this.btn_showPackLists.Text = "Vis Pakkelist";
            this.btn_showPackLists.UseVisualStyleBackColor = true;
            this.btn_showPackLists.Click += new System.EventHandler(this.btn_showPackLists_Click);
            // 
            // btn_PakkerByCity
            // 
            this.btn_PakkerByCity.Location = new System.Drawing.Point(370, 9);
            this.btn_PakkerByCity.Name = "btn_PakkerByCity";
            this.btn_PakkerByCity.Size = new System.Drawing.Size(118, 24);
            this.btn_PakkerByCity.TabIndex = 30;
            this.btn_PakkerByCity.Text = "Vis Pakker Pr. By";
            this.btn_PakkerByCity.UseVisualStyleBackColor = true;
            this.btn_PakkerByCity.Click += new System.EventHandler(this.btn_PakkerByCity_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(413, 173);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Gem";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtbox_ReceiverAddress
            // 
            this.txtbox_ReceiverAddress.Location = new System.Drawing.Point(104, 50);
            this.txtbox_ReceiverAddress.Name = "txtbox_ReceiverAddress";
            this.txtbox_ReceiverAddress.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ReceiverAddress.TabIndex = 28;
            // 
            // txtbox_Weight
            // 
            this.txtbox_Weight.Location = new System.Drawing.Point(104, 93);
            this.txtbox_Weight.Name = "txtbox_Weight";
            this.txtbox_Weight.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Weight.TabIndex = 27;
            // 
            // txtbox_Length
            // 
            this.txtbox_Length.Location = new System.Drawing.Point(104, 131);
            this.txtbox_Length.Name = "txtbox_Length";
            this.txtbox_Length.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Length.TabIndex = 26;
            this.txtbox_Length.Enter += new System.EventHandler(this.txtbox_Length_Enter);
            this.txtbox_Length.Leave += new System.EventHandler(this.txtbox_Length_Leave);
            // 
            // txtbox_EmployeeID
            // 
            this.txtbox_EmployeeID.Location = new System.Drawing.Point(104, 171);
            this.txtbox_EmployeeID.Name = "txtbox_EmployeeID";
            this.txtbox_EmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtbox_EmployeeID.TabIndex = 25;
            // 
            // txtbox_SenderAddress
            // 
            this.txtbox_SenderAddress.Location = new System.Drawing.Point(104, 9);
            this.txtbox_SenderAddress.Name = "txtbox_SenderAddress";
            this.txtbox_SenderAddress.Size = new System.Drawing.Size(100, 20);
            this.txtbox_SenderAddress.TabIndex = 24;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(212, 9);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 23;
            this.cityComboBox.Text = "Byer";
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Location = new System.Drawing.Point(375, 93);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(113, 17);
            this.dateCheck.TabIndex = 46;
            this.dateCheck.Text = "For Idag/imorgen?";
            this.dateCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(869, 387);
            this.Controls.Add(this.dateCheck);
            this.Controls.Add(this.txtbox_Height);
            this.Controls.Add(this.txtbox_Width);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Savepath);
            this.Controls.Add(this.btn_SavePath);
            this.Controls.Add(this.txtBox_SavePath);
            this.Controls.Add(this.txtbox_Remarks);
            this.Controls.Add(this.btn_showPackLists);
            this.Controls.Add(this.btn_PakkerByCity);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtbox_ReceiverAddress);
            this.Controls.Add(this.txtbox_Weight);
            this.Controls.Add(this.txtbox_Length);
            this.Controls.Add(this.txtbox_EmployeeID);
            this.Controls.Add(this.txtbox_SenderAddress);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.lstBox_Packs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Packs;
        private System.Windows.Forms.TextBox txtbox_Height;
        private System.Windows.Forms.TextBox txtbox_Width;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Savepath;
        private System.Windows.Forms.Button btn_SavePath;
        private System.Windows.Forms.TextBox txtBox_SavePath;
        private System.Windows.Forms.TextBox txtbox_Remarks;
        private System.Windows.Forms.Button btn_showPackLists;
        private System.Windows.Forms.Button btn_PakkerByCity;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txtbox_ReceiverAddress;
        private System.Windows.Forms.TextBox txtbox_Weight;
        private System.Windows.Forms.TextBox txtbox_Length;
        private System.Windows.Forms.TextBox txtbox_EmployeeID;
        private System.Windows.Forms.TextBox txtbox_SenderAddress;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.CheckBox dateCheck;
    }
}

