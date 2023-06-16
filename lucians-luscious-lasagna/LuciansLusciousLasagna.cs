class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesInOven) => this.ExpectedMinutesInOven() - minutesInOven;

    public int PreparationTimeInMinutes(int countLayers) => countLayers * 2;

    public int ElapsedTimeInMinutes(int countLayers, int minutesInOven) => this.PreparationTimeInMinutes(countLayers) + minutesInOven;
}
