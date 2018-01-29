namespace DeleteContactCRM
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbIFD = new System.Windows.Forms.TabPage();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbOnpremise = new System.Windows.Forms.TabPage();
            this.tbOnline = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tbIFD.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(134, 9);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(244, 20);
            this.txtServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(134, 39);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(244, 20);
            this.txtLoginId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(244, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(214, 253);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(158, 43);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Connection Type";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbIFD);
            this.tabControl1.Controls.Add(this.tbOnpremise);
            this.tabControl1.Controls.Add(this.tbOnline);
            this.tabControl1.Location = new System.Drawing.Point(92, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 181);
            this.tabControl1.TabIndex = 11;
            // 
            // tbIFD
            // 
            this.tbIFD.Controls.Add(this.btnUpload);
            this.tbIFD.Controls.Add(this.label1);
            this.tbIFD.Controls.Add(this.txtServer);
            this.tbIFD.Controls.Add(this.label3);
            this.tbIFD.Controls.Add(this.txtLoginId);
            this.tbIFD.Controls.Add(this.txtPassword);
            this.tbIFD.Controls.Add(this.label2);
            this.tbIFD.Location = new System.Drawing.Point(4, 22);
            this.tbIFD.Name = "tbIFD";
            this.tbIFD.Padding = new System.Windows.Forms.Padding(3);
            this.tbIFD.Size = new System.Drawing.Size(400, 155);
            this.tbIFD.TabIndex = 1;
            this.tbIFD.Text = "IFD";
            this.tbIFD.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(152, 109);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbOnpremise
            // 
            this.tbOnpremise.Location = new System.Drawing.Point(4, 22);
            this.tbOnpremise.Name = "tbOnpremise";
            this.tbOnpremise.Padding = new System.Windows.Forms.Padding(3);
            this.tbOnpremise.Size = new System.Drawing.Size(400, 155);
            this.tbOnpremise.TabIndex = 2;
            this.tbOnpremise.Text = "On Premise";
            this.tbOnpremise.UseVisualStyleBackColor = true;
            // 
            // tbOnline
            // 
            this.tbOnline.Location = new System.Drawing.Point(4, 22);
            this.tbOnline.Name = "tbOnline";
            this.tbOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tbOnline.Size = new System.Drawing.Size(400, 155);
            this.tbOnline.TabIndex = 0;
            this.tbOnline.Text = "Online";
            this.tbOnline.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 331);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbIFD.ResumeLayout(false);
            this.tbIFD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbOnline;
        private System.Windows.Forms.TabPage tbIFD;
        private System.Windows.Forms.TabPage tbOnpremise;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

