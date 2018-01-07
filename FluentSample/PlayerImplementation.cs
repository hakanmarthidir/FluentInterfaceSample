namespace FluentSample
{
    public class PlayerImplementation : IPlayerImplementation
    {
        private IPlayer _player;        

        public IPlayerImplementation Create(string name, string lastname, byte power)
        {
            _player = new BasketballPlayer() {
                FirstName = name,
                LastName = lastname,
                Power = power
            };
            return this;
        }
        public IPlayerImplementation MakeAssist()
        {
            _player.Power -= 2;
            return this;
        }

        public IPlayerImplementation Run()
        {
            _player.Power -= 3;
            return this;
        }
        public IPlayer GetPlayer()
        {
            return _player;
        }
    }
    

}
