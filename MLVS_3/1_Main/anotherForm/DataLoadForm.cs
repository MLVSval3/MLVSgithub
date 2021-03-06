﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using MLVS_3._1_Main;
using MLVS_3._3_Property;
using MLVS_3._2_Component._2_Class;

namespace MLVS_3._1_Main.anotherForm
{
    public partial class DataLoadForm : Form
    {

        bool selected = false;
        Form1 frm = new Form1();
 

        public DataLoadForm(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;

            MangeFile mangefile1 = new MangeFile();
            int indexNum = mangefile1.NumberOfFile(Property.DatFileFolderPath);

            string[] DatFileNmae = new string[indexNum];
            Property.DatFileNmae = new string[indexNum];

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Property.DatFileFolderPath);

            int i = 0;
            foreach (System.IO.FileInfo File in di.GetFiles())
            {         
                if (File.Extension.ToLower().CompareTo(".dat") == 0 ) 
                {
                    string FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);
                    DatFileNmae[i] = FileNameOnly;
                }
                listBox1.Items.Add(DatFileNmae[i]);
                i++;
            }
            Property.DatFileNmae = DatFileNmae;
        }

        private void LoadBox_Click(object sender, EventArgs e)
        {
            if (selected == true)
            {
                int index = listBox1.SelectedIndex;
                //MessageBox.Show(Convert.ToString(index));
                //MessageBox.Show(Property.DatFileNmae[index]);

                using (Stream LearnedData = new FileStream(@"dat\"+Property.DatFileNmae[index]+".dat", FileMode.Open))
                {
                    // BinaryFormatter 클래스의 개체 생성
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    // LearnedData 스트림에 연결된 파일에 저장된 개체를 불러오기
                    // Object 반환으로 인한 형변환
                    SerializableClass readData = binFormatter.Deserialize(LearnedData) as SerializableClass;
                    Property.inputs =readData.SendInputs;
                    Property.outputs =readData.SendOutputs;

                    // sendData 스트림 닫기
                    LearnedData.Close();

                    Property.serialDataLoad = true;
 
                }
                frm.LearnDataSaveBox.Enabled = true;
                frm.ForwardBox.Enabled = true;
                frm.BackwardBox.Enabled = true;
                frm.NumberBox.Enabled = true;

                frm.RL_BackwardBox.Enabled = true;
                frm.RL_ForwardBox.Enabled = true; 
                frm.RL_RunNumberBox.Enabled = true;
                frm.RL_LearnDataSaveBox.Enabled = true;
            }

            if (Property.KNNBox == false && Property.LosisticBox == true)
            {
                Property.logistic = new Logistic();
                Property.logistic.CalculateLogistic(Property.inputs, Property.outputs);
                if (Property.CameraConected == true)
                {
                    frm.RL_AotoRunBox.Enabled = true;
                    frm.RL_StopAotoRunBox.Enabled = true;
                }
            }
            else if (Property.KNNBox == true && Property.LosisticBox == false)
            {
                if (Property.CameraConected == true)
                {
                    frm.AutoRunBox.Enabled = true;
                    frm.StopAutoRunBox.Enabled = true;
                }
            }
            Property.KNNBox = false;
            Property.LosisticBox = false;

            this.Close();
        }

        private void CansleBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = true;
        }

        private void RefreshBox_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
