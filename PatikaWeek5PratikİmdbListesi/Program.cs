using System;
using System.Collections.Generic;
// Film sınıfı oluşturuldu ve propetry tanımlamaları yapıldı
class Movie
{
    public string Name { get; set; } 
    public double ImdbRate { get; set; }
}

class Program
{
    static void Main()
    {
        // Filmlerin tutulacağı liste tanımlandı
        List<Movie> movieList = new List<Movie>();
       
        //Döngü çıkışı için değişken tanımlaması
        string kullaniciCevabi;

        do
        {
            //Kullanıcıdan film ismi girişi istendi ve değişkene atandı
            Console.Write("Lütfen film adını giriniz: ");
            string movieName = Console.ReadLine() ?? string.Empty;
            
            //İmdb puanı için değişken tanımlandı
            double imdbRate;
            
            //Kullanıcıdan imdb puanı girişi istendi ve değişkene atandı
                Console.Write("Lütfen IMDb puanını giriniz: ");
                imdbRate = Convert.ToDouble(Console.ReadLine());
                
            //Yapılan grişler ile yeni film nesnesi oluşturuldu ve girişler proopetrylere eşlendi
            Movie newMovie = new Movie
            {
                Name = movieName,
                ImdbRate = imdbRate
            };
            
            //Oluşturulan film nesnesi listeye eklendi
            movieList.Add(newMovie);
            
            //Kullanıcıya yeni bir film girişi yapmak istediği soruldu ve cevaba göre döngü başa döndü ve sonlandı
            Console.Write("Yeni bir film eklemek istiyor musunuz? (evet/hayır): ");
            kullaniciCevabi = Console.ReadLine()?.ToLower() ?? "hayır";

        } while (kullaniciCevabi == "evet");

        //Kullanıcının giriş yaptığı bütün filmler giriş sırasına göre ekrana yazıldı

        Console.WriteLine("\nFilm Listesi:");
        foreach (var film in movieList)
        {
            Console.WriteLine($"Film İsmi: {film.Name}, IMDb Puanı: {film.ImdbRate}");
        }

        Console.WriteLine("-------------------------------------------------------------------");
        
        
        Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler:");
        
        //4 ile 9 arasında imdb puanaı olan filmler için bir liste oluşturuldu
        List<Movie> filteredByImdb = new List<Movie>();

        // IMDb puanı 4 ile 9 arasında olan filmler için filtreleme döngüsü oluşturuldu.
        foreach (var film in movieList)
        {
            if (film.ImdbRate >= 4 && film.ImdbRate <= 9)
            {
                filteredByImdb.Add(film);//Sorguya göre filmler yeni listeye eklendi
            }
        }

        // Filtrelenmiş ve yeni listeye yazılan filmler ekrana yazdırıldı.
        foreach (var movie in filteredByImdb)
        {
            Console.WriteLine($"Film İsmi: {movie.Name}, IMDb Puanı: {movie.ImdbRate}");
        }
        Console.WriteLine("---------------------------------------------------------------");
        
        
        //İsmi "A" ile başlayan filmler için bir liste oluşturuldu
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler:");
        List<Movie> filteredByName = new List<Movie>();

        //İsmi "A" ile başlayan filmler için filtreleme döngüsü oluşturuldu.
        foreach (var movie in movieList)
        {
            if (movie.Name.StartsWith("A"))//StartWith methodu belirtilen eleman ile başlayan char ifadelerin listede bulunmasını sağlayan methoddur.
            {
                filteredByName.Add(movie);
            }
        }

        // Filtrelenmiş filmleri ekrana yazdırıldı
        foreach (var movie in filteredByName)
        {
            Console.WriteLine($"Film İsmi: {movie.Name}, IMDb Puanı: {movie.ImdbRate}");
        }



    }

}