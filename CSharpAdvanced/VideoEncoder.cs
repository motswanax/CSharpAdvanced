using System;
using System.Threading;

namespace CSharpAdvanced
{
    /* This is the event publisher. */
    class VideoEncoder
    {
        /* Three steps to enable this class to publish an event. */
        // 1. Define a Delegate.
        // 2. Define an event based on that delegate.
        // 3. Raise the event.

        public delegate void VideoEncoderEventHandler(object source, EventArgs args);
        public event VideoEncoderEventHandler VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding vidoes...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        /* By convention, event publisher methods should be protected, virtual and void; 
         * start with 'On' then name of event. */
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
