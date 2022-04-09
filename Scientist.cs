namespace C_3_submarine
{
    class Scientist:Human
    {
        private Equipment equipment;
        private double time;
        public void Work(double _time)
        {
            time += _time;
            for(int i = 24; i <= time; i += 24)
            {
                equipment.GatherData();
            }
        }
        public Scientist(Equipment _equipment)
        {
            equipment = _equipment;
        }
    }
}
