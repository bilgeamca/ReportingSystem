using System;  

namespace ReportingSystem.EntityLayer  
{  
    public class ReportType  
    {  
        public int Id { get; set; }  
        public string Name { get; set; }  
        public string Description { get; set; }  
        public bool IsActive { get; set; }  
        public DateTime CreatedDate { get; set; }  
    }  
}