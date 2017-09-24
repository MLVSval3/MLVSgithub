using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLVS_3._2_Component._2_Class
{
    [Serializable]
    class SerializableClass
    {
        public double[][] SendInputs;
        public int[] SendOutputs;

        public double[][] Sendinputs { get; set; }
        public int[] Sendoutputs { get; set; }
    }
}
