using System;

namespace CSharpAdvanced
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending a text message... ");
        }
    }
}
