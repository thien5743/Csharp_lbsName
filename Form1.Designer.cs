namespace Csharp_lbsName
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
            this.lbsketqua = new System.Windows.Forms.ListBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbsketqua
            // 
            this.lbsketqua.FormattingEnabled = true;
            this.lbsketqua.Location = new System.Drawing.Point(61, 213);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(565, 225);
            this.lbsketqua.TabIndex = 10;
            this.lbsketqua.SelectedIndexChanged += new System.EventHandler(this.lbsketqua_SelectedIndexChanged);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(582, 115);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(144, 70);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(100, 114);
            this.txtten.Multiline = true;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(465, 70);
            this.txtten.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập tên sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(795, 115);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(144, 70);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(987, 114);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(144, 70);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 450);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsketqua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
    }
}

