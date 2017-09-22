using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLVS_3._3_Property;
using System.Drawing;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.CPlusPlus;
using System.Windows.Forms;

using MLVS_3._2_Component._1_Interface;

namespace MLVS_3._2_Component._2_Class
{
    class DataProcessingcs : iDataProcessing
    {
        //이미지 to 바이트 배열로 변환 메서드
        public byte[] imageToByteArray(Bitmap bitmap)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap copy = new Bitmap(bitmap);
                copy.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return ms.ToArray();
            }
        }

        //데이터 시핑
        public void DataLoop(string dataType, bool firstNumber )
        {
            int firstDataNumber = 0;
            int dataNumber = 0;
            int trueData = 0;
            int AlldataNumber = 0;
            string Path = "";
            
            switch (dataType)
            {
                case "True":
                    #region
                    Path = Property.trueDataPath;
                    AlldataNumber = Property.Truedatanumber;

                    if (!firstNumber)
                    {
                        firstDataNumber = Property.TrueDataHalf;
                        dataNumber = Property.Truedatanumber;
                    }
                    else
                    {
                        firstDataNumber = 0;
                        dataNumber = Property.TrueDataHalf;
                    }
                    break;
                #endregion

                case "False":
                    #region
                    Path = Property.falseDataPath;
                    AlldataNumber = Property.FalseDataNumber;

                    if (!firstNumber)
                    {
                        firstDataNumber = Property.FalseDataHalf;
                        dataNumber = Property.FalseDataNumber;
                    }
                    else
                    {
                        firstDataNumber = 0;
                        dataNumber = Property.FalseDataHalf;
                    }
                    break;
                #endregion

                    //보류
                #region
                    /*
                case "Test":
                    
                    Path = Property.testDataPath;
                    AlldataNumber = Property.FalseDataNumber;

                    if (!firstNumber)
                    {
                        firstDataNumber = Property.FalseDataHalf;
                        dataNumber = Property.FalseDataNumber;
                    }
                    else
                    {
                        firstDataNumber = 0;
                        dataNumber = Property.FalseDataHalf;
                    }
                    break;
                    
    */
                    #endregion
            }

            for (int i= firstDataNumber; i < dataNumber; i++)
            {
                #region
                try
                {
                    double[][] Inputs = new double[AlldataNumber][];
                    Mat mat_cat = Cv2.ImRead(Path + (i + 1) + ").bmp", LoadMode.Color);
                    Bitmap[] bitmaps = new Bitmap[dataNumber];
                    List<double> temp_1 = new List<double>();
                    double[] temp_2;
                    byte[] temp01;

                    OpenCvSharp.CPlusPlus.Size size = new OpenCvSharp.CPlusPlus.Size(32, 32);
                    mat_cat = mat_cat.Resize(size, 0, 0, Interpolation.Linear);
                    bitmaps[i] = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat_cat);

                    temp01 = imageToByteArray(bitmaps[i]);
                    temp01.ToList<byte>().ForEach(b => temp_1.Add(Convert.ToDouble(b)));
                    temp_2 = temp_1.ToArray<double>();

                    Inputs[i + trueData] = temp_2;

                    if (i == dataNumber - 1)
                    {
                        Property.inputs = Inputs;
                    }
                }
                #endregion
                catch
                {
                    switch (dataType)
                    {
                        #region
                        case "True":
                            MessageBox.Show("데이터 학습 실패 \ntrue " + (i + 1) + " 폴더에 이미지 형식 확인");
                            break;
                        case "False":
                            MessageBox.Show("데이터 학습 실패 \nfalse " + (i + 1) + "폴더에 이미지 형식 확인");
                            break;
                            /* 
                            case "Test":
                            MessageBox.Show("데이터 학습 실패 \ntest " + (i + 1) + "폴더에 이미지 형식 확인");
                            break;
                            */
                         #endregion
                    }
                }            
            }
        }

        //테스트 데이터 한장의 데이터 시핑
        public void TestDataShipping(int dataNumber)
        {
            try
            { 
                Mat mat_cat = Cv2.ImRead(Property.testDataPath + (dataNumber) + ").bmp", LoadMode.Color);
                Bitmap []bitmaps = new Bitmap[1];
                List<double> temp_1 = new List<double>();
                double[] temp_2;
                byte[] temp01;

                OpenCvSharp.CPlusPlus.Size size = new OpenCvSharp.CPlusPlus.Size(32, 32);
                mat_cat = mat_cat.Resize(size, 0, 0, Interpolation.Linear);
                bitmaps[0] = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat_cat);

                temp01 = imageToByteArray(bitmaps[0]);
                temp01.ToList<byte>().ForEach(b => temp_1.Add(Convert.ToDouble(b)));
                temp_2 = temp_1.ToArray<double>();

            }
            catch
            {
                MessageBox.Show("picture 폴더 test (" + (dataNumber) + ") 포멧 확인");
            }
        }

        //output 배열 레이블링
        public void LabelOuput()
        {
            int trueNumber=Property.Truedatanumber;
            int falseNumber = Property.FalseDataNumber;
            int []outputs = { 0 };

            for (int i = 0; i < trueNumber; i++)
            {
                outputs[i] = 0;
            }

            for (int i = 0; i < falseNumber; i++)
            {
                outputs[i + trueNumber] = 1;
            }

            Property.outputs = outputs;
        }
    }
}
