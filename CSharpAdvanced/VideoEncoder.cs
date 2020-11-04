using System;
using System.Threading;

namespace CSharpAdvanced
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    /* This is the event publisher. */
    class VideoEncoder
    {
        /* Three steps to enable this class to publish an event. */
        // 1. Define a Delegate.
        // 2. Define an event based on that delegate.
        // 3. Raise the event.


        // EventHandler - normal form (no sending data)
        // EventHandler<TEventArgs> generic form (sending data)

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding vidoes...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        /* By convention, event publisher methods should be protected, virtual and void; 
         * start with 'On' then name of event. */
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs { Video = video });
        }
    }
}
