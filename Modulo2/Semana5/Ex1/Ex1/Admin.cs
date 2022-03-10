namespace ClassLibrary
{
    public class Admin
    {
        public int Id { get; set; }

        public string Username { get; set; }

        private string AuthenticationHash { get; set; }

        public string Name { get; set; }
    }
}
