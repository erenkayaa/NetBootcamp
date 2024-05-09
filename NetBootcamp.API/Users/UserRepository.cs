namespace NetBootcamp.API.Users
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users =
        [
            new User { Id = 1, Name = "User 1", Email = "user1@gmail.com" },
            new User { Id = 2, Name = "User 2", Email = "user2@gmail.com" },
            new User { Id = 3, Name = "User 3", Email = "user3@gmail.com" }
        ];

        public IReadOnlyList<User> GetAll()
        {
            return _users;
        }

        public void Update(User user)
        {
            var index = _users.FindIndex(x => x.Id == user.Id);

            _users[index] = user;
        }

        public void Create(User user)
        {
            _users.Add(user);
        }


        public User? GetById(int id)
        {
            return _users.Find(x => x.Id == id);
        }

        // write delete method
        public void Delete(int id)
        {
            var user = GetById(id);

            _users.Remove(user!);
        }
    }
}