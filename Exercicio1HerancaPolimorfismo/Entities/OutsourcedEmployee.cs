using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1HerancaPolimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double payment = base.Payment();
            payment += (AdditionalCharge * 1.10);
            return payment;
        }
    }
}
