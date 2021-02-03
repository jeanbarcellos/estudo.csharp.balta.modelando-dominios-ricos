using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class BoletoPayment : Payment
    {
        public string BarCode { get; set; }
        public string BoletoNumber { get; set; }
    }
}