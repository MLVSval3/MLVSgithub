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
            this.RefreshBox1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CameraBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RL_CameraBox = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RL_NumberOfTestDataTextBox = new System.Windows.Forms.TextBox();
            this.RL_ForwardBox = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.RL_LabelOutPutTextBox = new System.Windows.Forms.TextBox();
            this.RL_ChoiseTestNumberTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.RL_RunNumberBox = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.RL_BackwardBox = new System.Windows.Forms.Button();
            this.RL_ImageBox = new System.Windows.Forms.PictureBox();
            this.RL_SelectAutoTimeTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.RL_SaveToTrueFolderBox = new System.Windows.Forms.Button();
            this.RL_LearnDataSaveBox = new System.Windows.Forms.Button();
            this.RL_SaveToFalseFolderBox = new System.Windows.Forms.Button();
            this.RL_OpenTrueFolderBox = new System.Windows.Forms.Button();
            this.RL_SaveToTestFolderBox = new System.Windows.Forms.Button();
            this.RL_OpenFalseFolderBox = new System.Windows.Forms.Button();
            this.RL_LearnBox = new System.Windows.Forms.Button();
            this.RL_OpenTestFolderBox = new System.Windows.Forms.Button();
            this.RL_LearnDataRoadBox = new System.Windows.Forms.Button();
            this.RL_AotoRunBox = new System.Windows.Forms.Button();
            this.RL_StopAotoRunBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RL_CameraBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RL_ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.OutputTextBox.Location = new System.Drawing.Point(352, 240);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(100, 30);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LearnDataSaveBox
            // 
            this.LearnDataSaveBox.Font = new System.Drawing.Font("굴림", 9F);
            this.LearnDataSaveBox.Location = new System.Drawing.Point(452, 313);
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
            this.TrueFolderOpenBox.Location = new System.Drawing.Point(354, 389);
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
            this.FalseFolderOpenBox.Location = new System.Drawing.Point(452, 389);
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
            this.TestFolderOpenBox.Location = new System.Drawing.Point(550, 389);
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
            this.LearnDataLoadBox.Location = new System.Drawing.Point(550, 313);
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
            this.StopAutoRunBox.Location = new System.Drawing.Point(204, 389);
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
            this.AutoRunBox.Location = new System.Drawing.Point(106, 389);
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
            this.LearnBox.Location = new System.Drawing.Point(354, 313);
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
            this.SaveToTestBox.Location = new System.Drawing.Point(8, 313);
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
            this.SaveToFalseBox.Location = new System.Drawing.Point(106, 313);
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
            this.SaveToTrueBox.Location = new System.Drawing.Point(204, 313);
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
            this.TestDataNumBox.Location = new System.Drawing.Point(522, 240);
            this.TestDataNumBox.Name = "TestDataNumBox";
            this.TestDataNumBox.Size = new System.Drawing.Size(100, 30);
            this.TestDataNumBox.TabIndex = 16;
            // 
            // RunSpeedTextBox
            // 
            this.RunSpeedTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.RunSpeedTextBox.Location = new System.Drawing.Point(10, 402);
            this.RunSpeedTextBox.Name = "RunSpeedTextBox";
            this.RunSpeedTextBox.Size = new System.Drawing.Size(74, 30);
            this.RunSpeedTextBox.TabIndex = 17;
            // 
            // BackwardBox
            // 
            this.BackwardBox.Font = new System.Drawing.Font("굴림", 20F);
            this.BackwardBox.Location = new System.Drawing.Point(345, 474);
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
            this.NumberBox.Location = new System.Drawing.Point(425, 510);
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
            this.TestDataNumberBox.Location = new System.Drawing.Point(425, 474);
            this.TestDataNumberBox.Name = "TestDataNumberBox";
            this.TestDataNumberBox.Size = new System.Drawing.Size(129, 30);
            this.TestDataNumberBox.TabIndex = 21;
            this.TestDataNumberBox.TextChanged += new System.EventHandler(this.TestDataNumberBox_TextChanged);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(364, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 14);
            this.label.TabIndex = 31;
            this.label.Text = "ImageBox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "판별 결과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "테스트 데이터 수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "테스트 데이터 번호";
            // 
            // ForwardBox
            // 
            this.ForwardBox.Font = new System.Drawing.Font("굴림", 20F);
            this.ForwardBox.Location = new System.Drawing.Point(560, 474);
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
            this.label7.Location = new System.Drawing.Point(352, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "해당 폴더 열기";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "True False 폴더의 데이터 학습";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "카메라의 이미지를 해당 폴더로 저장";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 40F);
            this.label10.Location = new System.Drawing.Point(6, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 54);
            this.label10.TabIndex = 30;
            this.label10.Text = "MLVS_var3";
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(364, 25);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(270, 184);
            this.ImageBox.TabIndex = 2;
            this.ImageBox.TabStop = false;
            // 
            // RefreshBox1
            // 
            this.RefreshBox1.BackgroundImage = global::MLVS_3.Properties.Resources.KakaoTalk_20170927_141741557;
            this.RefreshBox1.Location = new System.Drawing.Point(639, 3);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.RefreshBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.CameraBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TestDataNumBox);
            this.tabPage1.Controls.Add(this.ForwardBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.OutputTextBox);
            this.tabPage1.Controls.Add(this.TestDataNumberBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.NumberBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.BackwardBox);
            this.tabPage1.Controls.Add(this.ImageBox);
            this.tabPage1.Controls.Add(this.RunSpeedTextBox);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.SaveToTrueBox);
            this.tabPage1.Controls.Add(this.LearnDataSaveBox);
            this.tabPage1.Controls.Add(this.SaveToFalseBox);
            this.tabPage1.Controls.Add(this.TrueFolderOpenBox);
            this.tabPage1.Controls.Add(this.SaveToTestBox);
            this.tabPage1.Controls.Add(this.FalseFolderOpenBox);
            this.tabPage1.Controls.Add(this.LearnBox);
            this.tabPage1.Controls.Add(this.TestFolderOpenBox);
            this.tabPage1.Controls.Add(this.LearnDataLoadBox);
            this.tabPage1.Controls.Add(this.AutoRunBox);
            this.tabPage1.Controls.Add(this.StopAutoRunBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KNN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CameraBox
            // 
            this.CameraBox.Location = new System.Drawing.Point(8, 25);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(270, 184);
            this.CameraBox.TabIndex = 0;
            this.CameraBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Camera Box";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 615);
            this.tabControl1.TabIndex = 33;
            this.tabControl1.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.RL_CameraBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.RL_NumberOfTestDataTextBox);
            this.tabPage2.Controls.Add(this.RL_ForwardBox);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.RL_LabelOutPutTextBox);
            this.tabPage2.Controls.Add(this.RL_ChoiseTestNumberTextBox);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.RL_RunNumberBox);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.RL_BackwardBox);
            this.tabPage2.Controls.Add(this.RL_ImageBox);
            this.tabPage2.Controls.Add(this.RL_SelectAutoTimeTextBox);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.RL_SaveToTrueFolderBox);
            this.tabPage2.Controls.Add(this.RL_LearnDataSaveBox);
            this.tabPage2.Controls.Add(this.RL_SaveToFalseFolderBox);
            this.tabPage2.Controls.Add(this.RL_OpenTrueFolderBox);
            this.tabPage2.Controls.Add(this.RL_SaveToTestFolderBox);
            this.tabPage2.Controls.Add(this.RL_OpenFalseFolderBox);
            this.tabPage2.Controls.Add(this.RL_LearnBox);
            this.tabPage2.Controls.Add(this.RL_OpenTestFolderBox);
            this.tabPage2.Controls.Add(this.RL_LearnDataRoadBox);
            this.tabPage2.Controls.Add(this.RL_AotoRunBox);
            this.tabPage2.Controls.Add(this.RL_StopAotoRunBox);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LogisticRegression";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 12);
            this.label1.TabIndex = 59;
            this.label1.Text = "True False 폴더의 데이터 학습";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 40F);
            this.label3.Location = new System.Drawing.Point(6, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 54);
            this.label3.TabIndex = 61;
            this.label3.Text = "MLVS_var3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 12);
            this.label11.TabIndex = 60;
            this.label11.Text = "카메라의 이미지를 해당 폴더로 저장";
            // 
            // RL_CameraBox
            // 
            this.RL_CameraBox.Location = new System.Drawing.Point(8, 25);
            this.RL_CameraBox.Name = "RL_CameraBox";
            this.RL_CameraBox.Size = new System.Drawing.Size(270, 184);
            this.RL_CameraBox.TabIndex = 34;
            this.RL_CameraBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "Camera Box";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(352, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 12);
            this.label13.TabIndex = 58;
            this.label13.Text = "해당 폴더 열기";
            // 
            // RL_NumberOfTestDataTextBox
            // 
            this.RL_NumberOfTestDataTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.RL_NumberOfTestDataTextBox.Location = new System.Drawing.Point(522, 240);
            this.RL_NumberOfTestDataTextBox.Name = "RL_NumberOfTestDataTextBox";
            this.RL_NumberOfTestDataTextBox.Size = new System.Drawing.Size(100, 30);
            this.RL_NumberOfTestDataTextBox.TabIndex = 49;
            // 
            // RL_ForwardBox
            // 
            this.RL_ForwardBox.Font = new System.Drawing.Font("굴림", 20F);
            this.RL_ForwardBox.Location = new System.Drawing.Point(560, 474);
            this.RL_ForwardBox.Name = "RL_ForwardBox";
            this.RL_ForwardBox.Size = new System.Drawing.Size(74, 79);
            this.RL_ForwardBox.TabIndex = 57;
            this.RL_ForwardBox.Text = ">";
            this.RL_ForwardBox.UseVisualStyleBackColor = true;
            this.RL_ForwardBox.Click += new System.EventHandler(this.RL_ForwardBox_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(436, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 12);
            this.label14.TabIndex = 56;
            this.label14.Text = "테스트 데이터 번호";
            // 
            // RL_LabelOutPutTextBox
            // 
            this.RL_LabelOutPutTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.RL_LabelOutPutTextBox.Location = new System.Drawing.Point(352, 240);
            this.RL_LabelOutPutTextBox.Name = "RL_LabelOutPutTextBox";
            this.RL_LabelOutPutTextBox.Size = new System.Drawing.Size(100, 30);
            this.RL_LabelOutPutTextBox.TabIndex = 35;
            // 
            // RL_ChoiseTestNumberTextBox
            // 
            this.RL_ChoiseTestNumberTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.RL_ChoiseTestNumberTextBox.Location = new System.Drawing.Point(425, 474);
            this.RL_ChoiseTestNumberTextBox.Name = "RL_ChoiseTestNumberTextBox";
            this.RL_ChoiseTestNumberTextBox.Size = new System.Drawing.Size(129, 30);
            this.RL_ChoiseTestNumberTextBox.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 12);
            this.label15.TabIndex = 54;
            this.label15.Text = "판별 결과";
            // 
            // RL_RunNumberBox
            // 
            this.RL_RunNumberBox.Font = new System.Drawing.Font("굴림", 12F);
            this.RL_RunNumberBox.Location = new System.Drawing.Point(425, 510);
            this.RL_RunNumberBox.Name = "RL_RunNumberBox";
            this.RL_RunNumberBox.Size = new System.Drawing.Size(129, 43);
            this.RL_RunNumberBox.TabIndex = 52;
            this.RL_RunNumberBox.Text = "번호 실행";
            this.RL_RunNumberBox.UseVisualStyleBackColor = true;
            this.RL_RunNumberBox.Click += new System.EventHandler(this.RL_RunNumberBox_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(520, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 12);
            this.label16.TabIndex = 55;
            this.label16.Text = "테스트 데이터 수";
            // 
            // RL_BackwardBox
            // 
            this.RL_BackwardBox.Font = new System.Drawing.Font("굴림", 20F);
            this.RL_BackwardBox.Location = new System.Drawing.Point(345, 474);
            this.RL_BackwardBox.Name = "RL_BackwardBox";
            this.RL_BackwardBox.Size = new System.Drawing.Size(74, 79);
            this.RL_BackwardBox.TabIndex = 51;
            this.RL_BackwardBox.Text = "<";
            this.RL_BackwardBox.UseVisualStyleBackColor = true;
            this.RL_BackwardBox.Click += new System.EventHandler(this.RL_BackwardBox_Click);
            // 
            // RL_ImageBox
            // 
            this.RL_ImageBox.Location = new System.Drawing.Point(364, 25);
            this.RL_ImageBox.Name = "RL_ImageBox";
            this.RL_ImageBox.Size = new System.Drawing.Size(270, 184);
            this.RL_ImageBox.TabIndex = 36;
            this.RL_ImageBox.TabStop = false;
            // 
            // RL_SelectAutoTimeTextBox
            // 
            this.RL_SelectAutoTimeTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.RL_SelectAutoTimeTextBox.Location = new System.Drawing.Point(10, 402);
            this.RL_SelectAutoTimeTextBox.Name = "RL_SelectAutoTimeTextBox";
            this.RL_SelectAutoTimeTextBox.Size = new System.Drawing.Size(74, 30);
            this.RL_SelectAutoTimeTextBox.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(364, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 14);
            this.label17.TabIndex = 62;
            this.label17.Text = "ImageBox";
            // 
            // RL_SaveToTrueFolderBox
            // 
            this.RL_SaveToTrueFolderBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_SaveToTrueFolderBox.Location = new System.Drawing.Point(204, 313);
            this.RL_SaveToTrueFolderBox.Name = "RL_SaveToTrueFolderBox";
            this.RL_SaveToTrueFolderBox.Size = new System.Drawing.Size(74, 43);
            this.RL_SaveToTrueFolderBox.TabIndex = 48;
            this.RL_SaveToTrueFolderBox.Text = "True 사진으로";
            this.RL_SaveToTrueFolderBox.UseVisualStyleBackColor = true;
            this.RL_SaveToTrueFolderBox.Click += new System.EventHandler(this.RL_SaveToTrueFolderBox_Click);
            // 
            // RL_LearnDataSaveBox
            // 
            this.RL_LearnDataSaveBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_LearnDataSaveBox.Location = new System.Drawing.Point(452, 313);
            this.RL_LearnDataSaveBox.Name = "RL_LearnDataSaveBox";
            this.RL_LearnDataSaveBox.Size = new System.Drawing.Size(74, 43);
            this.RL_LearnDataSaveBox.TabIndex = 38;
            this.RL_LearnDataSaveBox.Text = "Svae";
            this.RL_LearnDataSaveBox.UseCompatibleTextRendering = true;
            this.RL_LearnDataSaveBox.UseVisualStyleBackColor = true;
            this.RL_LearnDataSaveBox.Click += new System.EventHandler(this.RL_LearnDataSaveBox_Click);
            // 
            // RL_SaveToFalseFolderBox
            // 
            this.RL_SaveToFalseFolderBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_SaveToFalseFolderBox.Location = new System.Drawing.Point(106, 313);
            this.RL_SaveToFalseFolderBox.Name = "RL_SaveToFalseFolderBox";
            this.RL_SaveToFalseFolderBox.Size = new System.Drawing.Size(74, 43);
            this.RL_SaveToFalseFolderBox.TabIndex = 47;
            this.RL_SaveToFalseFolderBox.Text = "False 사진으로";
            this.RL_SaveToFalseFolderBox.UseVisualStyleBackColor = true;
            this.RL_SaveToFalseFolderBox.Click += new System.EventHandler(this.RL_SaveToFalseFolderBox_Click);
            // 
            // RL_OpenTrueFolderBox
            // 
            this.RL_OpenTrueFolderBox.Font = new System.Drawing.Font("굴림", 12F);
            this.RL_OpenTrueFolderBox.Location = new System.Drawing.Point(354, 389);
            this.RL_OpenTrueFolderBox.Name = "RL_OpenTrueFolderBox";
            this.RL_OpenTrueFolderBox.Size = new System.Drawing.Size(74, 43);
            this.RL_OpenTrueFolderBox.TabIndex = 39;
            this.RL_OpenTrueFolderBox.Text = "True";
            this.RL_OpenTrueFolderBox.UseVisualStyleBackColor = true;
            this.RL_OpenTrueFolderBox.Click += new System.EventHandler(this.RL_OpenTrueFolderBox_Click);
            // 
            // RL_SaveToTestFolderBox
            // 
            this.RL_SaveToTestFolderBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_SaveToTestFolderBox.Location = new System.Drawing.Point(8, 313);
            this.RL_SaveToTestFolderBox.Name = "RL_SaveToTestFolderBox";
            this.RL_SaveToTestFolderBox.Size = new System.Drawing.Size(74, 43);
            this.RL_SaveToTestFolderBox.TabIndex = 46;
            this.RL_SaveToTestFolderBox.Text = "Test 사진으로";
            this.RL_SaveToTestFolderBox.UseVisualStyleBackColor = true;
            this.RL_SaveToTestFolderBox.Click += new System.EventHandler(this.RL_SaveToTestFolderBox_Click);
            // 
            // RL_OpenFalseFolderBox
            // 
            this.RL_OpenFalseFolderBox.Font = new System.Drawing.Font("굴림", 12F);
            this.RL_OpenFalseFolderBox.Location = new System.Drawing.Point(452, 389);
            this.RL_OpenFalseFolderBox.Name = "RL_OpenFalseFolderBox";
            this.RL_OpenFalseFolderBox.Size = new System.Drawing.Size(74, 43);
            this.RL_OpenFalseFolderBox.TabIndex = 40;
            this.RL_OpenFalseFolderBox.Text = "False";
            this.RL_OpenFalseFolderBox.UseVisualStyleBackColor = true;
            this.RL_OpenFalseFolderBox.Click += new System.EventHandler(this.RL_OpenFalseFolderBox_Click);
            // 
            // RL_LearnBox
            // 
            this.RL_LearnBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_LearnBox.Location = new System.Drawing.Point(354, 313);
            this.RL_LearnBox.Name = "RL_LearnBox";
            this.RL_LearnBox.Size = new System.Drawing.Size(74, 43);
            this.RL_LearnBox.TabIndex = 45;
            this.RL_LearnBox.Text = "Learn";
            this.RL_LearnBox.UseVisualStyleBackColor = true;
            this.RL_LearnBox.Click += new System.EventHandler(this.RL_LearnBox_Click);
            // 
            // RL_OpenTestFolderBox
            // 
            this.RL_OpenTestFolderBox.Font = new System.Drawing.Font("굴림", 12F);
            this.RL_OpenTestFolderBox.Location = new System.Drawing.Point(550, 389);
            this.RL_OpenTestFolderBox.Name = "RL_OpenTestFolderBox";
            this.RL_OpenTestFolderBox.Size = new System.Drawing.Size(74, 43);
            this.RL_OpenTestFolderBox.TabIndex = 41;
            this.RL_OpenTestFolderBox.Text = "Test";
            this.RL_OpenTestFolderBox.UseVisualStyleBackColor = true;
            this.RL_OpenTestFolderBox.Click += new System.EventHandler(this.RL_OpenTestFolderBox_Click);
            // 
            // RL_LearnDataRoadBox
            // 
            this.RL_LearnDataRoadBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_LearnDataRoadBox.Location = new System.Drawing.Point(550, 313);
            this.RL_LearnDataRoadBox.Name = "RL_LearnDataRoadBox";
            this.RL_LearnDataRoadBox.Size = new System.Drawing.Size(74, 43);
            this.RL_LearnDataRoadBox.TabIndex = 44;
            this.RL_LearnDataRoadBox.Text = "Load";
            this.RL_LearnDataRoadBox.UseVisualStyleBackColor = true;
            this.RL_LearnDataRoadBox.Click += new System.EventHandler(this.RL_LearnDataRoadBox_Click);
            // 
            // RL_AotoRunBox
            // 
            this.RL_AotoRunBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_AotoRunBox.Location = new System.Drawing.Point(106, 389);
            this.RL_AotoRunBox.Name = "RL_AotoRunBox";
            this.RL_AotoRunBox.Size = new System.Drawing.Size(74, 43);
            this.RL_AotoRunBox.TabIndex = 42;
            this.RL_AotoRunBox.Text = "자동 실행";
            this.RL_AotoRunBox.UseVisualStyleBackColor = true;
            this.RL_AotoRunBox.Click += new System.EventHandler(this.RL_AotoRunBox_Click);
            // 
            // RL_StopAotoRunBox
            // 
            this.RL_StopAotoRunBox.Font = new System.Drawing.Font("굴림", 9F);
            this.RL_StopAotoRunBox.Location = new System.Drawing.Point(204, 389);
            this.RL_StopAotoRunBox.Name = "RL_StopAotoRunBox";
            this.RL_StopAotoRunBox.Size = new System.Drawing.Size(74, 43);
            this.RL_StopAotoRunBox.TabIndex = 43;
            this.RL_StopAotoRunBox.Text = "자동실행 종료";
            this.RL_StopAotoRunBox.UseVisualStyleBackColor = true;
            this.RL_StopAotoRunBox.Click += new System.EventHandler(this.RL_StopAotoRunBox_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MLVS_3.Properties.Resources.KakaoTalk_20170927_141741557;
            this.button1.Location = new System.Drawing.Point(638, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 603);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MLVS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RL_CameraBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RL_ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox ImageBox;
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
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.PictureBox CameraBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox RL_CameraBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.TextBox RL_NumberOfTestDataTextBox;
        protected internal System.Windows.Forms.Button RL_ForwardBox;
        private System.Windows.Forms.Label label14;
        protected internal System.Windows.Forms.TextBox RL_LabelOutPutTextBox;
        private System.Windows.Forms.TextBox RL_ChoiseTestNumberTextBox;
        private System.Windows.Forms.Label label15;
        protected internal System.Windows.Forms.Button RL_RunNumberBox;
        private System.Windows.Forms.Label label16;
        protected internal System.Windows.Forms.Button RL_BackwardBox;
        public System.Windows.Forms.PictureBox RL_ImageBox;
        protected internal System.Windows.Forms.TextBox RL_SelectAutoTimeTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button RL_SaveToTrueFolderBox;
        protected internal System.Windows.Forms.Button RL_LearnDataSaveBox;
        private System.Windows.Forms.Button RL_SaveToFalseFolderBox;
        private System.Windows.Forms.Button RL_OpenTrueFolderBox;
        private System.Windows.Forms.Button RL_SaveToTestFolderBox;
        private System.Windows.Forms.Button RL_OpenFalseFolderBox;
        private System.Windows.Forms.Button RL_LearnBox;
        private System.Windows.Forms.Button RL_OpenTestFolderBox;
        private System.Windows.Forms.Button RL_LearnDataRoadBox;
        protected internal System.Windows.Forms.Button RL_AotoRunBox;
        protected internal System.Windows.Forms.Button RL_StopAotoRunBox;
    }
}

