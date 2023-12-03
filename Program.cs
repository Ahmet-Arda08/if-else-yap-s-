 {
        int time = DateTime.Now.Hour;

    if(time>=6 && time < 11)
       Console.WriteLine("günaydın");
    else if(time<=17)
       Console.WriteLine("iyi günler");
    else
       Console.WriteLine("iyi geceler");
            
    string sonuc = time<=18 ? "iyi günler": "iyi geceler";
    Console.WriteLine(sonuc); 

    sonuc = time>=6 && time<19 ?"günaydın": time<=20 ? "iyi günler": "iyi geceler";
    Console.WriteLine(sonuc);    
    }
