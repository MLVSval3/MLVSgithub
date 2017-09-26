namespace MLVS_3._1_Main.anotherForm
{
    partial class DataLoadForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LoadBox = new System.Windows.Forms.Button();
            this.CansleBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(34, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 136);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LoadBox
            // 
            this.LoadBox.Location = new System.Drawing.Point(34, 178);
            this.LoadBox.Name = "LoadBox";
            this.LoadBox.Size = new System.Drawing.Size(87, 23);
            this.LoadBox.TabIndex = 1;
            this.LoadBox.Text = "확인";
            this.LoadBox.UseVisualStyleBackColor = true;
            this.LoadBox.Click += new System.EventHandler(this.LoadBox_Click);
            // 
            // CansleBox
            // 
            this.CansleBox.Location = new System.Drawing.Point(158, 178);
            this.CansleBox.Name = "CansleBox";
            this.CansleBox.Size = new System.Drawing.Size(86, 23);
            this.CansleBox.TabIndex = 2;
            this.CansleBox.Text = "취소";
            this.CansleBox.UseVisualStyleBackColor = true;
            this.CansleBox.Click += new System.EventHandler(this.CansleBox_Click);
            // 
            // DataLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.Controls.Add(this.CansleBox);
            this.Controls.Add(this.LoadBox);
            this.Controls.Add(this.listBox1);
            this.Name = "DataLoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataLoadForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoadBox;
        private System.Windows.Forms.Button CansleBox;
    }
}