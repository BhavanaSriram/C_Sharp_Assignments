class TicTacToeFacade
{
    private Board board;
    private GameLogic logic;
    private char currentPlayer;

    public TicTacToeFacade()
    {
        board = new Board();
        logic = new GameLogic();
        currentPlayer = 'X';
    }

    public void MakeMove(int row, int col)
    {
        if (!board.PlaceMark(row, col, currentPlayer))
        {
            Console.WriteLine("Invalid move! Try again.");
            return;
        }

        board.Display();

        if (logic.CheckWinner(board.GetGrid(), currentPlayer))
        {
            Console.WriteLine($"Player {currentPlayer} Wins!");
            return;
        }

        if (logic.IsDraw(board.GetGrid()))
        {
            Console.WriteLine("Game is a Draw!");
            return;
        }

        // Switch player
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        Console.WriteLine($"Next Player: {currentPlayer}");
    }

    public void ResetGame()
    {
        board.Reset();
        currentPlayer = 'X';
        Console.WriteLine("Game Reset!");
        board.Display();
    }
}