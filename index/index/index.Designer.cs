namespace index
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLogin
            // 
            this.grbLogin.BackColor = System.Drawing.Color.Transparent;
            this.grbLogin.Controls.Add(this.chkPass);
            this.grbLogin.Controls.Add(this.btnEntrar);
            this.grbLogin.Controls.Add(this.lblPass);
            this.grbLogin.Controls.Add(this.lblUser);
            this.grbLogin.Controls.Add(this.txtPass);
            this.grbLogin.Controls.Add(this.txtUser);
            this.grbLogin.Location = new System.Drawing.Point(12, 87);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(286, 141);
            this.grbLogin.TabIndex = 5;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Login";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(135, 112);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(109, 23);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Login";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(6, 48);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 20);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Senha: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(6, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 20);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuario: ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(84, 48);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(160, 20);
            this.txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(84, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(160, 20);
            this.txtUser.TabIndex = 5;
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPass.Location = new System.Drawing.Point(135, 74);
            this.chkPass.Name = "chkPass";
            this.chkPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPass.Size = new System.Drawing.Size(101, 17);
            this.chkPass.TabIndex = 6;
            this.chkPass.Text = ": Mostrar Senha ";
            this.chkPass.UseVisualStyleBackColor = true;
            this.chkPass.CheckedChanged += new System.EventHandler(this.chkPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seja Bem vindo";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(310, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbLogin);
            this.Name = "frmIndex";
            this.Text = "LOJA FACIL";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox chkPass;
        private System.Windows.Forms.Label label1;
    }
}

