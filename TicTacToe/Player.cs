namespace TicTacToe;

public class Player
{
    private string _name;

    public string Name
    {
        get => _name;
    }

    public Player(string name)
    {
        _name = name;
    }
}