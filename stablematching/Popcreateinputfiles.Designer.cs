namespace stablematching
{
    partial class Popcreateinputfiles
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
            this.lblNvalue = new System.Windows.Forms.Label();
            this.txtNvalue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNvalue
            // 
            this.lblNvalue.AutoSize = true;
            this.lblNvalue.Location = new System.Drawing.Point(46, 52);
            this.lblNvalue.Name = "lblNvalue";
            this.lblNvalue.Size = new System.Drawing.Size(72, 13);
            this.lblNvalue.TabIndex = 0;
            this.lblNvalue.Text = "Enter N value";
            // 
            // txtNvalue
            // 
            this.txtNvalue.Location = new System.Drawing.Point(125, 52);
            this.txtNvalue.Name = "txtNvalue";
            this.txtNvalue.Size = new System.Drawing.Size(100, 20);
            this.txtNvalue.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(142, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(46, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(206, 88);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(65, 24);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // Popcreateinputfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 148);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNvalue);
            this.Controls.Add(this.lblNvalue);
            this.Name = "Popcreateinputfiles";
            this.Text = "Popcreateinputfiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNvalue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.TextBox txtNvalue;
    }
}