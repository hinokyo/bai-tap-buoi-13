namespace lancuoiiiii
{
    partial class frmChatLieu
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
            this.txtMaChatLieu = new System.Windows.Forms.Label();
            this.txtTenChatLieu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.AutoSize = true;
            this.txtMaChatLieu.Location = new System.Drawing.Point(114, 50);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(84, 16);
            this.txtMaChatLieu.TabIndex = 0;
            this.txtMaChatLieu.Text = "Ma Chat Lieu";
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.AutoSize = true;
            this.txtTenChatLieu.Location = new System.Drawing.Point(109, 84);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(89, 16);
            this.txtTenChatLieu.TabIndex = 1;
            this.txtTenChatLieu.Text = "Ten Chat Lieu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 22);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(83, 375);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(75, 23);
            this.buttonthem.TabIndex = 5;
            this.buttonthem.Text = "Them";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(216, 375);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(75, 23);
            this.buttonsua.TabIndex = 6;
            this.buttonsua.Text = "Sua";
            this.buttonsua.UseVisualStyleBackColor = true;
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(348, 375);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 7;
            this.buttonxoa.Text = "Xoa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.Location = new System.Drawing.Point(480, 375);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(75, 23);
            this.buttoncapnhat.TabIndex = 8;
            this.buttoncapnhat.Text = "Cap nhat";
            this.buttoncapnhat.UseVisualStyleBackColor = true;
            // 
            // buttonluu
            // 
            this.buttonluu.Location = new System.Drawing.Point(611, 375);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(75, 23);
            this.buttonluu.TabIndex = 9;
            this.buttonluu.Text = "Luu";
            this.buttonluu.UseVisualStyleBackColor = true;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // frmChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTenChatLieu);
            this.Controls.Add(this.txtMaChatLieu);
            this.Name = "frmChatLieu";
            this.Text = "frmChatLieu";
            this.Load += new System.EventHandler(this.frmChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMaChatLieu;
        private System.Windows.Forms.Label txtTenChatLieu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.Button buttonluu;
    }
}
