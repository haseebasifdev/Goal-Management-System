namespace Goal_Management_System
{
    partial class EditRoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditRoleName = new System.Windows.Forms.TextBox();
            this.cmbEditRoleType = new System.Windows.Forms.ComboBox();
            this.btnEditRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Role Type";
            // 
            // txtEditRoleName
            // 
            this.txtEditRoleName.Location = new System.Drawing.Point(142, 56);
            this.txtEditRoleName.Name = "txtEditRoleName";
            this.txtEditRoleName.Size = new System.Drawing.Size(121, 20);
            this.txtEditRoleName.TabIndex = 2;
            // 
            // cmbEditRoleType
            // 
            this.cmbEditRoleType.FormattingEnabled = true;
            this.cmbEditRoleType.Location = new System.Drawing.Point(142, 132);
            this.cmbEditRoleType.Name = "cmbEditRoleType";
            this.cmbEditRoleType.Size = new System.Drawing.Size(121, 21);
            this.cmbEditRoleType.TabIndex = 3;
            // 
            // btnEditRole
            // 
            this.btnEditRole.Location = new System.Drawing.Point(142, 210);
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(75, 23);
            this.btnEditRole.TabIndex = 4;
            this.btnEditRole.Text = "Save";
            this.btnEditRole.UseVisualStyleBackColor = true;
            this.btnEditRole.Click += new System.EventHandler(this.btnEditRole_Click);
            // 
            // EditRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 306);
            this.Controls.Add(this.btnEditRole);
            this.Controls.Add(this.cmbEditRoleType);
            this.Controls.Add(this.txtEditRoleName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRoles";
            this.Text = "EditRoles";
            this.Load += new System.EventHandler(this.EditRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditRoleName;
        private System.Windows.Forms.ComboBox cmbEditRoleType;
        private System.Windows.Forms.Button btnEditRole;
    }
}