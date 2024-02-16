namespace GwentLogic;

public class Game
{
    public Game()
    {
        StartGame();

        while (false)
            new Round();

        EndGame();
    }

    void StartGame()
    {
        SetLeaders();
        SetDecks();
        SetHands();

        void SetDecks() { }
        void SetLeaders() { }
        void SetHands() { }

    }

    void EndGame() { }

}



