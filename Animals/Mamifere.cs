using System;
using HelloWorld;

namespace Animals
{
    class Mamifere : Object
    {
        public object Pattes { get; set; }
        public object Bouche { get; set; }
        public object Oreilles { get; set; }


        private object foo;

        public object Foo
        {
            get { return foo; }
            set { foo = value; }
        }


        private object Toto;
        public void SetToto(object toto)
        {
            Toto = toto;
        }
        public object GetToto()
        {
            return Toto;
        }
    }
}
