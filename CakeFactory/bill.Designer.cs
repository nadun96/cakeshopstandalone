namespace CakeFactory
{
    partial class frmtoken
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
            this.lblamount = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.olistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakeShopDataSet1 = new CakeFactory.CakeShopDataSet1();
            this.lbladvance = new System.Windows.Forms.Label();
            this.txtadvanced = new System.Windows.Forms.TextBox();
            this.dtpbilldate = new System.Windows.Forms.DateTimePicker();
            this.lbllog = new System.Windows.Forms.Label();
            this.txtcidlog = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtonum = new System.Windows.Forms.TextBox();
            this.lblordernu = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Updatebill = new System.Windows.Forms.Button();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnetamount = new System.Windows.Forms.Label();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.lblcash = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblbalence = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.olistTableAdapter = new CakeFactory.CakeShopDataSet1TableAdapters.olistTableAdapter();
            this.customerTableAdapter = new CakeFactory.CakeShopDataSet1TableAdapters.customerTableAdapter();
            this.dtpbilltime = new System.Windows.Forms.DateTimePicker();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(274, 226);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(122, 24);
            this.lblamount.TabIndex = 0;
            this.lblamount.Text = "Total Amount";
            // 
            // txttotal
            // 
            this.txttotal.AcceptsReturn = true;
            this.txttotal.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.olistBindingSource, "tot", true));
            this.txttotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.olistBindingSource, "tot", true));
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.SystemColors.Window;
            this.txttotal.Location = new System.Drawing.Point(473, 226);
            this.txttotal.MaxLength = 15;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(228, 29);
            this.txttotal.TabIndex = 1;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // olistBindingSource
            // 
            this.olistBindingSource.DataMember = "olist";
            this.olistBindingSource.DataSource = this.cakeShopDataSet1;
            // 
            // cakeShopDataSet1
            // 
            this.cakeShopDataSet1.DataSetName = "CakeShopDataSet1";
            this.cakeShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbladvance
            // 
            this.lbladvance.AutoSize = true;
            this.lbladvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladvance.Location = new System.Drawing.Point(274, 292);
            this.lbladvance.Name = "lbladvance";
            this.lbladvance.Size = new System.Drawing.Size(85, 24);
            this.lbladvance.TabIndex = 0;
            this.lbladvance.Text = "Advance";
            // 
            // txtadvanced
            // 
            this.txtadvanced.AcceptsReturn = true;
            this.txtadvanced.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.olistBindingSource, "adv", true));
            this.txtadvanced.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.olistBindingSource, "adv", true));
            this.txtadvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvanced.ForeColor = System.Drawing.SystemColors.Window;
            this.txtadvanced.Location = new System.Drawing.Point(473, 289);
            this.txtadvanced.MaxLength = 15;
            this.txtadvanced.Name = "txtadvanced";
            this.txtadvanced.Size = new System.Drawing.Size(228, 29);
            this.txtadvanced.TabIndex = 1;
            // 
            // dtpbilldate
            // 
            this.dtpbilldate.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpbilldate.CustomFormat = "";
            this.dtpbilldate.Enabled = false;
            this.dtpbilldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbilldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbilldate.Location = new System.Drawing.Point(473, 45);
            this.dtpbilldate.Name = "dtpbilldate";
            this.dtpbilldate.Size = new System.Drawing.Size(228, 29);
            this.dtpbilldate.TabIndex = 2;
            this.dtpbilldate.Value = new System.DateTime(2019, 4, 23, 0, 0, 0, 0);
            this.dtpbilldate.ValueChanged += new System.EventHandler(this.dtpbill_ValueChanged);
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(56, 145);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(113, 24);
            this.lbllog.TabIndex = 25;
            this.lbllog.Text = "Customer ID";
            this.lbllog.Click += new System.EventHandler(this.lbllog_Click);
            // 
            // txtcidlog
            // 
            this.txtcidlog.AcceptsReturn = true;
            this.txtcidlog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtcidlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcidlog.Cursor = System.Windows.Forms.Cursors.No;
            this.txtcidlog.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.customerBindingSource, "customerID", true));
            this.txtcidlog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerID", true));
            this.txtcidlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidlog.Location = new System.Drawing.Point(251, 145);
            this.txtcidlog.MaxLength = 6;
            this.txtcidlog.Name = "txtcidlog";
            this.txtcidlog.Size = new System.Drawing.Size(228, 29);
            this.txtcidlog.TabIndex = 24;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.cakeShopDataSet1;
            // 
            // txtonum
            // 
            this.txtonum.AcceptsReturn = true;
            this.txtonum.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.olistBindingSource, "onum", true));
            this.txtonum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.olistBindingSource, "onum", true));
            this.txtonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtonum.Location = new System.Drawing.Point(712, 142);
            this.txtonum.MaxLength = 10;
            this.txtonum.Name = "txtonum";
            this.txtonum.Size = new System.Drawing.Size(228, 29);
            this.txtonum.TabIndex = 23;
            this.txtonum.TextChanged += new System.EventHandler(this.txtordernumber_TextChanged);
            // 
            // lblordernu
            // 
            this.lblordernu.AutoSize = true;
            this.lblordernu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblordernu.Location = new System.Drawing.Point(555, 145);
            this.lblordernu.Name = "lblordernu";
            this.lblordernu.Size = new System.Drawing.Size(133, 24);
            this.lblordernu.TabIndex = 22;
            this.lblordernu.Text = "Order Number";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Cursor = System.Windows.Forms.Cursors.No;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(364, 45);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 24);
            this.lbldate.TabIndex = 26;
            this.lbldate.Text = "Date";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 61);
            this.button1.TabIndex = 27;
            this.button1.Text = "Print Bill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Updatebill
            // 
            this.Updatebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebill.Location = new System.Drawing.Point(132, 567);
            this.Updatebill.Name = "Updatebill";
            this.Updatebill.Size = new System.Drawing.Size(179, 61);
            this.Updatebill.TabIndex = 28;
            this.Updatebill.Text = "Update Bill";
            this.Updatebill.UseVisualStyleBackColor = true;
            this.Updatebill.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtnet
            // 
            this.txtnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnet.Location = new System.Drawing.Point(473, 347);
            this.txtnet.MaxLength = 15;
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(228, 29);
            this.txtnet.TabIndex = 29;
            this.txtnet.TextChanged += new System.EventHandler(this.txtnet_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // lblnetamount
            // 
            this.lblnetamount.AutoSize = true;
            this.lblnetamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetamount.Location = new System.Drawing.Point(274, 344);
            this.lblnetamount.Name = "lblnetamount";
            this.lblnetamount.Size = new System.Drawing.Size(110, 24);
            this.lblnetamount.TabIndex = 31;
            this.lblnetamount.Text = "Net Amount";
            // 
            // txtcash
            // 
            this.txtcash.AcceptsReturn = true;
            this.txtcash.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.olistBindingSource, "cash", true));
            this.txtcash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.olistBindingSource, "cash", true));
            this.txtcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcash.Location = new System.Drawing.Point(473, 407);
            this.txtcash.MaxLength = 15;
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(228, 29);
            this.txtcash.TabIndex = 29;
            // 
            // lblcash
            // 
            this.lblcash.AutoSize = true;
            this.lblcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.Location = new System.Drawing.Point(274, 407);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(138, 24);
            this.lblcash.TabIndex = 31;
            this.lblcash.Text = "Cash Received";
            // 
            // txtbalance
            // 
            this.txtbalance.AcceptsReturn = true;
            this.txtbalance.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.olistBindingSource, "change", true));
            this.txtbalance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.olistBindingSource, "change", true));
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbalance.Location = new System.Drawing.Point(473, 472);
            this.txtbalance.MaxLength = 15;
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(228, 29);
            this.txtbalance.TabIndex = 29;
            this.txtbalance.TextChanged += new System.EventHandler(this.txtbalance_TextChanged);
            // 
            // lblbalence
            // 
            this.lblbalence.AutoSize = true;
            this.lblbalence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalence.Location = new System.Drawing.Point(278, 472);
            this.lblbalence.Name = "lblbalence";
            this.lblbalence.Size = new System.Drawing.Size(120, 24);
            this.lblbalence.TabIndex = 31;
            this.lblbalence.Text = "Balance Paid";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(56, 41);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 24);
            this.lbl.TabIndex = 32;
            this.lbl.Text = "Time";
            // 
            // olistTableAdapter
            // 
            this.olistTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // dtpbilltime
            // 
            this.dtpbilltime.Cursor = System.Windows.Forms.Cursors.No;
            this.dtpbilltime.CustomFormat = "";
            this.dtpbilltime.Enabled = false;
            this.dtpbilltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbilltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpbilltime.Location = new System.Drawing.Point(180, 41);
            this.dtpbilltime.Name = "dtpbilltime";
            this.dtpbilltime.Size = new System.Drawing.Size(108, 29);
            this.dtpbilltime.TabIndex = 2;
            this.dtpbilltime.Value = new System.DateTime(2019, 4, 23, 0, 0, 0, 0);
            this.dtpbilltime.ValueChanged += new System.EventHandler(this.dtpbill_ValueChanged);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(746, 570);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(181, 58);
            this.btnback.TabIndex = 33;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // frmtoken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblbalence);
            this.Controls.Add(this.lblcash);
            this.Controls.Add(this.lblnetamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.txtnet);
            this.Controls.Add(this.Updatebill);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.txtcidlog);
            this.Controls.Add(this.txtonum);
            this.Controls.Add(this.lblordernu);
            this.Controls.Add(this.dtpbilltime);
            this.Controls.Add(this.dtpbilldate);
            this.Controls.Add(this.txtadvanced);
            this.Controls.Add(this.lbladvance);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lblamount);
            this.Name = "frmtoken";
            this.Text = "Token";
            this.Load += new System.EventHandler(this.frmbill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakeShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbladvance;
        private System.Windows.Forms.TextBox txtadvanced;
        private System.Windows.Forms.DateTimePicker dtpbilldate;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.TextBox txtcidlog;
        private System.Windows.Forms.TextBox txtonum;
        private System.Windows.Forms.Label lblordernu;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Updatebill;
        private System.Windows.Forms.TextBox txtnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnetamount;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lblbalence;
        private System.Windows.Forms.Label lbl;
        private CakeShopDataSet1 cakeShopDataSet1;
        private System.Windows.Forms.BindingSource olistBindingSource;
        private CakeShopDataSet1TableAdapters.olistTableAdapter olistTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CakeShopDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpbilltime;
        private System.Windows.Forms.Button btnback;
    }
}