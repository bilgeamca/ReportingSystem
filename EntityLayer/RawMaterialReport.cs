public class RawMaterialReport
{
    public int Id { get; set; }
    public DateTime ReportDateTime { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal RequestedKg { get; set; }
    public decimal ProvidedKg { get; set; }
    public decimal ErrorKg { get; set; }
    public TimeSpan Duration { get; set; }
}