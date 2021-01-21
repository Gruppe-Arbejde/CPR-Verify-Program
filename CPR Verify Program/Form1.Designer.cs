namespace CPR_Verify_Program
{
    partial class CPRGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPRGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.tbCPR1 = new System.Windows.Forms.TextBox();
            this.buttonCPR = new System.Windows.Forms.Button();
            this.labelValid = new System.Windows.Forms.Label();
            this.tbValidCPR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skriv et CPR-nummer";
            // 
            // tbCPR1
            // 
            this.tbCPR1.Location = new System.Drawing.Point(63, 49);
            this.tbCPR1.Name = "tbCPR1";
            this.tbCPR1.Size = new System.Drawing.Size(135, 20);
            this.tbCPR1.TabIndex = 1;
            // 
            // buttonCPR
            // 
            this.buttonCPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCPR.Location = new System.Drawing.Point(86, 97);
            this.buttonCPR.Name = "buttonCPR";
            this.buttonCPR.Size = new System.Drawing.Size(85, 23);
            this.buttonCPR.TabIndex = 2;
            this.buttonCPR.Text = "Check CPR";
            this.buttonCPR.UseVisualStyleBackColor = true;
            this.buttonCPR.Click += new System.EventHandler(this.buttonCPR_Click);
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValid.Location = new System.Drawing.Point(63, 142);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(90, 16);
            this.labelValid.TabIndex = 3;
            this.labelValid.Text = "Validere CPR";
            // 
            // tbValidCPR
            // 
            this.tbValidCPR.Location = new System.Drawing.Point(63, 161);
            this.tbValidCPR.Multiline = true;
            this.tbValidCPR.Name = "tbValidCPR";
            this.tbValidCPR.ReadOnly = true;
            this.tbValidCPR.Size = new System.Drawing.Size(135, 60);
            this.tbValidCPR.TabIndex = 4;
            // 
            // CPRGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CPR_Verify_Program.Properties.Resources.McLovin_ID;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(256, 233);
            this.Controls.Add(this.tbValidCPR);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.buttonCPR);
            this.Controls.Add(this.tbCPR1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CPRGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPR-Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCPR1;
        private System.Windows.Forms.Button buttonCPR;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.TextBox tbValidCPR;
    }
}

