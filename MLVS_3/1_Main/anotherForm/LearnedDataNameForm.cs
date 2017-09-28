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
using System.Globalization;
using System.Text.RegularExpressions;


namespace MLVS_3._1_Main.anotherForm
{
    public partial class LearnedDataNameForm : Form
    {
        public LearnedDataNameForm()
        {
            InitializeComponent();
        }

        //기능없는 이벤트
        #region
        private void LearnedDataText_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion 

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
                    MessageBox.Show("파일의 이름을 입력하시오.");
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

    
        private void LearnedDataText_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LearnedDataText_Leave(object sender, System.EventArgs e)
        {
            Regex emailregex = new Regex(@"[a-zA-Z]");
            Boolean ismatch = emailregex.IsMatch(LearnedDataText.Text);
            if (!ismatch)
            {
                MessageBox.Show("영문자만 입력해 주세요.");
            }
        }

    }
}
