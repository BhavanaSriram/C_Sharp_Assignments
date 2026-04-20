class Program
{
    static void Main(string[] args)
    {
        TicTacToeFacade game = new TicTacToeFacade();

        game.MakeMove(0, 0);
        game.MakeMove(0, 1);
        game.MakeMove(1, 1);
        game.MakeMove(0, 2);
        game.MakeMove(2, 2); // X wins

        game.ResetGame();
    }
}