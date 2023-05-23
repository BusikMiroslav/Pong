namespace Pong
{
    public struct Player
    {
        /// <summary>
        /// Get player name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get player game time
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// Get player game date
        /// </summary>
        public string Date { get; set; }

        public string GetPlayerInfoWithoutName()
        {
            return string.Format("{0} s  {1}", Time, Date);
        }
    }
}
