

using hw2;

LegAvto avto1 =new LegAvto("BMW", "F90", "Black", 6);
LegAvto avto2 =new LegAvto("NISSAN", "Maxima", "Green", 2);
LegAvto avto3 =new LegAvto("LEXUS", "GX460", "Black", 4);
LegAvto avto4 =new LegAvto("MERCEDES", "CLS", "Black", 6);

GruzAvto gavto1= new GruzAvto("KAMAZ","djd","yellow",2); 
GruzAvto gavto2= new GruzAvto("GAZ", "aks", "white",3);
GruzAvto gavto3= new GruzAvto("DAF","sdk","orange",4);

GruzSamalyot gsam1=new GruzSamalyot("Airbus","A400","white",5);
GruzSamalyot gsam2=new GruzSamalyot("Boeing","|||","blackwhite",5);
GruzSamalyot gsam3=new GruzSamalyot("AH","124","white",5);

PasSamalyot psam1=new PasSamalyot("Airbus","A310","white",7);
PasSamalyot psam2=new PasSamalyot("Boeing","747","white",6);
PasSamalyot psam3=new PasSamalyot("IL","96","white",7);

Poezd poezd1 =new Poezd("Locomotion","skdl","red",8);
Poezd poezd2 =new Poezd("Afrosiyob","dkfj","black",8);
Poezd poezd3 =new Poezd("AGV","575","white",8);

Transport transport = new Transport("Traffic","dnf","black",3);
avto1.GetInfo();
avto2.GetInfo();
avto3.GetInfo();
avto4.GetInfo();
System.Console.WriteLine("--------------------------");
gavto1.GetInfo();
gavto2.GetInfo();
gavto3.GetInfo();
System.Console.WriteLine("--------------------------");
gsam1.GetInfo();
gsam2.GetInfo();
gsam3.GetInfo();
System.Console.WriteLine("--------------------------");
psam1.GetInfo();
psam2.GetInfo();
psam3.GetInfo();
System.Console.WriteLine("--------------------------");
poezd1.GetInfo();
poezd2.GetInfo();
poezd3.GetInfo();
System.Console.WriteLine("--------------------------");


