using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPProject
{
    class Network
    {

        //NUMBER OF NEURONS IN A LAYER
 
         // layers in the network
     public Layer[] layers;

        public int numLayers;
        public int NumLayers
        {
            get
           {
                return numLayers;
           }
            set
            {
                numLayers = value;
            }
         }
 
      protected int numInputs;  
        public int NumInputs
        {
            get 
           
             {
                return numInputs; 
               
             }
            set
            {
                numInputs = value;
            }
        }

        public int numOutputs;

        public int NumOutputs     
            {
                get
                {
                        return numOutputs ;

                }
            set
            {
                numOutputs = value;
            }
            }
         }
  }
    

