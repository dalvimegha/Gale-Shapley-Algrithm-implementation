namespace stablematching
{
    partial class Mainform
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
            this.btnstablematching = new System.Windows.Forms.Button();
            this.btnN10differentfiles = new System.Windows.Forms.Button();
            this.btnN10samefiles = new System.Windows.Forms.Button();
            this.btnN1510152050100values = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxnvaluedisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnstablematching
            // 
            this.btnstablematching.Location = new System.Drawing.Point(2, 81);
            this.btnstablematching.Name = "btnstablematching";
            this.btnstablematching.Size = new System.Drawing.Size(253, 23);
            this.btnstablematching.TabIndex = 0;
            this.btnstablematching.Text = "Stable Matching ";
            this.btnstablematching.UseVisualStyleBackColor = true;
            this.btnstablematching.Click += new System.EventHandler(this.btnstablematching_Click);
            // 
            // btnN10differentfiles
            // 
            this.btnN10differentfiles.Location = new System.Drawing.Point(1, 136);
            this.btnN10differentfiles.Name = "btnN10differentfiles";
            this.btnN10differentfiles.Size = new System.Drawing.Size(254, 23);
            this.btnN10differentfiles.TabIndex = 1;
            this.btnN10differentfiles.Text = "Stable matching with n=10 and different input files";
            this.btnN10differentfiles.UseVisualStyleBackColor = true;
            this.btnN10differentfiles.Click += new System.EventHandler(this.btnN10differentfiles_Click);
            // 
            // btnN10samefiles
            // 
            this.btnN10samefiles.Location = new System.Drawing.Point(1, 204);
            this.btnN10samefiles.Name = "btnN10samefiles";
            this.btnN10samefiles.Size = new System.Drawing.Size(254, 23);
            this.btnN10samefiles.TabIndex = 2;
            this.btnN10samefiles.Text = "Stable Matching with n=10 and same input files";
            this.btnN10samefiles.UseVisualStyleBackColor = true;
            this.btnN10samefiles.Click += new System.EventHandler(this.btnN10samefiles_Click);
            // 
            // btnN1510152050100values
            // 
            this.btnN1510152050100values.Location = new System.Drawing.Point(1, 273);
            this.btnN1510152050100values.Name = "btnN1510152050100values";
            this.btnN1510152050100values.Size = new System.Drawing.Size(254, 23);
            this.btnN1510152050100values.TabIndex = 3;
            this.btnN1510152050100values.Text = "Stable Matching with n=1,5,10,15,20,50,100 ";
            this.btnN1510152050100values.UseVisualStyleBackColor = true;
            this.btnN1510152050100values.Click += new System.EventHandler(this.btnN1510152050100values_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtboxnvaluedisplay);
            this.panel1.Location = new System.Drawing.Point(261, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 497);
            this.panel1.TabIndex = 5;
            // 
            // txtboxnvaluedisplay
            // 
            this.txtboxnvaluedisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtboxnvaluedisplay.Location = new System.Drawing.Point(27, 79);
            this.txtboxnvaluedisplay.Multiline = true;
            this.txtboxnvaluedisplay.Name = "txtboxnvaluedisplay";
            this.txtboxnvaluedisplay.ReadOnly = true;
            this.txtboxnvaluedisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxnvaluedisplay.Size = new System.Drawing.Size(459, 363);
            this.txtboxnvaluedisplay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Running time for the given input files";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnN1510152050100values);
            this.Controls.Add(this.btnN10samefiles);
            this.Controls.Add(this.btnN10differentfiles);
            this.Controls.Add(this.btnstablematching);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstablematching;
        private System.Windows.Forms.Button btnN10differentfiles;
        private System.Windows.Forms.Button btnN10samefiles;
        private System.Windows.Forms.Button btnN1510152050100values;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxnvaluedisplay;
        private System.Windows.Forms.Label label1;
    }
}