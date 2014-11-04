namespace CopyFiletoWebserver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCopyAssurance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContrLog = new System.Windows.Forms.Button();
            this.btnSomeMath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(112, 99);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Assessment";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCopyAssurance
            // 
            this.btnCopyAssurance.Location = new System.Drawing.Point(15, 99);
            this.btnCopyAssurance.Name = "btnCopyAssurance";
            this.btnCopyAssurance.Size = new System.Drawing.Size(75, 23);
            this.btnCopyAssurance.TabIndex = 1;
            this.btnCopyAssurance.Text = "Assurance";
            this.btnCopyAssurance.UseVisualStyleBackColor = true;
            this.btnCopyAssurance.Click += new System.EventHandler(this.btnCopyAssurance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Copy Access files to CUB:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(47, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoItAll.Properties.Resources.doitalllogo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnContrLog
            // 
            this.btnContrLog.Location = new System.Drawing.Point(15, 161);
            this.btnContrLog.Name = "btnContrLog";
            this.btnContrLog.Size = new System.Drawing.Size(172, 23);
            this.btnContrLog.TabIndex = 6;
            this.btnContrLog.Text = "Update Contribute Log";
            this.btnContrLog.UseVisualStyleBackColor = true;
            this.btnContrLog.Click += new System.EventHandler(this.btnContrLog_Click);
            // 
            // btnSomeMath
            // 
            this.btnSomeMath.Location = new System.Drawing.Point(15, 223);
            this.btnSomeMath.Name = "btnSomeMath";
            this.btnSomeMath.Size = new System.Drawing.Size(75, 23);
            this.btnSomeMath.TabIndex = 7;
            this.btnSomeMath.Text = "Some Math";
            this.btnSomeMath.UseVisualStyleBackColor = true;
            this.btnSomeMath.Click += new System.EventHandler(this.btnSomeMath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSomeMath);
            this.Controls.Add(this.btnContrLog);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCopyAssurance);
            this.Controls.Add(this.btnCopy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Do-It-All";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCopyAssurance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnContrLog;
        private System.Windows.Forms.Button btnSomeMath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

