﻿using Newtonsoft.Json;

namespace LiveCoding.Infra;

public class BarRepository : IBarRepository
{
    public IEnumerable<BarData> Get()
    {
        var json = File.ReadAllText("../LiveCoding.Persistence/Data/bars.json");
        var bars = JsonConvert.DeserializeObject<BarsData>(json);

        return bars.Bars;
    }
}