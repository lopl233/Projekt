namespace Projekt
{
    public class User
    {
        public string imie;
        public string nazwisko;
        public string adres;

        public string login;
        public string password;
        public string uprawnienia;

        public User(string imie, string nazwisko, string login, string pass, string adres, string uprawnienia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.login = login;
            this.password = pass;
            this.adres = adres;
            this.uprawnienia = uprawnienia;
        }
    }
}