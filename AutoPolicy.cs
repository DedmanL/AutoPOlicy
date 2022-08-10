class AutoPolicy
{
    public int AccountNumber { get; set; }
    public string MakeAndModel { get; set; }
    public string State { get; set; }
    public AutoPolicy(int AccountNumber, string MakeAndModel, string State)
    {
        AccountNumber =   accountNumber;
        MakeAndModel = makeAndModel;
        State = state;
    }

    public bool IsNoFaultState
    {
        get
        {
            bool noFaultState;

            switch (State)
            {
                case CT: case MA: case ME: case NH: case NJ: case NY: case PA: case VT:
                    noFaultState = true; break;
                    default: noFaultState = false; break;
            }
            return noFaultState;
        }
    }
}