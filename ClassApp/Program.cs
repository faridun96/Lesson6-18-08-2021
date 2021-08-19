using System;

namespace ClassApp
{
    class Computer
    {
        public string cpu;
        public string motherboard;
        public string ram;
        public string gpu;
        public string hdd;
        public string ssd;
        public string powersupply;
        public string coolingsystem;
        public bool monitor;
        public bool mouse;
        public bool keyboard;
        public bool headphones;
        public bool loudspeakers;
        public void GetInfo()
        {
            Console.WriteLine($"Процессор: {cpu}\nМатеринская плата: {motherboard}\nОперативная память: {ram}\nВидеокарта: {gpu}\nЖёсткий диск: {hdd}\nТвердотельный накопитель: {ssd}\nБлок питания: {powersupply}\nСистема охлаждения: {coolingsystem}\nМонитор: {monitor}\nМышка: {mouse}\nКлавиатура: {keyboard}\nНаушники: {headphones}\nКолонки: {loudspeakers}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer c = new Computer();
            c.cpu = "AMD Ryzen™ Threadripper™ 3990X";
            c.motherboard = "ASUS ROG Zenith II Extreme";
            c.ram = "AMD R7 Performance DDR4 8x32GB";
            c.gpu = "AMD Radeon™ RX 6900 XT";
            c.hdd = "WD Purple WD140PURZ 14TB";
            c.monitor = true;
            c.mouse = true;
            c.keyboard = true;
            c.headphones = false;
            c.loudspeakers = false;
            c.ssd = "Corsair MP400 CSSD-F8000GBMP400 8TB";
            c.powersupply = "Corsair HX Series CP-9020140-EU";
            c.coolingsystem = "Cooler Master MasterLiquid Maker 240";
            c.GetInfo();
        }
    }
}
