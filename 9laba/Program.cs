namespace _9laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logins logins = new Logins(10);
            Passwords passwords = new Passwords(10);

            Console.WriteLine("Придумайте ваш логин: ");
            string login = Console.ReadLine();

            Console.WriteLine("Придумайте ваш пароль: ");
            string password = Console.ReadLine();

            logins.Add(0, login);
            passwords.Add(0, password);

            Console.WriteLine("Логин: " + logins.Get(0) + "\nПароль: " + passwords.Get(0));
        }
    }

    class Logins : Objects<string>
    {
        public Logins(int lenght) : base(lenght)    
        {

        }
    }

    class Passwords : Objects<string>
    {
        public Passwords(int lenght) : base(lenght)
        {

        }
    }

    class Objects<T>
    {
        int Lenght { get; set; }
        T[] Array { get; set; }

        public Objects(int lenght)
        {
            Array = new T[lenght];
            this.Lenght = lenght;
        }

        public void Add(int index, T obj)
        {

            Array[index] = obj;
        }

        public void Remove(int index)
        {
            T[] newArray = new T[Array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = Array[i];
            }

            for (int i = index + 1; i < Array.Length; i++)
            {
                newArray[i - 1] = Array[i];
            }

            Array = newArray;
        }

        public T Get(int index)
        {
            return Array[index];
        }

        public int GetLenght()
        {
            return Array.Length;
        }
    }

}