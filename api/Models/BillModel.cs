namespace api.Models;

public class BillModel
{
    public int userId { get; set; }
    
    public int shippingAddId { get; set; }
    
    public int deliveryAddId { get; set; }
    
    public string pickupType { get; set; }
    
    public string deliveryType { get; set; }
    
    public string payer { get; set; }
    
    public string note { get; set; }
    
    public double cod { get; set; }
    
    public string name { get; set; }
    
    public string nature { get; set; }
    
    public double weight { get; set; }
    
    public int length { get; set; }
    
    public int width { get; set; }
    
    public int height { get; set; }
    
    public double value { get; set; }
}