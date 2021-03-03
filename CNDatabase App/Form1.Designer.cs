namespace CNDatabase_App {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlBase = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnFindInfo = new System.Windows.Forms.Button();
            this.btnBackToBase = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBase.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.lblUpdate);
            this.pnlBase.Controls.Add(this.lblFind);
            this.pnlBase.Controls.Add(this.btnUpdate);
            this.pnlBase.Controls.Add(this.btnFind);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(0, 0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(800, 450);
            this.pnlBase.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(46, 67);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(282, 99);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(46, 261);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(282, 99);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(334, 153);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(147, 13);
            this.lblFind.TabIndex = 2;
            this.lblFind.Text = "Find a ninja, sensei or director";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(337, 346);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(219, 13);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "Update information of ninja, sensei or director";
            // 
            // pnlFind
            // 
            this.pnlFind.Controls.Add(this.label1);
            this.pnlFind.Controls.Add(this.txtTableName);
            this.pnlFind.Controls.Add(this.btnBackToBase);
            this.pnlFind.Controls.Add(this.btnFindInfo);
            this.pnlFind.Controls.Add(this.lblLastName);
            this.pnlFind.Controls.Add(this.txtLastName);
            this.pnlFind.Controls.Add(this.lblFirstName);
            this.pnlFind.Controls.Add(this.txtFirstName);
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFind.Location = new System.Drawing.Point(0, 0);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(800, 450);
            this.pnlFind.TabIndex = 1;
            this.pnlFind.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(16, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(253, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(276, 92);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Enter First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(16, 137);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(253, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(276, 144);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Enter Last Name";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // btnFindInfo
            // 
            this.btnFindInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindInfo.Location = new System.Drawing.Point(16, 188);
            this.btnFindInfo.Name = "btnFindInfo";
            this.btnFindInfo.Size = new System.Drawing.Size(253, 95);
            this.btnFindInfo.TabIndex = 4;
            this.btnFindInfo.Text = "Get Info";
            this.btnFindInfo.UseVisualStyleBackColor = true;
            this.btnFindInfo.Click += new System.EventHandler(this.btnFindInfo_Click);
            // 
            // btnBackToBase
            // 
            this.btnBackToBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToBase.Location = new System.Drawing.Point(16, 335);
            this.btnBackToBase.Name = "btnBackToBase";
            this.btnBackToBase.Size = new System.Drawing.Size(253, 72);
            this.btnBackToBase.TabIndex = 5;
            this.btnBackToBase.Text = "Back To First Page";
            this.btnBackToBase.UseVisualStyleBackColor = true;
            this.btnBackToBase.Click += new System.EventHandler(this.btnBackToBase_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(16, 41);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(253, 20);
            this.txtTableName.TabIndex = 6;
            this.txtTableName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter either ninja, sensei or director";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.pnlBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Button btnFindInfo;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnBackToBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
    }
}

