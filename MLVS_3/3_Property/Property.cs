using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.IO;


namespace MLVS_3._3_Property
{
    static class Property
    {
        //open cv sharp - 이미지 데이터
        static public CvCapture m_cvCap { get; set; }
        static public IplImage _image { get; set; }
    
        #region 경로
        static public string FalseFolderPath = Directory.GetCurrentDirectory() + @"\false\";
        static public string TrueFolderPath = Directory.GetCurrentDirectory() + @"\true\";
        static public string TestFolderPath = Directory.GetCurrentDirectory() + @"\test\";
        static public string DatFileFolderPath = Directory.GetCurrentDirectory() + @"\dat\";

        static public string trueDataPath = Directory.GetCurrentDirectory() + @"\true\true (";
        static public string falseDataPath = Directory.GetCurrentDirectory() + @"\false\false (";
        static public string testDataPath = Directory.GetCurrentDirectory() + @"\test\test (";
        #endregion

        //이미지를 데이터 처리한 다차원 배열
        static public double[][] inputs { get; set; }
        static public double[] testInputs { get; set; }
        //판별 결과
        static public int[] outputs { get; set; }

        //학습 데이터의 수
        static public int FalseDataNumber { get; set; }
        static public int Truedatanumber { get; set; }
        static public int AllofDatanumber { get; set; }

        //멀티 스래딩을 위한 데이터수의 절반 나누기
        static public int FalseDataHalf { get; set; }
        static public int TrueDataHalf { get; set; }

    }
}
