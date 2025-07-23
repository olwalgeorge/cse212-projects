public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] Features { get; set; } = [];
}

public class Feature
{
    public string Type { get; set; } = "";
    public Properties Properties { get; set; } = new Properties();
    public Geometry Geometry { get; set; } = new Geometry();
    public string Id { get; set; } = "";
}

public class Properties
{
    public double Mag { get; set; }
    public string Place { get; set; } = "";
    public long Time { get; set; }
    public long Updated { get; set; }
    public int? Tz { get; set; }
    public string Url { get; set; } = "";
    public string Detail { get; set; } = "";
    public int? Felt { get; set; }
    public double? Cdi { get; set; }
    public double? Mmi { get; set; }
    public string Alert { get; set; } = "";
    public string Status { get; set; } = "";
    public int Tsunami { get; set; }
    public int Sig { get; set; }
    public string Net { get; set; } = "";
    public string Code { get; set; } = "";
    public string Ids { get; set; } = "";
    public string Sources { get; set; } = "";
    public string Types { get; set; } = "";
    public int? Nst { get; set; }
    public double? Dmin { get; set; }
    public double? Rms { get; set; }
    public double? Gap { get; set; }
    public string MagType { get; set; } = "";
}

public class Geometry
{
    public string Type { get; set; } = "";
    public double[] Coordinates { get; set; } = [];
}