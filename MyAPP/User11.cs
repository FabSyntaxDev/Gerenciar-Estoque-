namespace User
{
    internal class User11
    {
        public string nome;
        public string password = "1234";
        public string email = "test@gmai.com";


        public string dados()
        {
            return $"Nome: {nome}, Password: {password}, Email: {email}";
        }
    }
}
