using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MLVS_3._3_Property;
using MLVS_3._2_Component._2_Class;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace MLVS_3._1_Main.anotherForm
{
    public partial class LearnedDataNameForm : Form
    {
        public LearnedDataNameForm()
        {
            InitializeComponent();
        }

        private void SaveTheName_Click(object sender, EventArgs e)
        {
            try
            {
                if (LearnedDataText.Text != "")
                {
                    using (Stream LearnData = new FileStream(Property.DatFileFolderPath + LearnedDataText.Text + ".dat", FileMode.Create))
                    {
                        SerializableClass sendData = new SerializableClass();
                        sendData.SendInputs = Property.inputs;
                        sendData.SendOutputs = Property.outputs;

                        BinaryFormatter binFormatter = new BinaryFormatter();
                        binFormatter.Serialize(LearnData, sendData);

                        LearnData.Close();
                    }
                }
                else
                {
                    MessageBox.Show("이름을 입력하시오.");
                }
                this.Close();
            }        
            catch
            {
                MessageBox.Show("오류 발생");
                this.Close();
            }
           
        }

        private void CansleBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
