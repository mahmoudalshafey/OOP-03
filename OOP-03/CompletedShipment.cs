using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_03
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Completed Shipment");

            base.PrintShipment();
        }
    }
}
