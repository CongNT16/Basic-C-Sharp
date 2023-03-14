using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Phan_Mang_So
{
    internal class Battery
    {
        int energy;

        public Battery()
        {
            this.energy = 10;
        }

        //public Battery(int energy)
        //{
        //    this.energy = energy;
        //}

        public int GetEnergy() { return energy; }
        public void SetEnergy(int energy) { this.energy = energy; }

        public void decreaseEnergy()
        {
            if (this.energy -2 >= 0)
            {
                this.energy -= 2;
            }
            
        }
    }
    internal class FlashLamp
    {
        bool status;
        Battery battery ;

        public FlashLamp() 
        {
            this.status = false;
            //battery.SetEnergy(0);
        }

        public void setBattery(Battery b)
        {
            this.battery = b;
        }
        public Battery getBatteryInfo()
        {
           return battery;
        }
        public void turnOn()
        {
            if (battery.GetEnergy()>0)
            {
                this.status = true;
                battery.decreaseEnergy();
                Console.WriteLine("Den sang");
            }
            else
            {
                Console.WriteLine("Den khong sang");
            }
            
        }
        public void turnOff()
        {
            this.status = false;
            Console.WriteLine("Den tat");
        }

    }

    internal class TestFlashLamp
    {
        static void Main(string[] args)
        {
            Battery battery= new Battery();
            FlashLamp flashLamp = new FlashLamp();
            //lap pin cho den
            flashLamp.setBattery(battery);

            for (int i = 1; i <= 10; i++)
            {
                flashLamp.turnOn();
                flashLamp.turnOff();
                Console.WriteLine("Battery: " + flashLamp.getBatteryInfo().GetEnergy()); 
                Console.WriteLine();
            }
        }
    }


}
