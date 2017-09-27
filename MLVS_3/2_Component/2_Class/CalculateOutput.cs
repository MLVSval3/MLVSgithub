using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MLVS_3._2_Component._1_Interface;
using MLVS_3._3_Property;
using Accord.MachineLearning;

namespace MLVS_3._2_Component._2_Class
{
    class CalculateOutput : iCalculateOutput
    {
       public string CalculateKNN(double [] data)
        {
            string answer = "";
            var knn = new KNearestNeighbors(k: 3);

            knn.Learn(Property.inputs, Property.outputs);

            try
            {
                if (knn.Decide(data) == 1)
                {
                    answer= "False";
                }
                else
                {
                    answer = "True";
                }
            }
            catch
            {
                MessageBox.Show("데이터 포멧 확인");
            }

            return answer;
        }
    }
}
