namespace CakeFactory
{
    partial class txttemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txttemp));
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtcidlogl = new System.Windows.Forms.TextBox();
            this.lblsignup = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblorderlist = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.lblgpb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(697, 308);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(140, 40);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtcidlogl
            // 
            this.txtcidlogl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidlogl.Location = new System.Drawing.Point(617, 207);
            this.txtcidlogl.MaxLength = 6;
            this.txtcidlogl.Name = "txtcidlogl";
            this.txtcidlogl.Size = new System.Drawing.Size(318, 29);
            this.txtcidlogl.TabIndex = 1;
            this.txtcidlogl.TextChanged += new System.EventHandler(this.txtcidlogin_TextChanged);
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.Location = new System.Drawing.Point(702, 405);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(124, 24);
            this.lblsignup.TabIndex = 2;
            this.lblsignup.Text = "Sign Up Here";
            this.lblsignup.Click += new System.EventHandler(this.operationClick);
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(451, 207);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(113, 24);
            this.lbllog.TabIndex = 2;
            this.lbllog.Text = "Customer ID";
            // 
            // lblorderlist
            // 
            this.lblorderlist.AutoSize = true;
            this.lblorderlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderlist.Location = new System.Drawing.Point(642, 627);
            this.lblorderlist.Name = "lblorderlist";
            this.lblorderlist.Size = new System.Drawing.Size(126, 20);
            this.lblorderlist.TabIndex = 3;
            this.lblorderlist.Text = "Go To Order List";
            this.lblorderlist.Click += new System.EventHandler(this.lblorderlist_Click);
            // 
            // txtpw
            // 
            this.txtpw.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(617, 598);
            this.txtpw.MaxLength = 10;
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(318, 26);
            this.txtpw.TabIndex = 4;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.Location = new System.Drawing.Point(716, 582);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(110, 13);
            this.lblpw.TabIndex = 3;
            this.lblpw.Text = " Enter Password Here";
            this.lblpw.Click += new System.EventHandler(this.lblorderlist_Click);
            // 
            // lblgpb
            // 
            this.lblgpb.AutoSize = true;
            this.lblgpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgpb.Location = new System.Drawing.Point(798, 627);
            this.lblgpb.Name = "lblgpb";
            this.lblgpb.Size = new System.Drawing.Size(109, 20);
            this.lblgpb.TabIndex = 19;
            this.lblgpb.Text = "Go to Print Bill";
            this.lblgpb.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(664, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "CUSTOMER LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "EMPLOYEE LOGIN";
            // 
            // txttemp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblgpb);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblorderlist);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.txtcidlogl);
            this.Controls.Add(this.btnlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "txttemp";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtcidlogl;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Label lblorderlist;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.Label lblgpb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

