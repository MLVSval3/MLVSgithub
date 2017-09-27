using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MLVS_3._3_Property;

namespace MLVS_3._2_Component._1_Interface
{
    interface iDataProcessing
    {
        //이미지 to 바이트 배열로 변환 메서드
        byte[] imageToByteArray(Bitmap bitmap);

        //데이터 시핑
        void DataLoop(string dataType, bool firstNumber);

        //테스트 이미지 한장 데이터 쉬핑
        double[] TestDataShipping(int dataNumber);

        //output 배열 레이블링
        void LabelOuput();
    }
}
