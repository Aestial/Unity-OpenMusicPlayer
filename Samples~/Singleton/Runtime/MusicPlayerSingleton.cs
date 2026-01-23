using OpenMusicPlayer.Core;

namespace OpenMusicPlayer.Samples.Singleton
{
    public class MusicPlayerSingleton: MusicPlayerCore
    {
        public static MusicPlayerSingleton Instance {get; private set;}
        
        protected override void Awake()
        {
            base.Awake();
            // Make unique object (Singleton)
            if (Instance != null && Instance != this)
            {
                // Destroy other
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                // Add don't destroy on load.
                DontDestroyOnLoad(this);
            }
        }
    }
}