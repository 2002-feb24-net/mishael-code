namespace PersonList
{
    class Person
    {
        private string name = "";
        private int age = 0;

        public Person (string n)
        {
            name = n;
        }

        public Person (string n,int a)
        {
            name = n;
            age = a;
        }

        public override string ToString()
        {
            return name;
        }
    }
}