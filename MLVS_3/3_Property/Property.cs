
using OpenCvSharp;
using System.IO;
using MLVS_3._2_Component._2_Class;



namespace MLVS_3._3_Property
{
    static class Property
    {
        //save버튼 활성화
        static public bool saveButton =false;
        //시리얼 데이터를 불러올 때
        static public bool serialDataLoad = false;


        //카메라 연결 확인
        static public bool CameraConected = false;

        //자동실행 활성화
        static public bool autoRun = false;
        static public bool LautoRun = false;

        static public bool KNNBox = false;
        static public bool LosisticBox = false;

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

        static public string [] DatFileNmae { get; set; }

        //이미지를 데이터 처리한 다차원 배열
        static public double[][] inputs { get; set; }
        static public double[] testInputs { get; set; }

        //판별 결과
        static public int[] outputs { get; set; }

        //학습 데이터의 수
        static public int TestDataNumber { get; set; }
        static public int FalseDataNumber { get; set; }
        static public int Truedatanumber { get; set; }
        static public int AllofDatanumber { get; set; }

        //멀티 스래딩을 위한 데이터수의 절반 나누기
        static public int FalseDataHalf { get; set; }
        static public int TrueDataHalf { get; set; }

        //자동실행 시간 조절
        static public int timer = 1000;

        static public Logistic logistic { get; set; }
    }
}
