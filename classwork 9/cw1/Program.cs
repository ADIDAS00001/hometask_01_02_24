using cw1;

Phone phone1 =new Phone("Iphone15", 14000 );
Phone phone2 =new Phone("Iphone14", 12000 );
Phone phone3 =new Phone("Iphone13", 10000 );

Car car1 =new Car("Toyota", 140000);
Car car2 =new Car("Lexus" , 150000);
Car car3 =new Car("Nissan", 160000);

Shop shop = new Shop();
shop.AddProduct(phone1);
shop.AddProduct(phone2);
shop.AddProduct(phone3);
shop.AddProduct(car1);
shop.AddProduct(car2);
shop.AddProduct(car3);

phone1.GetInfo();
phone2.GetInfo();
phone3.GetInfo();
car1.GetInfo();
car2.GetInfo();
car3.GetInfo();

shop.RemoveProduct(phone2);

