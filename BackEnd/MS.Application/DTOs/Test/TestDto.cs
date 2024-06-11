namespace MS.Application.DTOs.Test;

public class TestDto
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int PhotoID { get; set; }
    public Data.Entities.Attachment Photo { get; set; }
    
}