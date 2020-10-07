namespace CPR_nummer_Opgave
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
            this.tbCPR = new System.Windows.Forms.TextBox();
            this.buttonCPR = new System.Windows.Forms.Button();
            this.labelLegit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skriv et CPR-nummer";
            // 
            // tbCPR
            // 
            this.tbCPR.Location = new System.Drawing.Point(13, 30);
            this.tbCPR.Name = "tbCPR";
            this.tbCPR.Size = new System.Drawing.Size(108, 20);
            this.tbCPR.TabIndex = 1;
            // 
            // buttonCPR
            // 
            this.buttonCPR.Location = new System.Drawing.Point(13, 77);
            this.buttonCPR.Name = "buttonCPR";
            this.buttonCPR.Size = new System.Drawing.Size(75, 23);
            this.buttonCPR.TabIndex = 2;
            this.buttonCPR.Text = "Check CPR";
            this.buttonCPR.UseVisualStyleBackColor = true;
            this.buttonCPR.Click += new System.EventHandler(this.buttonCPR_Click);
            // 
            // labelLegit
            // 
            this.labelLegit.AutoSize = true;
            this.labelLegit.Location = new System.Drawing.Point(16, 125);
            this.labelLegit.Name = "labelLegit";
            this.labelLegit.Size = new System.Drawing.Size(47, 13);
            this.labelLegit.TabIndex = 3;
            this.labelLegit.Text = "Checker";
            // 
            // CPRGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(440, 498);
            this.Controls.Add(this.labelLegit);
            this.Controls.Add(this.buttonCPR);
            this.Controls.Add(this.tbCPR);
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
        private System.Windows.Forms.TextBox tbCPR;
        private System.Windows.Forms.Button buttonCPR;
        private System.Windows.Forms.Label labelLegit;
    }
}

