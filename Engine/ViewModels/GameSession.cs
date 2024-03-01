using Engine.Models;

namespace Engine.ViewModels;

// Class used to manage the actual play session

public class GameSession
{
    Player _currentPlayer { get; set; }

    public GameSession()
    {
        _currentPlayer = new Player();
        _currentPlayer.Name = "Colton";
        _currentPlayer.CharacterClass = "Knight";
        _currentPlayer.Gold = 1000;
    }
}