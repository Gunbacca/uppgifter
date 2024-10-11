uppgift6();

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
    void uppgift4(){
    string namn="Alvin";
    string mat="thai mat";
    Console.WriteLine("Mitt namn är"+" " +(namn) +" "+"och jag gillar"+" "+(mat));
}
void uppgift5(){
    Console.WriteLine("Skriv din ålder");
    string ålder=Console.ReadLine();
    int å=int.Parse(ålder);
    Console.WriteLine("Du är "+ å +" år gammal");
}
void uppgift6(){
    Console.WriteLine("Skriv ett tal");
    string kvadrat=Console.ReadLine();
    int k=int.Parse(kvadrat);
}
