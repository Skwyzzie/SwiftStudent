namespace Swift_Student
{
    partial class PartAdd
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
            this.OpenPic = new System.Windows.Forms.OpenFileDialog();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.addPart = new System.Windows.Forms.Button();
            this.browseBTN = new System.Windows.Forms.Button();
            this.StudentPhoto = new System.Windows.Forms.PictureBox();
            this.IDESC = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.ISSC = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.ISS = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.ISG = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.ISN = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.PartInfoGroup = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ISID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPhoto)).BeginInit();
            this.PartInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenPic
            // 
            this.OpenPic.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.webp";
            this.OpenPic.InitialDirectory = "My.Computer.SpecialDirectories.Pictures";
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(94, 302);
            this.cancelBTN.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(67, 24);
            this.cancelBTN.TabIndex = 26;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(9, 302);
            this.addPart.Margin = new System.Windows.Forms.Padding(2);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(81, 24);
            this.addPart.TabIndex = 25;
            this.addPart.Text = "Add Part";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // browseBTN
            // 
            this.browseBTN.BackColor = System.Drawing.Color.Transparent;
            this.browseBTN.Location = new System.Drawing.Point(261, 302);
            this.browseBTN.Margin = new System.Windows.Forms.Padding(2);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.Size = new System.Drawing.Size(104, 24);
            this.browseBTN.TabIndex = 27;
            this.browseBTN.Text = "Browse photo...";
            this.browseBTN.UseVisualStyleBackColor = false;
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // StudentPhoto
            // 
            this.StudentPhoto.InitialImage = null;
            this.StudentPhoto.Location = new System.Drawing.Point(174, 86);
            this.StudentPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.StudentPhoto.Name = "StudentPhoto";
            this.StudentPhoto.Size = new System.Drawing.Size(174, 193);
            this.StudentPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPhoto.TabIndex = 28;
            this.StudentPhoto.TabStop = false;
            // 
            // IDESC
            // 
            this.IDESC.Location = new System.Drawing.Point(9, 101);
            this.IDESC.Margin = new System.Windows.Forms.Padding(2);
            this.IDESC.Multiline = true;
            this.IDESC.Name = "IDESC";
            this.IDESC.Size = new System.Drawing.Size(161, 178);
            this.IDESC.TabIndex = 6;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(7, 84);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(63, 13);
            this.Label12.TabIndex = 9999999;
            this.Label12.Text = "Description:";
            // 
            // ISSC
            // 
            this.ISSC.Location = new System.Drawing.Point(97, 62);
            this.ISSC.Margin = new System.Windows.Forms.Padding(2);
            this.ISSC.Name = "ISSC";
            this.ISSC.Size = new System.Drawing.Size(251, 20);
            this.ISSC.TabIndex = 4;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(8, 64);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 13);
            this.Label10.TabIndex = 9999999;
            this.Label10.Text = "Sending School:";
            // 
            // ISS
            // 
            this.ISS.Location = new System.Drawing.Point(169, 38);
            this.ISS.Margin = new System.Windows.Forms.Padding(2);
            this.ISS.Name = "ISS";
            this.ISS.Size = new System.Drawing.Size(179, 20);
            this.ISS.TabIndex = 5;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(127, 41);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 13);
            this.Label9.TabIndex = 9999999;
            this.Label9.Text = "Shop:";
            // 
            // ISG
            // 
            this.ISG.Location = new System.Drawing.Point(51, 38);
            this.ISG.Margin = new System.Windows.Forms.Padding(2);
            this.ISG.Name = "ISG";
            this.ISG.Size = new System.Drawing.Size(72, 20);
            this.ISG.TabIndex = 3;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(8, 41);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(39, 13);
            this.Label8.TabIndex = 9999999;
            this.Label8.Text = "Grade:";
            // 
            // ISN
            // 
            this.ISN.Location = new System.Drawing.Point(169, 14);
            this.ISN.Margin = new System.Windows.Forms.Padding(2);
            this.ISN.Name = "ISN";
            this.ISN.Size = new System.Drawing.Size(179, 20);
            this.ISN.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(7, 16);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(21, 13);
            this.Label6.TabIndex = 9999999;
            this.Label6.Text = "ID:";
            // 
            // PartInfoGroup
            // 
            this.PartInfoGroup.Controls.Add(this.IDESC);
            this.PartInfoGroup.Controls.Add(this.Label12);
            this.PartInfoGroup.Controls.Add(this.ISSC);
            this.PartInfoGroup.Controls.Add(this.StudentPhoto);
            this.PartInfoGroup.Controls.Add(this.Label10);
            this.PartInfoGroup.Controls.Add(this.ISS);
            this.PartInfoGroup.Controls.Add(this.Label9);
            this.PartInfoGroup.Controls.Add(this.ISG);
            this.PartInfoGroup.Controls.Add(this.Label8);
            this.PartInfoGroup.Controls.Add(this.ISN);
            this.PartInfoGroup.Controls.Add(this.Label5);
            this.PartInfoGroup.Controls.Add(this.ISID);
            this.PartInfoGroup.Controls.Add(this.Label6);
            this.PartInfoGroup.Location = new System.Drawing.Point(9, 10);
            this.PartInfoGroup.Margin = new System.Windows.Forms.Padding(2);
            this.PartInfoGroup.Name = "PartInfoGroup";
            this.PartInfoGroup.Padding = new System.Windows.Forms.Padding(2);
            this.PartInfoGroup.Size = new System.Drawing.Size(356, 288);
            this.PartInfoGroup.TabIndex = 23;
            this.PartInfoGroup.TabStop = false;
            this.PartInfoGroup.Text = "Part Info";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(127, 17);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(38, 13);
            this.Label5.TabIndex = 9999999;
            this.Label5.Text = "Name:";
            // 
            // ISID
            // 
            this.ISID.Location = new System.Drawing.Point(40, 14);
            this.ISID.Margin = new System.Windows.Forms.Padding(2);
            this.ISID.Name = "ISID";
            this.ISID.Size = new System.Drawing.Size(83, 20);
            this.ISID.TabIndex = 0;
            // 
            // PartAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 333);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.browseBTN);
            this.Controls.Add(this.PartInfoGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PartAdd";
            this.Text = "Add a part";
            ((System.ComponentModel.ISupportInitialize)(this.StudentPhoto)).EndInit();
            this.PartInfoGroup.ResumeLayout(false);
            this.PartInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OpenPic;
        internal System.Windows.Forms.Button cancelBTN;
        internal System.Windows.Forms.Button addPart;
        internal System.Windows.Forms.Button browseBTN;
        internal System.Windows.Forms.PictureBox StudentPhoto;
        internal System.Windows.Forms.TextBox IDESC;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox ISSC;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox ISS;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox ISG;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox ISN;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox PartInfoGroup;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox ISID;
    }
}