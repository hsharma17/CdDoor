using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDModels
{
    class AdminModels
    {
    }

   public  class submitNewProperty
    {       //Basic Information
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Property Description")]
        public string propertyDescription { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Type")]
        public roomtype type { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Rooms")]
        public int rooms { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bathroom")]
        public int Bathroom { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Price")]
        public decimal price { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Tenant Preferred")]
        public tenantPref tenantPreferred { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Available For")]
        public availFor availableFor  { get; set; }

        //Property Location

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Locality")]
        public string locality { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public CityList city { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public StateList state { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Postal Code")]
        public int postalCode { get; set; }

       
        [DataType(DataType.Text)]
        [Display(Name = "longitude")]

        public string longitude { get; set; }
       
        [DataType(DataType.Text)]
        [Display(Name = "latitude")]
        public string latitude { get; set; }
        //Detailed Information

        [Display(Name="Isfurnished")]
        public bool isFurnished { get; set; }

        [Display(Name = "IsSofa")]
        public bool isSofa { get; set; }

        [Display(Name = "IsTelevision")]
        public bool isTelevision { get; set; }

        [Display(Name = "IsWashingMachine")]
        public bool isWashingMachine { get; set; }

        [Display(Name = "IsfullySetupKitchen")]
        public bool isFullySetupKitchen { get; set; }

        [Display(Name = "IsCupboard")]
        public bool isCupboard { get; set; }

        [Display(Name = "IsWesternToilet")] 
        public bool isWesternToilet { get; set; }

        //Owner Details
        
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Owner Name")]
        public string ownerName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone no")]
        public int phoneNo { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Owner Address")]
        public string owneraddress { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Owner City")]
        public CityList ownerCity { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public StateList ownerState { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Country")]
        public string ownerCountry { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal Code")]
        public int ownerPostalCode { get; set; }

        public enum roomtype
        {
            Apartment,
            Flat,
            Villa,
            Pg
        }

        public enum tenantPref
        {
            Students,
            Working,
            Both,
        }
        public enum availFor
        {
            All,
            Family,
            Girls,
            Boys
        }

        public enum StateList
        {
            Delhi,
            uttarakhand            
        }

        public enum CityList
        {
            Delhi,
            Dehradun
        }
        
    }

 
}
