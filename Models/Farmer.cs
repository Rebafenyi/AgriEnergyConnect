namespace AgriEnergyConnect.Models
{
    public class Farmer
    {
        public int Id { get; set; }
        public string FarmName { get; set; }

        public string FullName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public required string Phone { get; set; }        
        public required string CreatedBy { get; set; }    
    }
}
