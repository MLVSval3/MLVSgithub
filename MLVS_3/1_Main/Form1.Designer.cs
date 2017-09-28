namespace MLVS_3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LearnDataSaveBox = new System.Windows.Forms.Button();
            this.TrueFolderOpenBox = new System.Windows.Forms.Button();
            this.FalseFolderOpenBox = new System.Windows.Forms.Button();
            this.TestFolderOpenBox = new System.Windows.Forms.Button();
            this.LearnDataLoadBox = new System.Windows.Forms.Button();
            this.StopAutoRunBox = new System.Windows.Forms.Button();
            this.AutoRunBox = new System.Windows.Forms.Button();
            this.LearnBox = new System.Windows.Forms.Button();
            this.SaveToTestBox = new System.Windows.Forms.Button();
            this.SaveToFalseBox = new System.Windows.Forms.Button();
            this.SaveToTrueBox = new System.Windows.Forms.Button();
            this.TestDataNumBox = new System.Windows.Forms.TextBox();
            this.RunSpeedTextBox = new System.Windows.Forms.TextBox();
            this.BackwardBox = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.Button();
            this.TestDataNumberBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ForwardBox = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.RefreshBox1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.OutputTextBox.Location = new System.Drawing.Point(370, 234);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(100, 30);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camera Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Camera Box";
            // 
            // LearnDataSaveBox
            // 
            this.LearnDataSaveBox.Font = new System.Drawing.Font("굴림", 9F);
            this.LearnDataSaveBox.Location = new System.Drawing.Point(468, 329);
            this.LearnDataSaveBox.Name = "LearnDataSaveBox";
            this.LearnDataSaveBox.Size = new System.Drawing.Size(74, 43);
            this.LearnDataSaveBox.TabIndex = 5;
            this.LearnDataSaveBox.Text = "Svae";
            this.LearnDataSaveBox.UseCompatibleTextRendering = true;
            this.LearnDataSaveBox.UseVisualStyleBackColor = true;
            this.LearnDataSaveBox.Click += new System.EventHandler(this.LearnDataSaveBox_Click);
            // 
            // TrueFolderOpenBox
            // 
            this.TrueFolderOpenBox.Font = new System.Drawing.Font("굴림", 12F);
            this.TrueFolderOpenBox.Location = new System.Drawing.Point(370, 405);
            this.TrueFolderOpenBox.Name = "TrueFolderOpenBox";
            this.TrueFolderOpenBox.Size = new System.Drawing.Size(74, 43);
            this.TrueFolderOpenBox.TabIndex = 6;
            this.TrueFolderOpenBox.Text = "True";
            this.TrueFolderOpenBox.UseVisualStyleBackColor = true;
            this.TrueFolderOpenBox.Click += new System.EventHandler(this.TrueFolderOpenBox_Click);
            // 
            // FalseFolderOpenBox
            // 
            this.FalseFolderOpenBox.Font = new System.Drawing.Font("굴림", 12F);
            this.FalseFolderOpenBox.Location = new System.Drawing.Point(468, 405);
            this.FalseFolderOpenBox.Name = "FalseFolderOpenBox";
            this.FalseFolderOpenBox.Size = new System.Drawing.Size(74, 43);
            this.FalseFolderOpenBox.TabIndex = 7;
            this.FalseFolderOpenBox.Text = "False";
            this.FalseFolderOpenBox.UseVisualStyleBackColor = true;
            this.FalseFolderOpenBox.Click += new System.EventHandler(this.FalseFolderOpenBox_Click);
            // 
            // TestFolderOpenBox
            // 
            this.TestFolderOpenBox.Font = new System.Drawing.Font("굴림", 12F);
            this.TestFolderOpenBox.Location = new System.Drawing.Point(566, 405);
            this.TestFolderOpenBox.Name = "TestFolderOpenBox";
            this.TestFolderOpenBox.Size = new System.Drawing.Size(74, 43);
            this.TestFolderOpenBox.TabIndex = 8;
            this.TestFolderOpenBox.Text = "Test";
            this.TestFolderOpenBox.UseVisualStyleBackColor = true;
            this.TestFolderOpenBox.Click += new System.EventHandler(this.TestFolderOpenBox_Click);
            // 
            // LearnDataLoadBox
            // 
            this.LearnDataLoadBox.Font = new System.Drawing.Font("굴림", 9F);
            this.LearnDataLoadBox.Location = new System.Drawing.Point(566, 329);
            this.LearnDataLoadBox.Name = "LearnDataLoadBox";
            this.LearnDataLoadBox.Size = new System.Drawing.Size(74, 43);
            this.LearnDataLoadBox.TabIndex = 11;
            this.LearnDataLoadBox.Text = "Load";
            this.LearnDataLoadBox.UseVisualStyleBackColor = true;
            this.LearnDataLoadBox.Click += new System.EventHandler(this.LearnDataLoadBox_Click);
            // 
            // StopAutoRunBox
            // 
            this.StopAutoRunBox.Font = new System.Drawing.Font("굴림", 9F);
            this.StopAutoRunBox.Location = new System.Drawing.Point(208, 405);
            this.StopAutoRunBox.Name = "StopAutoRunBox";
            this.StopAutoRunBox.Size = new System.Drawing.Size(74, 43);
            this.StopAutoRunBox.TabIndex = 10;
            this.StopAutoRunBox.Text = "자동실행 종료";
            this.StopAutoRunBox.UseVisualStyleBackColor = true;
            this.StopAutoRunBox.Click += new System.EventHandler(this.StopAutoRunBox_Click);
            // 
            // AutoRunBox
            // 
            this.AutoRunBox.Font = new System.Drawing.Font("굴림", 9F);
            this.AutoRunBox.Location = new System.Drawing.Point(110, 405);
            this.AutoRunBox.Name = "AutoRunBox";
            this.AutoRunBox.Size = new System.Drawing.Size(74, 43);
            this.AutoRunBox.TabIndex = 9;
            this.AutoRunBox.Text = "자동 실행";
            this.AutoRunBox.UseVisualStyleBackColor = true;
            this.AutoRunBox.Click += new System.EventHandler(this.AutoRunBox_Click);
            // 
            // LearnBox
            // 
            this.LearnBox.Font = new System.Drawing.Font("굴림", 9F);
            this.LearnBox.Location = new System.Drawing.Point(370, 329);
            this.LearnBox.Name = "LearnBox";
            this.LearnBox.Size = new System.Drawing.Size(74, 43);
            this.LearnBox.TabIndex = 12;
            this.LearnBox.Text = "Learn";
            this.LearnBox.UseVisualStyleBackColor = true;
            this.LearnBox.Click += new System.EventHandler(this.LearnBox_Click);
            // 
            // SaveToTestBox
            // 
            this.SaveToTestBox.Font = new System.Drawing.Font("굴림", 9F);
            this.SaveToTestBox.Location = new System.Drawing.Point(12, 329);
            this.SaveToTestBox.Name = "SaveToTestBox";
            this.SaveToTestBox.Size = new System.Drawing.Size(74, 43);
            this.SaveToTestBox.TabIndex = 13;
            this.SaveToTestBox.Text = "Test 사진으로";
            this.SaveToTestBox.UseVisualStyleBackColor = true;
            this.SaveToTestBox.Click += new System.EventHandler(this.SaveToTestBox_Click);
            // 
            // SaveToFalseBox
            // 
            this.SaveToFalseBox.Font = new System.Drawing.Font("굴림", 9F);
            this.SaveToFalseBox.Location = new System.Drawing.Point(110, 329);
            this.SaveToFalseBox.Name = "SaveToFalseBox";
            this.SaveToFalseBox.Size = new System.Drawing.Size(74, 43);
            this.SaveToFalseBox.TabIndex = 14;
            this.SaveToFalseBox.Text = "False 사진으로";
            this.SaveToFalseBox.UseVisualStyleBackColor = true;
            this.SaveToFalseBox.Click += new System.EventHandler(this.SaveToFalseBox_Click);
            // 
            // SaveToTrueBox
            // 
            this.SaveToTrueBox.Font = new System.Drawing.Font("굴림", 9F);
            this.SaveToTrueBox.Location = new System.Drawing.Point(208, 329);
            this.SaveToTrueBox.Name = "SaveToTrueBox";
            this.SaveToTrueBox.Size = new System.Drawing.Size(74, 43);
            this.SaveToTrueBox.TabIndex = 15;
            this.SaveToTrueBox.Text = "True 사진으로";
            this.SaveToTrueBox.UseVisualStyleBackColor = true;
            this.SaveToTrueBox.Click += new System.EventHandler(this.SaveToTrueBox_Click);
            // 
            // TestDataNumBox
            // 
            this.TestDataNumBox.Font = new System.Drawing.Font("굴림", 15F);
            this.TestDataNumBox.Location = new System.Drawing.Point(540, 234);
            this.TestDataNumBox.Name = "TestDataNumBox";
            this.TestDataNumBox.Size = new System.Drawing.Size(100, 30);
            this.TestDataNumBox.TabIndex = 16;
            // 
            // RunSpeedTextBox
            // 
            this.RunSpeedTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.RunSpeedTextBox.Location = new System.Drawing.Point(14, 418);
            this.RunSpeedTextBox.Name = "RunSpeedTextBox";
            this.RunSpeedTextBox.Size = new System.Drawing.Size(74, 30);
            this.RunSpeedTextBox.TabIndex = 17;
            // 
            // BackwardBox
            // 
            this.BackwardBox.Font = new System.Drawing.Font("굴림", 20F);
            this.BackwardBox.Location = new System.Drawing.Point(361, 490);
            this.BackwardBox.Name = "BackwardBox";
            this.BackwardBox.Size = new System.Drawing.Size(74, 79);
            this.BackwardBox.TabIndex = 18;
            this.BackwardBox.Text = "<";
            this.BackwardBox.UseVisualStyleBackColor = true;
            this.BackwardBox.Click += new System.EventHandler(this.BackwardBox_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("굴림", 12F);
            this.NumberBox.Location = new System.Drawing.Point(441, 526);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(129, 43);
            this.NumberBox.TabIndex = 19;
            this.NumberBox.Text = "번호 실행";
            this.NumberBox.UseVisualStyleBackColor = true;
            this.NumberBox.Click += new System.EventHandler(this.NumberBox_Click);
            // 
            // TestDataNumberBox
            // 
            this.TestDataNumberBox.Font = new System.Drawing.Font("굴림", 15F);
            this.TestDataNumberBox.Location = new System.Drawing.Point(441, 490);
            this.TestDataNumberBox.Name = "TestDataNumberBox";
            this.TestDataNumberBox.Size = new System.Drawing.Size(129, 30);
            this.TestDataNumberBox.TabIndex = 21;
            this.TestDataNumberBox.TextChanged += new System.EventHandler(this.TestDataNumberBox_TextChanged);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(370, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 14);
            this.label.TabIndex = 31;
            this.label.Text = "ImageBox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "판별 결과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "테스트 데이터 수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "테스트 데이터 번호";
            // 
            // ForwardBox
            // 
            this.ForwardBox.Font = new System.Drawing.Font("굴림", 20F);
            this.ForwardBox.Location = new System.Drawing.Point(576, 490);
            this.ForwardBox.Name = "ForwardBox";
            this.ForwardBox.Size = new System.Drawing.Size(74, 79);
            this.ForwardBox.TabIndex = 26;
            this.ForwardBox.Text = ">";
            this.ForwardBox.UseVisualStyleBackColor = true;
            this.ForwardBox.Click += new System.EventHandler(this.ForwardBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "해당 폴더 열기";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "True False 폴더의 데이터 학습";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "카메라의 이미지를 해당 폴더로 저장";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 40F);
            this.label10.Location = new System.Drawing.Point(22, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 54);
            this.label10.TabIndex = 30;
            this.label10.Text = "MLVS_var3";
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(370, 24);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(270, 184);
            this.ImageBox.TabIndex = 2;
            this.ImageBox.TabStop = false;
            // 
            // CameraBox
            // 
            this.CameraBox.Location = new System.Drawing.Point(12, 24);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(270, 184);
            this.CameraBox.TabIndex = 0;
            this.CameraBox.TabStop = false;
            // 
            // RefreshBox1
            // 
            this.RefreshBox1.BackgroundImage = global::MLVS_3.Properties.Resources.KakaoTalk_20170927_141741557;
            this.RefreshBox1.Location = new System.Drawing.Point(627, -2);
            this.RefreshBox1.Name = "RefreshBox1";
            this.RefreshBox1.Size = new System.Drawing.Size(25, 25);
            this.RefreshBox1.TabIndex = 32;
            this.RefreshBox1.UseVisualStyleBackColor = true;
            this.RefreshBox1.Click += new System.EventHandler(this.RefreshBox1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 581);
            this.Controls.Add(this.RefreshBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ForwardBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TestDataNumberBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.BackwardBox);
            this.Controls.Add(this.RunSpeedTextBox);
            this.Controls.Add(this.TestDataNumBox);
            this.Controls.Add(this.SaveToTrueBox);
            this.Controls.Add(this.SaveToFalseBox);
            this.Controls.Add(this.SaveToTestBox);
            this.Controls.Add(this.LearnBox);
            this.Controls.Add(this.LearnDataLoadBox);
            this.Controls.Add(this.StopAutoRunBox);
            this.Controls.Add(this.AutoRunBox);
            this.Controls.Add(this.TestFolderOpenBox);
            this.Controls.Add(this.FalseFolderOpenBox);
            this.Controls.Add(this.TrueFolderOpenBox);
            this.Controls.Add(this.LearnDataSaveBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.CameraBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLVS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox CameraBox;
        public System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TrueFolderOpenBox;
        private System.Windows.Forms.Button FalseFolderOpenBox;
        private System.Windows.Forms.Button TestFolderOpenBox;
        private System.Windows.Forms.Button LearnDataLoadBox;
        private System.Windows.Forms.Button LearnBox;
        private System.Windows.Forms.Button SaveToTestBox;
        private System.Windows.Forms.Button SaveToFalseBox;
        private System.Windows.Forms.Button SaveToTrueBox;
        private System.Windows.Forms.TextBox TestDataNumberBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RefreshBox1;
        public System.Windows.Forms.Timer timer2;
        protected System.Windows.Forms.TextBox TestDataNumBox;
        protected internal System.Windows.Forms.Button BackwardBox;
        protected internal System.Windows.Forms.TextBox OutputTextBox;
        protected internal System.Windows.Forms.Button StopAutoRunBox;
        protected internal System.Windows.Forms.Button AutoRunBox;
        protected internal System.Windows.Forms.TextBox RunSpeedTextBox;
        protected internal System.Windows.Forms.Button NumberBox;
        protected internal System.Windows.Forms.Button ForwardBox;
        protected internal System.Windows.Forms.Button LearnDataSaveBox;
    }
}

