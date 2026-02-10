namespace Lek3
{
    public struct Time
    {
        private int _secondsSinceMidnight;
        private const int _maxSeconds = 24 * 3600; // 86400 sekunder på et døgn

        // Constructor 1: Tager en string "hh:mm:ss"
        public Time(string timeString)
        {
            // Vi bruger Substring(start, længde)
            int h = int.Parse(timeString.Substring(0, 2));
            int m = int.Parse(timeString.Substring(3, 2));
            int s = int.Parse(timeString.Substring(6, 2));

            _secondsSinceMidnight = (h * 3600 + m * 60 + s) % _maxSeconds;
        }

        // Constructor 2: Tager 3 integers
        public Time(int h, int m, int s)
        {
            _secondsSinceMidnight = (h * 3600 + m * 60 + s) % _maxSeconds;
        }

        public int Hour
        {
            get { return _secondsSinceMidnight / 3600; }
            set
            {
                // Find sekunderne i den nuværende time (minutter + sekunder)
                int rest = _secondsSinceMidnight % 3600;
                // Opdater med den nye time-værdi
                _secondsSinceMidnight = (rest + value * 3600) % _maxSeconds;
            }
        }

        public int Min
        {
            get { return (_secondsSinceMidnight % 3600) / 60; }
            set
            {
                int timer = Hour * 3600;
                int sekunder = _secondsSinceMidnight % 60;
                _secondsSinceMidnight = (timer + (value * 60) + sekunder) % _maxSeconds;
            }
        }

        public int Sek
        {
            get { return _secondsSinceMidnight % 60; }
            set
            {
                int altUndtagenSekunder = (_secondsSinceMidnight / 60) * 60;
                _secondsSinceMidnight = (altUndtagenSekunder + value) % _maxSeconds;
            }
        }

        // ToString override: Formatere til "00:00:00"
        public override string ToString()
        {
            // D2 betyder: Decimal med minimum 2 cifre (tilføjer foranstillet nul)
            return $"{Hour:D2}:{Min:D2}:{Sek:D2}";
        }
    }
}