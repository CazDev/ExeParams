namespace ExeParams
{
    partial class ExeParams
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
            this.btnLaunch = new System.Windows.Forms.Button();
            this.txtExe = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtParams = new System.Windows.Forms.TextBox();
            this.lblExe = new System.Windows.Forms.Label();
            this.lblParams = new System.Windows.Forms.Label();
            this.chkCloseLaunch = new System.Windows.Forms.CheckBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.Location = new System.Drawing.Point(288, 179);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(93, 45);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // txtExe
            // 
            this.txtExe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExe.Location = new System.Drawing.Point(46, 52);
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(335, 29);
            this.txtExe.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(387, 52);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(32, 29);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtParams
            // 
            this.txtParams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParams.Location = new System.Drawing.Point(46, 116);
            this.txtParams.Name = "txtParams";
            this.txtParams.Size = new System.Drawing.Size(335, 29);
            this.txtParams.TabIndex = 3;
            // 
            // lblExe
            // 
            this.lblExe.AutoSize = true;
            this.lblExe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExe.Location = new System.Drawing.Point(42, 28);
            this.lblExe.Name = "lblExe";
            this.lblExe.Size = new System.Drawing.Size(101, 21);
            this.lblExe.TabIndex = 4;
            this.lblExe.Text = "Exe to launch";
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParams.Location = new System.Drawing.Point(42, 92);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(257, 21);
            this.lblParams.TabIndex = 5;
            this.lblParams.Text = "Parammeters (Separated by spaces)";
            // 
            // chkCloseLaunch
            // 
            this.chkCloseLaunch.Checked = true;
            this.chkCloseLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCloseLaunch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkCloseLaunch.Location = new System.Drawing.Point(46, 181);
            this.chkCloseLaunch.Name = "chkCloseLaunch";
            this.chkCloseLaunch.Size = new System.Drawing.Size(162, 45);
            this.chkCloseLaunch.TabIndex = 6;
            this.chkCloseLaunch.Text = "Close this window when launched";
            this.chkCloseLaunch.UseVisualStyleBackColor = true;
            // 
            // ExeParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 271);
            this.Controls.Add(this.chkCloseLaunch);
            this.Controls.Add(this.lblParams);
            this.Controls.Add(this.lblExe);
            this.Controls.Add(this.txtParams);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtExe);
            this.Controls.Add(this.btnLaunch);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExeParams";
            this.ShowIcon = false;
            this.Text = "ExeParams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TextBox txtExe;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtParams;
        private System.Windows.Forms.Label lblExe;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.CheckBox chkCloseLaunch;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}

