using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental
{
    internal class Car
    {
        int car_Id;
        string car_Model;
        string car_Make;
        int car_Year;
        string car_Color;
        string car_Transmission;
        string car_Vin;

        public Car() { }

        public Car(int car_Id, string car_Model, string car_Make,
            int car_Year, string car_Color, 
            string car_Transmission, string car_Vin)
        {
            this.Car_Id = car_Id;
            this.Car_Model = car_Model;
            this.Car_Make = car_Make;
            this.Car_Year = car_Year;
            this.Car_Color = car_Color;
            this.Car_Transmission = car_Transmission;
            this.Car_Vin = car_Vin;
        }

        public int Car_Id { get => car_Id; set => car_Id = value; }
        public string Car_Model { get => car_Model; set => car_Model = value; }
        public string Car_Make { get => car_Make; set => car_Make = value; }
        public int Car_Year { get => car_Year; set => car_Year = value; }
        public string Car_Color { get => car_Color; set => car_Color = value; }
        public string Car_Transmission { get => car_Transmission; set => car_Transmission = value; }
        public string Car_Vin { get => car_Vin; set => car_Vin = value; }
    }
}
