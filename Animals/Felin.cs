using System;

namespace Animals
{
    class Felin : Mamifere
    {
        public void Miauler() { Console.WriteLine("Miauler"); }
        public void Manger() { Console.WriteLine("Mange"); }
        public void Chasser(object animalO) { Console.WriteLine("Chasser " + animalO); } //Chasser(object)
        public void Chasser(string animalS) { Chasser(animalO: (object)animalS); } //Chasser(string)
        public void Chasser(int animalI) { Chasser(animalS: animalI.ToString()); } //Chasser(int)   
    }
}
