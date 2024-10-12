using System.Formats.Asn1;

uppgift10();

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
void uppgift7(){
    Console.WriteLine("skriv in två tal");
    int tal1=int.Parse(Console.ReadLine());
    int tal2=int.Parse(Console.ReadLine());
    int summan= tal1+tal2;
    Console.WriteLine("summan av "+tal1+" och "+tal2+" är "+ summan );
}
void uppgift8(){
    Console.WriteLine("skriv in tre tal");
    int tal1=int.Parse(Console.ReadLine());
    int tal2=int.Parse(Console.ReadLine());
    int tal3=int.Parse(Console.ReadLine());
    double summa= tal1+tal2+tal3;
    Console.WriteLine("medelvärdet av dom tre talen är "+summa/3);
}
void uppgift9()
{
    Console.WriteLine("Gissa ett tal mellan 1 och 10");
    
    Random random = new Random();
    int tal = random.Next(1, 11); // Slumpar tal mellan 1 och 10
    int gissning = 0; // Initierar gissningen
    
    // Loopen fortsätter tills användaren gissar rätt
    while (gissning != tal)
    {
        
        gissning = Convert.ToInt32(Console.ReadLine()); // Läser användarens inmatning

        if (gissning < tal)
        {
            Console.WriteLine("Din gissning var för låg, försök ett högre tal.");
        }
        else if (gissning > tal)
        {
            Console.WriteLine("Din gissning var för hög, försök ett lägre tal.");
        }
        else
        {
            Console.WriteLine("Grattis! Du gissade rätt!");
        }
    }
}
void uppgift10()
{
    Console.WriteLine("Skriv in två tal");
    int tal1=int.Parse(Console.ReadLine());
    int tal2=int.Parse(Console.ReadLine());
    if(tal1>tal2){
        Console.WriteLine(tal1+" är större än "+tal2);
    }
    else if(tal2>tal1){
        Console.WriteLine(tal2+" är större än "+tal1);
    }
    else{
         Console.WriteLine("talen är lika stora");
    }
}