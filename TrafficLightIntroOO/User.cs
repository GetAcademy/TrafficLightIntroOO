namespace TrafficLightIntroOO
{
    internal class User
    {
        private List<User> _friends;

        public User()
        {
            _friends = new List<User>();
        }


        public void AddFriend(User friend)
        {
            _friends.Add(friend);
            friend._friends.Add(this);
        }
    }
}
