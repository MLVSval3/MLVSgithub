using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MLVS_3._3_Property;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.CPlusPlus;

using Accord;
using Accord.MachineLearning;

using MLVS_3._1_Main.anotherForm;
using MLVS_3._2_Component._2_Class;

namespace MLVS_3
{
    public partial class Form1 : Form
    {
        MangeFile mangeFile = new MangeFile();
        CvCapture m_cvCap;
        IplImage _image;

        public Form1()
        {
            InitializeComponent();

            LearnDataSaveBox.Enabled = false;   //비활성

            //폴더 생성
            mangeFile.CheckFolderExists(Property.TestFolderPath);
            mangeFile.CheckFolderExists(Property.FalseFolderPath);
            mangeFile.CheckFolderExists(Property.TrueFolderPath);
            mangeFile.CheckFolderExists(Property.DatFileFolderPath);

            //테스트 데이터 수 최신화
            TestDataNumBox.Text=Convert.ToString(mangeFile.NumberOfFile(Property.TestFolderPath));

            //학습 데이터 수
            Property.FalseDataNumber = mangeFile.NumberOfFile(Property.FalseFolderPath);
            Property.Truedatanumber= mangeFile.NumberOfFile(Property.TrueFolderPath);
            Property.AllofDatanumber = Property.FalseDataNumber + Property.Truedatanumber;

            //데이터
            Property.inputs = new double[Property.AllofDatanumber][];
            Property.outputs = new int[Property.AllofDatanumber];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                m_cvCap = CvCapture.FromCamera(0);
                m_cvCap.FrameWidth = 176;
                m_cvCap.FrameHeight = 144;

                timer1.Interval = 30;
                timer1.Enabled = true;
            }
            catch
            {
                //Display frmAbout as a modal dialog
                MessageBox.Show("카메라 연결을 확인하세요.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _image = m_cvCap.QueryFrame();

            CameraBox.Image = _image.ToBitmap();
        }



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
                    process.DataLoop("false", true);
               },
               () =>
               {
                    //false 데이터 분할2
                    process.DataLoop("false", false);
               }

            );
                process.LabelOuput();
                Property.saveButton = true;
                LearnDataSaveBox.Enabled = true;
                MessageBox.Show("학습 완료. 저장 가능");
            }
            catch
            {
                Property.saveButton = false;
                MessageBox.Show("학습 실패.");
            }
            
        }

        private void LearnDataSaveBox_Click(object sender, EventArgs e)
        {
            LearnedDataNameForm NameForm = new LearnedDataNameForm();
            NameForm.Show();
        }

        private void LearnDataLoadBox_Click(object sender, EventArgs e)
        {
            DataLoadForm loadForm = new DataLoadForm();
            loadForm.Show();

        }



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


        private void SaveToTestBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.TestFolderPath);
                int j = textNumber+1;

                CameraBox.Image.Save(Property.testDataPath + j + ").bmp");
                TestDataNumBox.Text = Convert.ToString(mangeFile.NumberOfFile(Property.TestFolderPath));
            }
            catch
            {
                MessageBox.Show("Test 폴더 안 데이터 이름 확인");
            }
        }

        private void SaveToFalseBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.FalseFolderPath);
                int j = textNumber + 1;

                CameraBox.Image.Save(Property.falseDataPath + j + ").bmp");
            }
            catch
            {
                MessageBox.Show("false 폴더 안 데이터 이름 확인");
            }
        }

        private void SaveToTrueBox_Click(object sender, EventArgs e)
        {
            try
            {
                int textNumber = mangeFile.NumberOfFile(Property.TrueFolderPath);
                int j = textNumber + 1;

                CameraBox.Image.Save(Property.trueDataPath + j + ").bmp");
            }
            catch
            {
                MessageBox.Show("True 폴더 안 데이터 이름 확인");
            }
        }


        private void BackwardBox_Click(object sender, EventArgs e)
        {
        

        }

        private void NumberBox_Click(object sender, EventArgs e)
        {

        }

        private void ForwardBox_Click(object sender, EventArgs e)
        {
            TestDataNumBox.Text = Convert.ToString(mangeFile.NumberOfFile(Property.TestFolderPath));

            int maxNum = mangeFile.NumberOfFile(Property.TestFolderPath);

            MessageBox.Show(Convert.ToString("input : "+Property.inputs.Length)+" output : "+ Property.outputs.Length);
            if (OutputTextBox.Text == "")
            {
                DataProcessing DataShipping = new DataProcessing();
                CalculateOutput calculate = new CalculateOutput();

                DataShipping.TestDataShipping(1);
                OutputTextBox.Text = "1." + calculate.CalculateKNN();
            }
        }

       

        private void AutoRunBox_Click(object sender, EventArgs e)
        {

        }

        private void StopAutoRunBox_Click(object sender, EventArgs e)
        {

        }

        
    }
}
