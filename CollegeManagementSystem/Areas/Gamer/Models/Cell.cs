namespace TicTacToe.Models
{
    public class Cell
    {
        public string Id { get; set; } = string.Empty;
        public string Mark { get; set; } = string.Empty;

        public bool IsBlank => string.IsNullOrEmpty(Mark);
        public bool IsEndCell => Id.EndsWith("Right");
    }
}
