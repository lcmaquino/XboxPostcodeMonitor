using System;

namespace PostCodeSerialMonitor.Models;
public class DecodedCode
{
    public CodeFlavor Flavor { get; set; }
    public int Index { get; set; }
    public int Code { get; set; }
    public CodeSeverity SeverityLevel { get; set; } = CodeSeverity.Info;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public override int GetHashCode()
    {
        var result = 0;
        result = (result * 397) ^ Convert.ToInt32(Flavor);
        result = (result * 397) ^ Index;
        result = (result * 397) ^ Code;
        result = (result * 397) ^ Convert.ToInt32(SeverityLevel);
        return result;
    }

    public override bool Equals(object? obj) => this.Equals(obj);

    public bool Equals(DecodedCode obj)
    {
        return (
            this.Flavor == obj.Flavor
            && this.Index == obj.Index
            && this.Code == obj.Code
            && this.SeverityLevel == obj.SeverityLevel
        );
    }
}