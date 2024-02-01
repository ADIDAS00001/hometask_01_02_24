
using hw1;

Laptop laptop1 = new Laptop("HP", 10000, 100,10);
Laptop laptop2 = new Laptop("DEEL", 12000, 90,8);
Laptop laptop3 = new Laptop("ACER", 14000, 80,16);

SmartPhone phone1 =new SmartPhone("Iphone", 15000, 95, "48mp" );
SmartPhone phone2 =new SmartPhone("Samsung", 2000, 100, "100mp" );
SmartPhone phone3 =new SmartPhone("Redmi", 1000, 100, "24mp" );

Computer computer = new Computer("hp", 100,10);
laptop1.GetInfo();
laptop2.GetInfo();
laptop3.GetInfo();
phone1.GetInfo();
phone2.GetInfo();
phone3.GetInfo();