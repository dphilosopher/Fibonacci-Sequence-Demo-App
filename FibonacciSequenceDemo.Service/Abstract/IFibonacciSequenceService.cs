using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceDemo.Service.Abstract
{
    public interface IFibonacciSequenceService
    {
        int[] GenerateSequence(int maxValue);
        int[] GenerateSequence(string maxValue);
    }
}
