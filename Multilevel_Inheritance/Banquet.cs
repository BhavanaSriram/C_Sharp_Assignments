using System;

public class Banquet
{
    public int BanquetId;
    public string BanquetName;
    public int Capacity;

    public Banquet(int id, string name, int capacity)
    {
        BanquetId = id;
        BanquetName = name;
        Capacity = capacity;
    }

    public virtual int CalculateEarning()
    {
        return 2000;
    }
}

public class Event : Banquet
{
    public int TotalPax;

    public Event(int id, string name, int capacity, int totalPax)
        : base(id, name, capacity)
    {
        TotalPax = totalPax;
    }

    public override int CalculateEarning()
    {
        return TotalPax * base.CalculateEarning();
    }
}
public class SpecialEvent : Event
{
    public int ExtraCharge;

    public SpecialEvent(int id, string name, int capacity, int totalPax, int extra)
        : base(id, name, capacity, totalPax)
    {
        ExtraCharge = extra;
    }

    public override int CalculateEarning()
    {
        return base.CalculateEarning() + ExtraCharge;
    }
}