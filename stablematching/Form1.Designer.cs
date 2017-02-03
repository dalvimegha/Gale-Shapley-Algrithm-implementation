namespace stablematching
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
            this.browse = new System.Windows.Forms.Button();
            this.testtextbox = new System.Windows.Forms.TextBox();
            this.txtboxdisplayfilerestults = new System.Windows.Forms.TextBox();
            this.txttimer = new System.Windows.Forms.TextBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.lblselectfile = new System.Windows.Forms.Label();
            this.txtboxfile = new System.Windows.Forms.TextBox();
            this.btncreateinputfiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(507, 21);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // testtextbox
            // 
            this.testtextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.testtextbox.Location = new System.Drawing.Point(296, 75);
            this.testtextbox.Multiline = true;
            this.testtextbox.Name = "testtextbox";
            this.testtextbox.ReadOnly = true;
            this.testtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testtextbox.Size = new System.Drawing.Size(364, 269);
            this.testtextbox.TabIndex = 2;
            // 
            // txtboxdisplayfilerestults
            // 
            this.txtboxdisplayfilerestults.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtboxdisplayfilerestults.Location = new System.Drawing.Point(12, 75);
            this.txtboxdisplayfilerestults.Multiline = true;
            this.txtboxdisplayfilerestults.Name = "txtboxdisplayfilerestults";
            this.txtboxdisplayfilerestults.ReadOnly = true;
            this.txtboxdisplayfilerestults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxdisplayfilerestults.Size = new System.Drawing.Size(287, 269);
            this.txtboxdisplayfilerestults.TabIndex = 3;
            // 
            // txttimer
            // 
            this.txttimer.Location = new System.Drawing.Point(367, 357);
            this.txttimer.Name = "txttimer";
            this.txttimer.ReadOnly = true;
            this.txttimer.Size = new System.Drawing.Size(100, 20);
            this.txttimer.TabIndex = 4;
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(312, 363);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(44, 15);
            this.lbltimer.TabIndex = 5;
            this.lbltimer.Text = "Timer";
            // 
            // lblselectfile
            // 
            this.lblselectfile.AutoSize = true;
            this.lblselectfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectfile.Location = new System.Drawing.Point(10, 26);
            this.lblselectfile.Name = "lblselectfile";
            this.lblselectfile.Size = new System.Drawing.Size(73, 15);
            this.lblselectfile.TabIndex = 6;
            this.lblselectfile.Text = "File Name";
            // 
            // txtboxfile
            // 
            this.txtboxfile.Location = new System.Drawing.Point(89, 21);
            this.txtboxfile.Name = "txtboxfile";
            this.txtboxfile.ReadOnly = true;
            this.txtboxfile.Size = new System.Drawing.Size(403, 20);
            this.txtboxfile.TabIndex = 7;
            // 
            // btncreateinputfiles
            // 
            this.btncreateinputfiles.Location = new System.Drawing.Point(12, 363);
            this.btncreateinputfiles.Name = "btncreateinputfiles";
            this.btncreateinputfiles.Size = new System.Drawing.Size(104, 23);
            this.btncreateinputfiles.TabIndex = 8;
            this.btncreateinputfiles.Text = "Create input files";
            this.btncreateinputfiles.UseVisualStyleBackColor = true;
            this.btncreateinputfiles.Click += new System.EventHandler(this.btncreateinputfiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 432);
            this.Controls.Add(this.btncreateinputfiles);
            this.Controls.Add(this.txtboxfile);
            this.Controls.Add(this.lblselectfile);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.txttimer);
            this.Controls.Add(this.txtboxdisplayfilerestults);
            this.Controls.Add(this.testtextbox);
            this.Controls.Add(this.browse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox testtextbox;
        private System.Windows.Forms.TextBox txtboxdisplayfilerestults;
        private System.Windows.Forms.TextBox txttimer;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lblselectfile;
        private System.Windows.Forms.TextBox txtboxfile;
        private System.Windows.Forms.Button btncreateinputfiles;
    }
}

