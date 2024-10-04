
uppgift3();

void uppgift1(){
    string frukt= "äpple";
    int tal= 1;
    double vikt= 70*2;
    Console.WriteLine("jag har "+ ( tal+" "+frukt) +" som väger "+ (vikt));
}


void uppgift2(){

    int tal1= 5;
    int tal2=10;
    int summa= tal1+tal2;
    Console.WriteLine("Summan av 5 och 10 är " + (summa));
}
void uppgift3(){
    Random rand=new Random();
    int Radie=rand.Next(1,100);
    double o = Radie*Radie*Math.PI;
    Console.WriteLine(o);
    
}