namespace UruIT.GameOfDrones.Common
{
    public class Message
    {
        public Message(string message)
        {
            Text = message;
        }

        public string Text { get; set; }
    }
}