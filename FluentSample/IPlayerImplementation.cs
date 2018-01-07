namespace FluentSample
{
    public interface IPlayerImplementation
    {
        IPlayerImplementation Create(string name, string lastname, byte power);
        IPlayerImplementation Run();
        IPlayerImplementation MakeAssist();
        IPlayer GetPlayer();
    }
    

}
