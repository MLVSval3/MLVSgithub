﻿using System;
using System.Collections.Generic;
using System.Linq;
using MLVS_3._3_Property;
using System.Drawing;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using System.Windows.Forms;

using MLVS_3._2_Component._1_Interface;

namespace MLVS_3._2_Component._2_Class
{
    class DataProcessing : iDataProcessing
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
        public void DataLoop(string dataType, bool firstNumber)
        {
            // 임시변수
          
            int firstDataNumber = 0;
            int dataNumber = 0;
            int trueData = 0;
            int AlldataNumber = AlldataNumber = Property.Truedatanumber + Property.FalseDataNumber; ;
            double[][] input = new double[AlldataNumber][];

            string Path = "";

            switch (dataType)
            {
                case "True":
                    #region
                    Path = Directory.GetCurrentDirectory() + @"\true\true (";
                    
                    if (!firstNumber)
                    {
                        firstDataNumber = Property.TrueDataHalf;
                        dataNumber = Property.Truedatanumber;
                        trueData = 0;
                    }
                    else
                    {
                        firstDataNumber = 0;
                        dataNumber = Property.TrueDataHalf;
                        trueData = 0;
                    }
                    break;
                #endregion

                case "False":
                    #region
                    Path = Directory.GetCurrentDirectory() + @"\false\false (";

                    if (!firstNumber)
                    {
                        firstDataNumber = Property.FalseDataHalf;
                        dataNumber = Property.FalseDataNumber;
                        trueData = Property.Truedatanumber;
                    }
                    else
                    {
                        firstDataNumber = 0;
                        dataNumber = Property.FalseDataHalf;
                        trueData = Property.Truedatanumber;
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


            for (int i = firstDataNumber; i < dataNumber; i++)
            {
                #region
                try
                {
                    Bitmap[] bitmaps = new Bitmap[dataNumber];
                    List<double> temp_1 = new List<double>();
                    double[] temp_2;
                    byte[] temp01;
                    Mat mat_cat;

                    mat_cat = Cv2.ImRead(Path + (i + 1) + ").bmp", LoadMode.Color);
                            
                    OpenCvSharp.CPlusPlus.Size size = new OpenCvSharp.CPlusPlus.Size(32, 32);
                    mat_cat = mat_cat.Resize(size, 0, 0, Interpolation.Linear);
                    bitmaps[i] = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat_cat);

                    temp01 = imageToByteArray(bitmaps[i]);
                    temp01.ToList<byte>().ForEach(b => temp_1.Add(Convert.ToDouble(b)));
                    temp_2 = temp_1.ToArray<double>();

                    input[i + trueData] = temp_2;

                    // 메모리 해제
                    mat_cat.Dispose();
                    temp01 = null;
                    temp_2 = null;
                    bitmaps.Initialize();
                    temp_1.Clear();

                    if (i == dataNumber - 1)
                    {
                        Property.inputs = input;
                        input = null;
                    }           
                }
                #endregion

                #region
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
                #endregion
            }
        }

        //테스트 데이터 한장의 데이터 시핑
        public double [] TestDataShipping(int dataNumber)
        {
            try
            { 
                Mat mat_cat = Cv2.ImRead(Property.testDataPath + Convert.ToString(dataNumber) + ").bmp", LoadMode.Color);
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
                return temp_2;
            }
            catch
            {
                MessageBox.Show("picture 폴더 test (" + Convert.ToString(dataNumber) + ") 포멧 확인");
                double[] temp_2 = null;
                return temp_2;
            }
        }

        //output 배열 레이블링
        public void LabelOuput()
        {
            int trueNumber = Property.Truedatanumber;
            int falseNumber = Property.FalseDataNumber;
            int[] outputs = Property.outputs;

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
