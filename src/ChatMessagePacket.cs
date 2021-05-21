using System;

namespace HaltEventTime
{
    public class ChatMessagePacket
    {
        public int Delay;
        public string Message;
        public Microsoft.Xna.Framework.Color Color;

        public ChatMessagePacket(string message, Microsoft.Xna.Framework.Color color, int delay = 0)
        {
            Delay = delay;
            Message = message ?? throw new ArgumentNullException(nameof(message));
            Color = color;
        }

        public override string ToString()
        {
            return $"{nameof(ChatMessagePacket)}: Message={Message}, Color={Color}, Delay={Delay}";
        }
    }
}
