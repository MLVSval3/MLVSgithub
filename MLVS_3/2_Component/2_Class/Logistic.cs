using System;
using System.Collections.Generic;
using System.Linq;
using MLVS_3._3_Property;
using System.Drawing;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using System.Windows.Forms;

using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Models.Regression;

namespace MLVS_3._2_Component._2_Class
{
  
    class Logistic
    {
        LogisticRegression regression;

        public void CalculateLogistic(double[][] x_train, int[] y_train)
        {
            try
            {
                var teacher = new ProbabilisticCoordinateDescent()
                {
                    Tolerance = 1e-10,
                    Complexity = 1e+10,
                };

                var svm = teacher.Learn(x_train, y_train);

                this.regression = (LogisticRegression)svm;
            }
            catch
            {
                MessageBox.Show("학습실패LR");
            }
           
        }

        public string DesideRefression(double[] input)
        {
            string answer = "";           
            try
            {
                if (this.regression.Decide(input))
                {
                    answer = "False";
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
