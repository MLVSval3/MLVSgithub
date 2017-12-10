using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using MLVS_3._3_Property;
using MLVS_3._1_Main.anotherForm;
using MLVS_3._2_Component._2_Class;

using OpenCvSharp;
using OpenCvSharp.Extensions;





namespace MLVS_3
{
    public partial class Form1 : Form                                                                                                                                                                            
    {
        //전역 객체 
        #region
        MangeFile mangeFile = new MangeFile();
        CvCapture m_cvCap;
        IplImage _image;
        DataProcessing DataShipping ;
        CalculateOutput calculate ;
#endregion

        public Form1()
        {
            InitializeComponent();

            //버튼 비활성화
            #region
            LearnDataSaveBox.Enabled = false;   //비활성
            ForwardBox.Enabled = false;
            BackwardBox.Enabled = false;
            NumberBox.Enabled = false;
            AutoRunBox.Enabled = false;
            StopAutoRunBox.Enabled = false;

            RL_LearnDataSaveBox.Enabled = false;   //비활성
            RL_ForwardBox.Enabled = false;
            RL_BackwardBox.Enabled = false;
            RL_RunNumberBox.Enabled = false;
            RL_AotoRunBox.Enabled = false;
            RL_StopAotoRunBox.Enabled = false;

            OutputTextBox.Text = "";
            TestDataNumberBox.Text = "";
            RunSpeedTextBox.Text = "";
            #endregion

            //폴더 생성
            #region
            mangeFile.CheckFolderExists(Property.TestFolderPath);
            mangeFile.CheckFolderExists(Property.FalseFolderPath);
            mangeFile.CheckFolderExists(Property.TrueFolderPath);
            mangeFile.CheckFolderExists(Property.DatFileFolderPath);
            #endregion

            //테스트 데이터 수
            #region
            TestDataNumBox.Text = Convert.ToString(mangeFile.NumberOfFile(Property.TestFolderPath));
            RL_NumberOfTestDataTextBox.Text= Convert.ToString(mangeFile.NumberOfFile(Property.TestFolderPath));
            #endregion

            //학습 데이터 수
            #region
            Property.TestDataNumber= mangeFile.NumberOfFile(Property.TestFolderPath);
            Property.FalseDataNumber = mangeFile.NumberOfFile(Property.FalseFolderPath);
            Property.Truedatanumber= mangeFile.NumberOfFile(Property.TrueFolderPath);
            Property.AllofDatanumber = Property.FalseDataNumber + Property.Truedatanumber;

            Property.FalseDataHalf = mangeFile.Half(Property.FalseDataNumber);
            Property.TrueDataHalf = mangeFile.Half(Property.Truedatanumber);
#endregion

            //데이터
            Property.inputs = new double[Property.AllofDatanumber][];
            Property.outputs = new int[Property.AllofDatanumber];
        }

        //기능없는 이벤트
        #region
        private void OutputTextBox_TextChanged(object sender, EventArgs e) { }
        private void TestDataNumberBox_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }

        #endregion

        //Form1 로드
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                m_cvCap = CvCapture.FromCamera(0);
                m_cvCap.FrameWidth = 176;
                m_cvCap.FrameHeight = 144;

                timer1.Interval = 30;
                timer1.Enabled = true;

                SaveToFalseBox.Enabled = true;
                SaveToTestBox.Enabled = true;
                SaveToTrueBox.Enabled = true;

                RL_SaveToFalseFolderBox.Enabled = true;
                RL_SaveToTrueFolderBox.Enabled = true;
                RL_SaveToTestFolderBox.Enabled = true;

                Property.CameraConected = true;
            }
            catch
            {
                SaveToFalseBox.Enabled = false;
                SaveToTestBox.Enabled = false;
                SaveToTrueBox.Enabled = false;

                RL_SaveToFalseFolderBox.Enabled = false;
                RL_SaveToTrueFolderBox.Enabled = false;
                RL_SaveToTestFolderBox.Enabled = false;

                Property.CameraConected = false;
                //Display frmAbout as a modal dialog
                MessageBox.Show("카메라 연결을 확인하세요.");
            }
        }
        //시간
        private void timer1_Tick(object sender, EventArgs e)
        {
            _image = m_cvCap.QueryFrame();

            CameraBox.Image = _image.ToBitmap();
            RL_CameraBox.Image= _image.ToBitmap();
        }

  
        //학습 버튼
        private void LearnBox_Click(object sender, EventArgs e)
        {
            DataProcessing process = new DataProcessing();
            try
            {
                Parallel.Invoke
            (
               //true data data shiping*
               () =>
               {
                   //true 데이터 분할 1
                   process.DataLoop("True", true);
               },

               () =>
               {
                   //true 데이터 분할2
                   process.DataLoop("True", false);
               },

               //false data data shiping*
               () =>
               {
                   //false 데이터 분할1
                   process.DataLoop("False", true);
               },

               () =>
               {
                   //false 데이터 분할2
                   process.DataLoop("False", false);
               }

            );
                process.LabelOuput();
                Property.saveButton = true;
                
                LearnDataSaveBox.Enabled = true;
                ForwardBox.Enabled = true;
                BackwardBox.Enabled = true;
                NumberBox.Enabled = true;

                if(Property.CameraConected == true)
                {
                    AutoRunBox.Enabled = true;
                    StopAutoRunBox.Enabled = true;
                }
                else
                {
                    AutoRunBox.Enabled = false;
                    StopAutoRunBox.Enabled = false;
                }
                MessageBox.Show("학습 완료. 저장 가능");

            }
            catch
            {
                Property.saveButton = false;
                MessageBox.Show("학습 실패.");
            }
            
        }
        //학습 데이터 저장 버튼 : LearnedDataNameForm 열기
        private void LearnDataSaveBox_Click(object sender, EventArgs e)
        {
            LearnedDataNameForm NameForm = new LearnedDataNameForm();
            NameForm.Show();
        }
        //학습 데이터 로드 버튼 : DataLoadForm 열기
        private void LearnDataLoadBox_Click(object sender, EventArgs e)
        {
            Property.KNNBox = true;
            DataLoadForm loadForm = new DataLoadForm(this);
            
            loadForm.Show();
        }


        // > 버튼 번호를 증가시키며 검사
        private void ForwardBox_Click(object sender, EventArgs e)
        {
            int testDataNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
            TestDataNumBox.Text = Convert.ToString(testDataNumber);
            DataProcessing DataShipping = new DataProcessing();
            CalculateOutput calculate = new CalculateOutput();

            try
            {
                if (OutputTextBox.Text == "")
                {
                    OutputTextBox.Text = "1." + calculate.CalculateKNN(DataShipping.TestDataShipping(1));

                    ImageBox.Load(Property.testDataPath + Convert.ToString(1) + ").bmp");
                }
                else if (OutputTextBox.Text.Contains("True")) //true.
                {
                    if (testDataNumber > Convert.ToInt32(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 5)))
                    {

                        int RunNumber = int.Parse(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 5));
                        string output = calculate.CalculateKNN(DataShipping.TestDataShipping(RunNumber + 1));

                        OutputTextBox.Text = Convert.ToString(RunNumber + 1) + "." + output;

                        ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber + 1) + ").bmp");

                    }
                }
                else if (OutputTextBox.Text.Contains("False"))//false.
                {
                    if (testDataNumber > Convert.ToInt32(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 6)))
                    {
                        int RunNumber = int.Parse(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 6));
                        string output = calculate.CalculateKNN(DataShipping.TestDataShipping(RunNumber + 1));

                        OutputTextBox.Text = Convert.ToString(RunNumber + 1) + "." + output;

                        ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber + 1) + ").bmp");
                    }
                }
            }
            catch
            {
                MessageBox.Show("데이터를 학습시키오.");
            }
            
        }
        // < 버튼 번호를 감소기키며 검사
        private void BackwardBox_Click(object sender, EventArgs e)
        {
            int testDataNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
            TestDataNumBox.Text = Convert.ToString(testDataNumber);
            DataProcessing DataShipping = new DataProcessing();
            CalculateOutput calculate = new CalculateOutput();

            try
            {
                if (OutputTextBox.Text == "")
                {
                    MessageBox.Show("테스트 파일이 없습니다.");
                }
                else if (OutputTextBox.Text.Contains("True")) //true.
                {
                    if (1 < Convert.ToInt32(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 5)))
                    {

                        int RunNumber = int.Parse(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 5));
                        string output = calculate.CalculateKNN(DataShipping.TestDataShipping(RunNumber - 1));

                        OutputTextBox.Text = Convert.ToString(RunNumber - 1) + "." + output;

                        ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber - 1) + ").bmp");
                    }
                }
                else if (OutputTextBox.Text.Contains("False"))//false.
                {
                    if (1 < Convert.ToInt32(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 6)))
                    {
                        int RunNumber = int.Parse(OutputTextBox.Text.Substring(0, OutputTextBox.Text.Length - 6));
                        string output = calculate.CalculateKNN(DataShipping.TestDataShipping(RunNumber - 1));

                        OutputTextBox.Text = Convert.ToString(RunNumber - 1) + "." + output;

                        ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber - 1) + ").bmp");
                    }
                }
            }
            catch
            {
                MessageBox.Show("데이터를 학습시키오.");
            }

        }
        // 지정한 번호의 데이터 검사
        private void NumberBox_Click(object sender, EventArgs e)
        {
            int testDataNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
            TestDataNumBox.Text = Convert.ToString(testDataNumber);
            DataProcessing DataShipping = new DataProcessing();
            CalculateOutput calculate = new CalculateOutput();

            try
            {
                int RunNumber = int.Parse(TestDataNumberBox.Text);

                if (RunNumber <= testDataNumber && RunNumber > 0)
                {
                    string output = calculate.CalculateKNN(DataShipping.TestDataShipping(RunNumber));

                    OutputTextBox.Text = Convert.ToString(RunNumber) + "." + output;

                    ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber) + ").bmp");
                }
                else
                {
                    MessageBox.Show("1부터 test데이터의 개수까지의 정수를 입력하시오");
                }
            }
            catch
            {
                MessageBox.Show("데이터를 학습시키오.");
            }

           
        }
        // 자동검사 실행
        private void AutoRunBox_Click(object sender, EventArgs e)
        {
            Property.autoRun = true;
            
            if (RunSpeedTextBox.Text != "")
            {
                timer2.Interval = Convert.ToInt32(RunSpeedTextBox.Text);
            }
            else
            {
                timer2.Interval = 500;
            }
            timer2.Enabled = true;
            
        }
        // 자동검사 시작
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (
                    ((RunSpeedTextBox.Text == "") || (10 <= Convert.ToInt32(RunSpeedTextBox.Text) && Convert.ToInt32(RunSpeedTextBox.Text) <= 5000))
                    && (Property.autoRun == true || Property.LautoRun == true)) 
                {
                    // 카메라에서 프레임 가져온다.
                    _image = m_cvCap.QueryFrame();

                    // 비트맵으로 전환
                    CameraBox.Image = _image.ToBitmap();

                    //사진 폴더 사진 개수 측정             
                    int testData = mangeFile.NumberOfFile(Property.TestFolderPath) + 1;

                    CameraBox.Image.Save(Property.testDataPath + (testData) + ").bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    DataShipping = new DataProcessing();
                    calculate = new CalculateOutput();

                    try
                    {             
                        string output="";

                        if (Property.autoRun)
                        {
                            output = calculate.CalculateKNN(DataShipping.TestDataShipping(testData));
                            OutputTextBox.Text = Convert.ToString(testData) + "." + output;
                            TestDataNumBox.Text = Convert.ToString(testData);
                            ImageBox.Load(Property.testDataPath + Convert.ToString(testData) + ").bmp");
                        }
                        if (Property.LautoRun)
                        {
                            output = Property.logistic.DesideRefression(DataShipping.TestDataShipping(testData));
                            RL_LabelOutPutTextBox.Text = Convert.ToString(testData) + "." + output;
                            RL_NumberOfTestDataTextBox.Text = Convert.ToString(testData);
                            RL_ImageBox.Load(Property.testDataPath + Convert.ToString(testData) + ").bmp");
                        }               
                    }
                
                    catch
                    {
                        MessageBox.Show("데이터를 학습시키오.");
                        Property.LautoRun = false;
                        Property.autoRun = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("카메라 연결을 확인하시오.");
            }
        }
        // 자동검사 정지
        private void StopAutoRunBox_Click(object sender, EventArgs e)
        {
            Property.autoRun = false;
        }


        //True폴더 열기 버튼
        private void TrueFolderOpenBox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Property.TrueFolderPath);
            }
            catch
            {
                mangeFile.CheckFolderExists(Property.TrueFolderPath);
                System.Diagnostics.Process.Start(Property.TrueFolderPath);
            }
        }
        //False폴더 열기 버튼
        private void FalseFolderOpenBox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Property.FalseFolderPath);
            }
            catch
            {
                mangeFile.CheckFolderExists(Property.FalseFolderPath);
                System.Diagnostics.Process.Start(Property.FalseFolderPath);
            }
        }
        //Test폴더 열기 버튼
        private void TestFolderOpenBox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Property.TestFolderPath);
            }
            catch
            {
                mangeFile.CheckFolderExists(Property.TestFolderPath);
                System.Diagnostics.Process.Start(Property.TestFolderPath);
            }
        }

        //카메라의 화면을 Test폴더로 저장
        private void SaveToTestBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
                int j = textNumber+1;

                CameraBox.Image.Save(Property.testDataPath + j + ").bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                TestDataNumBox.Text = Convert.ToString(mangeFile.NumberOfFile(Property.TestFolderPath));
            }
            catch
            {
                MessageBox.Show("Test 폴더 안 데이터 이름 확인");
            }
        }
        //카메라의 화면을 False폴더로 저장
        private void SaveToFalseBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.FalseFolderPath);
                int j = textNumber + 1;

                CameraBox.Image.Save(Property.falseDataPath + j + ").bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch
            {
                MessageBox.Show("false 폴더 안 데이터 이름 확인");
            }
        }
        //카메라의 화면을 True폴더로 저장
        private void SaveToTrueBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.TrueFolderPath);
                int j = textNumber + 1;

                CameraBox.Image.Save(Property.trueDataPath + j + ").bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch
            {
                MessageBox.Show("True 폴더 안 데이터 이름 확인");
            }
        }
        //리프레쉬
        private void RefreshBox1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }


        //************************Logistic Regression***********************

        //학습 버튼
        private void RL_LearnBox_Click(object sender, EventArgs e)
        {
            DataProcessing process = new DataProcessing();
            try
            {
                Parallel.Invoke
            (
               //true data data shiping*
               () =>
               {
                   //true 데이터 분할 1
                   process.DataLoop("True", true);
               },

               () =>
               {
                   //true 데이터 분할2
                   process.DataLoop("True", false);
               },

               //false data data shiping*
               () =>
               {
                   //false 데이터 분할1
                   process.DataLoop("False", true);
               },

               () =>
               {
                   //false 데이터 분할2
                   process.DataLoop("False", false);
               }

            );
                process.LabelOuput();
                
                Property.logistic = new Logistic();
                Property.logistic.CalculateLogistic(Property.inputs, Property.outputs);

                Property.saveButton = true;
                RL_LearnDataSaveBox.Enabled = true;
                RL_ForwardBox.Enabled = true;
                RL_BackwardBox.Enabled = true;
                RL_RunNumberBox.Enabled = true;

                if (Property.CameraConected == true)
                {
                    RL_AotoRunBox.Enabled = true;
                    RL_StopAotoRunBox.Enabled = true;
                }
                else
                {
                    RL_AotoRunBox.Enabled = false;
                    RL_StopAotoRunBox.Enabled = false;
                }

                MessageBox.Show("학습 완료. 저장 가능");
            }
            catch
            {
                Property.saveButton = false;
                MessageBox.Show("학습 실패.");
            }
        }
        //학습한 데이터 저장 
        private void RL_LearnDataSaveBox_Click(object sender, EventArgs e)
        {
            LearnedDataNameForm NameForm = new LearnedDataNameForm();
            NameForm.Show();
        }
        //학습한 데이터 불러오기
        private void RL_LearnDataRoadBox_Click(object sender, EventArgs e)
        {
            Property.LosisticBox = true;
            Property.KNNBox = false;
            DataLoadForm loadForm = new DataLoadForm(this);
            
            loadForm.Show();
        }


        //데이터가 학습 되었을 때 번호를 1씩 증가시키며 검사
        private void RL_ForwardBox_Click(object sender, EventArgs e)
        {
            int testDataNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
            TestDataNumBox.Text = Convert.ToString(testDataNumber);
            DataProcessing DataShipping = new DataProcessing();

            try
            {
                if (RL_LabelOutPutTextBox.Text == "")
                {     
                    RL_LabelOutPutTextBox.Text = "1." + Property.logistic.DesideRefression(DataShipping.TestDataShipping(1));

                    RL_ImageBox.Load(Property.testDataPath + Convert.ToString(1) + ").bmp");
                }
                else if (RL_LabelOutPutTextBox.Text.Contains("True")) //true.
                {
                    if (testDataNumber > Convert.ToInt32(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 5)))
                    {
                        int RunNumber = int.Parse(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 5));
                        string output = Property.logistic.DesideRefression(DataShipping.TestDataShipping(RunNumber + 1));

                        RL_LabelOutPutTextBox.Text = Convert.ToString(RunNumber + 1) + "." + output;

                        RL_ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber + 1) + ").bmp");
                    }
                }
                else if (RL_LabelOutPutTextBox.Text.Contains("False"))//false.
                {
                    if (testDataNumber > Convert.ToInt32(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 6)))
                    {
                        int RunNumber = int.Parse(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 6));
                        string output = Property.logistic.DesideRefression(DataShipping.TestDataShipping(RunNumber + 1));

                        RL_LabelOutPutTextBox.Text = Convert.ToString(RunNumber + 1) + "." + output;

                        RL_ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber + 1) + ").bmp");
                    }
                }
            }
            catch
            {
                MessageBox.Show("데이터를 학습시키오.");
            }
        }
        //데이터가 학습 되었을 때 번호를 1씩 감소시키며 검사
        private void RL_BackwardBox_Click(object sender, EventArgs e)
        {
            int testDataNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
            TestDataNumBox.Text = Convert.ToString(testDataNumber);
            DataProcessing DataShipping = new DataProcessing();

            try
            {
                if (RL_LabelOutPutTextBox.Text == "")
                {
                    MessageBox.Show("테스트 파일이 없습니다.");
                }
                else if (RL_LabelOutPutTextBox.Text.Contains("True")) //true.
                {
                    if (1 < Convert.ToInt32(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 5)))
                    {

                        int RunNumber = int.Parse(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 5));
                        string output = Property.logistic.DesideRefression(DataShipping.TestDataShipping(RunNumber - 1));

                        RL_LabelOutPutTextBox.Text = Convert.ToString(RunNumber - 1) + "." + output;

                        RL_ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber - 1) + ").bmp");
                    }
                }
                else if (RL_LabelOutPutTextBox.Text.Contains("False"))//false.
                {
                    if (1 < Convert.ToInt32(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 6)))
                    {
                        int RunNumber = int.Parse(RL_LabelOutPutTextBox.Text.Substring(0, RL_LabelOutPutTextBox.Text.Length - 6));
                        string output = Property.logistic.DesideRefression(DataShipping.TestDataShipping(RunNumber - 1));

                        RL_LabelOutPutTextBox.Text = Convert.ToString(RunNumber - 1) + "." + output;

                        RL_ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber - 1) + ").bmp");
                    }
                }
            }
            catch
            {
                MessageBox.Show("데이터를 학습시키오.");
            }
        }
        //데이터가 학습 되었을 때 원하는 번호 검사
        private void RL_RunNumberBox_Click(object sender, EventArgs e)
        {
            int testDataNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
            TestDataNumBox.Text = Convert.ToString(testDataNumber);
            DataProcessing DataShipping = new DataProcessing();

            try
            {
                int RunNumber = int.Parse(RL_ChoiseTestNumberTextBox.Text);

                if (RunNumber <= testDataNumber && RunNumber > 0)
                {
                    string output = Property.logistic.DesideRefression(DataShipping.TestDataShipping(RunNumber));

                    RL_LabelOutPutTextBox.Text = Convert.ToString(RunNumber) + "." + output;

                    RL_ImageBox.Load(Property.testDataPath + Convert.ToString(RunNumber) + ").bmp");
                }
                else
                {
                    MessageBox.Show("1부터 test데이터의 개수까지의 정수를 입력하시오");
                }
            }
            catch
            {
                MessageBox.Show("데이터를 학습시키오.");
            }
        }


        //데이터가 학습 되었을 때 자동 실행
        private void RL_AotoRunBox_Click(object sender, EventArgs e)
        {
            Property.LautoRun = true;

            if (RunSpeedTextBox.Text != "")
            {
                timer2.Interval = Convert.ToInt32(RunSpeedTextBox.Text);
            }
            else
            {
                timer2.Interval = 500;
            }
            timer2.Enabled = true;

        }
        //저동 실행 정지
        private void RL_StopAotoRunBox_Click(object sender, EventArgs e)
        {
            Property.autoRun = false;
            Property.LautoRun = false;
        }


        //True 폴더 열기
        private void RL_OpenTrueFolderBox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Property.TrueFolderPath);
            }
            catch
            {
                mangeFile.CheckFolderExists(Property.TrueFolderPath);
                System.Diagnostics.Process.Start(Property.TrueFolderPath);
            }
        }
        //False 폴더 열기
        private void RL_OpenFalseFolderBox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Property.FalseFolderPath);
            }
            catch
            {
                mangeFile.CheckFolderExists(Property.FalseFolderPath);
                System.Diagnostics.Process.Start(Property.FalseFolderPath);
            }
        }
        //Test 폴더 열기
        private void RL_OpenTestFolderBox_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Property.TestFolderPath);
            }
            catch
            {
                mangeFile.CheckFolderExists(Property.TestFolderPath);
                System.Diagnostics.Process.Start(Property.TestFolderPath);
            }
        }


        //카메라가 연결 됐을 때Test 폴더로 사진 저장
        private void RL_SaveToTestFolderBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
                int j = textNumber + 1;

                CameraBox.Image.Save(Property.testDataPath + j + ").bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                TestDataNumBox.Text = Convert.ToString(mangeFile.NumberOfFile(Property.TestFolderPath));
            }
            catch
            {
                MessageBox.Show("Test 폴더 안 데이터 이름 확인");
            }
        }
        //카메라가 연결 됐을 때 False 폴더로 사진 저장
        private void RL_SaveToFalseFolderBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.FalseFolderPath);
                int j = textNumber + 1;

                CameraBox.Image.Save(Property.falseDataPath + j + ").bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch
            {
                MessageBox.Show("false 폴더 안 데이터 이름 확인");
            }
        }
        //카메라가 연결 됐을 때 True 폴더로 사진 저장
        private void RL_SaveToTrueFolderBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.TrueFolderPath);
                int j = textNumber + 1;

                CameraBox.Image.Save(Property.trueDataPath + j + ").bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch
            {
                MessageBox.Show("True 폴더 안 데이터 이름 확인");
            }
        }


        //리프레쉬
        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
