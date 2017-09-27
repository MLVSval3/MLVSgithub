namespace MLVS_3._1_Main.anotherForm
{
    partial class LearnedDataNameForm
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
            this.LearnedDataText = new System.Windows.Forms.TextBox();
            this.SaveTheName = new System.Windows.Forms.Button();
            this.CansleBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // LearnedDataText
            // 
            this.LearnedDataText.Font = new System.Drawing.Font("굴림", 15F);
            this.LearnedDataText.Location = new System.Drawing.Point(53, 76);
            this.LearnedDataText.Name = "LearnedDataText";
            this.LearnedDataText.Size = new System.Drawing.Size(142, 30);
            this.LearnedDataText.TabIndex = 1;
            this.LearnedDataText.TextChanged += new System.EventHandler(this.LearnedDataText_TextChanged);
            // 
            // SaveTheName
            // 
            this.SaveTheName.Location = new System.Drawing.Point(53, 117);
            this.SaveTheName.Name = "SaveTheName";
            this.SaveTheName.Size = new System.Drawing.Size(63, 23);
            this.SaveTheName.TabIndex = 2;
            this.SaveTheName.Text = "확인";
            this.SaveTheName.UseVisualStyleBackColor = true;
            this.SaveTheName.Click += new System.EventHandler(this.SaveTheName_Click);
            // 
            // CansleBox
            // 
            this.CansleBox.Location = new System.Drawing.Point(132, 117);
            this.CansleBox.Name = "CansleBox";
            this.CansleBox.Size = new System.Drawing.Size(63, 23);
            this.CansleBox.TabIndex = 3;
            this.CansleBox.Text = "취소";
            this.CansleBox.UseVisualStyleBackColor = true;
            this.CansleBox.Click += new System.EventHandler(this.CansleBox_Click);
            // 
            // LearnedDataNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 152);
            this.Controls.Add(this.CansleBox);
            this.Controls.Add(this.SaveTheName);
            this.Controls.Add(this.LearnedDataText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LearnedDataNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearnedDataNameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LearnedDataText;
        private System.Windows.Forms.Button SaveTheName;
        private System.Windows.Forms.Button CansleBox;
    }
}