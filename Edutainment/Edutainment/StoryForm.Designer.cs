namespace Edutainment
{
    partial class StoryForm
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
            this.pnlOptionSet = new System.Windows.Forms.Panel();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.lblDescriptiveText = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlOptionSet
            // 
            this.pnlOptionSet.Location = new System.Drawing.Point(2, 111);
            this.pnlOptionSet.Name = "pnlOptionSet";
            this.pnlOptionSet.Size = new System.Drawing.Size(569, 207);
            this.pnlOptionSet.TabIndex = 0;
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Location = new System.Drawing.Point(61, 9);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(88, 13);
            this.lblShortDescription.TabIndex = 1;
            this.lblShortDescription.Text = "Short Description";
            // 
            // lblDescriptiveText
            // 
            this.lblDescriptiveText.AutoSize = true;
            this.lblDescriptiveText.Location = new System.Drawing.Point(61, 41);
            this.lblDescriptiveText.Name = "lblDescriptiveText";
            this.lblDescriptiveText.Size = new System.Drawing.Size(84, 13);
            this.lblDescriptiveText.TabIndex = 2;
            this.lblDescriptiveText.Text = "Descriptive Text";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(61, 324);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(248, 324);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(583, 372);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblDescriptiveText);
            this.Controls.Add(this.lblShortDescription);
            this.Controls.Add(this.pnlOptionSet);
            this.Name = "StoryForm";
            this.Text = "Story";
            this.Load += new System.EventHandler(this.StoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptionSet;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.Label lblDescriptiveText;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSave;
    }
}