using System.Collections.Generic;

namespace NNLG
{
    public class Layer
    {
        public List<Neuron> Neurons { get; }
        public int Count => Neurons?.Count ?? 0;
        public Layer(List<Neuron> neurons, NeuronType= NeuronType.Normal)
        {
            Neurons = neurons;
        }
    }
}
