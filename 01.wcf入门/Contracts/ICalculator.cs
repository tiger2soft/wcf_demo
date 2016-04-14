using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace Contracts
{
    [ServiceContract(Name = "CalculatorService", Namespace = "http://www.gh0stman.com")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x, double y);
        [OperationContract]
        double Subtract(double x, double y);
        [OperationContract]
        double Multiply(double x, double y);
        [OperationContract]
        double Divide(double x, double y);
    }
}
