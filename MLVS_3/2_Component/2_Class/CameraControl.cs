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

namespace MLVS_3.Component
{
    class CameraControl: iCamearControl
    {
        public void iFormLoad_TakeVideo(CvCapture m_cvCap, Form1 form)
        {
            try
            {
                m_cvCap = CvCapture.FromCamera(0);
                m_cvCap.FrameWidth = 176;
                m_cvCap.FrameHeight = 144;

                form.timer1.Interval = 30;
                form.timer1.Enabled = true;
            }
            catch
            {
                //Display frmAbout as a modal dialog
                MessageBox.Show("카메라 연결을 확인하세요.");
            }
        }

        public void iTimerTick_TakeShoot(IplImage image, CvCapture cvCapture, Form1 form)
        {
            image = cvCapture.QueryFrame();
            form.CameraBox.Image = image.ToBitmap();
        }
    }
}
