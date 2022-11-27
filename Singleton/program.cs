
using System;

namespace Singleton{

    class program {

        static void Main (String[]args){

            Console.WriteLine(Singleton.GetInstance().GetText());
            // Hello word yazacak
        }
    }
}
