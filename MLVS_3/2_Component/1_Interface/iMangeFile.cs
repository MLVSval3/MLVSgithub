using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLVS_3._2_Component._1_Interface
{
    interface iMangeFile
    {
        //폴더 유무 확인
        void CheckFolderExists(string savefolderPath);

        //파일 개수 측정
        int NumberOfFile(string path);

        //데이터 숫자 나누기
        int Half(int DataNumber);
    }
}
