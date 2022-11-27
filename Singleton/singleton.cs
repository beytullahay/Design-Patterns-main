
using System;

// Singleton Classımız.
public class Singleton
{
    private string text;

    // static cünkü tek ve nesne oluşturmasını gerek kalmadan çağırmak için
    // instance değeri nesne oluşturulmuşmu onu kontrol ediyor
    private static Singleton instance = null;
    

    // asıl Singletonumuz
    // private yaptık ki direkt ulaşılamasın.
    // Bu constructer
    private Singleton()
    {
        text = "Hello World";
    }


    // İçeride eğer instance null ise nesne oluşturuyor.
    // null değilse geri döndürüyor.
    // Singleton tipinde fonksiyon oluşturduk.
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        
        return instance;
    }



    public string GetText()
    {
        return text;
    }
}


