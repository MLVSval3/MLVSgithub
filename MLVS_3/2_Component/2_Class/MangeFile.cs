using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MLVS_3._2_Component._1_Interface;
using MLVS_3._3_Property;
using System.IO;

namespace MLVS_3._2_Component._2_Class
{
    class MangeFile : iMangeFile
    {
        //폴더 유무 확인
        public void CheckFolderExists(string saveFolderPath)
        {
            System.IO.DirectoryInfo infor = new System.IO.DirectoryInfo(saveFolderPath);

            if (!infor.Exists)
            {
                System.IO.Directory.CreateDirectory(saveFolderPath);
            }
        }

        //파일 개수 측정
        public int NumberOfFile(string path)
        {
            int count=0;
            try
            {
                if (System.IO.Directory.Exists(path))
                {
                    System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(path);
                    count = directoryInfo.GetFiles("*.*", System.IO.SearchOption.AllDirectories).Length;
                }
            }
            catch
            {; }
            return count;
        }

        //데이터 숫자 나누기
        public int Half(int DataNumber)
        {
            int DataHalf;
            if (DataNumber % 2 == 0)
            {
                DataHalf = DataNumber / 2;
            }
            else
            {
                double FalseData = ((double)DataNumber / 2) - 0.5;
                DataHalf = (int)FalseData;
            }
            return DataHalf;
        }
    }
}
