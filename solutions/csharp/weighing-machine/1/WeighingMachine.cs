class WeighingMachine
{
    // TODO: define the 'Precision' property
    private int _precision;
    public int Precision => _precision;

    // TODO: define the 'Weight' property
    private double _weight;
    public double Weight {
        get => _weight;
        set
        {
            if (value > 0)
                _weight = value;
            else
                throw new ArgumentOutOfRangeException("Valor negativo");
        }
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment { get; set; }

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get => $"{(Weight - TareAdjustment).ToString($"F{_precision}")} kg";
    }

    public WeighingMachine(int precision)
    {
        this._precision = precision;
        this.TareAdjustment = 5.0;
    }
}
