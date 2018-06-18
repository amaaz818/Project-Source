using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPProject
{
    class Layer
    {
           // number of neurons in a layer
     public int NumNeurons
        {
            get
            {
                return NumNeurons;
            }
            set
            {
               NumNeurons = value;
            }
        }

         // number of inputs to the layer
        public int NumLayerInputs
        {
            get
            {
                return NumLayerInputs;
            }
            set
            {
                NumLayerInputs = value;
            }
        }

         // Neurons in the layer
        public Neuron[] Neurons
        {
            get
            {
                return Neurons;
            }

            set
            {
                Neurons = value;
            }
        }

        double[] Output;

        public Layer(inputLayer,)
        {

        }
    }
  }

