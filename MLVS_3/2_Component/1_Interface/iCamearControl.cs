using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

using MLVS_3._2_Component._1_Interface;

using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.CPlusPlus;

namespace MLVS_3._2_Component._1_Interface
{
    interface iCamearControl
    {
        //비디오 촬영 메소드
        void iFormLoad_TakeVideo(CvCapture m_cvCap, Form1 form);

        //사진 저장 메소드
        void iTimerTick_TakeShoot(IplImage image, CvCapture cvCapture, Form1 form);
    }
}
