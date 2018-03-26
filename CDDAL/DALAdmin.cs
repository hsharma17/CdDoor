using CDModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDDAL
{
   public class DALAdmin
    {
        public string RegisterProperty(submitNewProperty obj)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CDConnection"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(DALObjectsEnum.SPRegisterOwner, con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@ownerName",  obj.ownerName));
            command.Parameters.Add(new SqlParameter("@ownerEmail",  obj.email));
            command.Parameters.Add(new SqlParameter("@ownerNO",obj.phoneNo));
            command.Parameters.Add(new SqlParameter("@owneraddress",  obj.owneraddress));
            command.Parameters.Add(new SqlParameter("@ownercity",  obj.ownerCity));             
            command.Parameters.Add(new SqlParameter("@ownerstate",  obj.ownerState));
            command.Parameters.Add(new SqlParameter("@ownerCountry", obj.ownerCountry));
            command.Parameters.Add(new SqlParameter("@ownerpostalCode", obj.ownerPostalCode));
            
            command.Parameters.Add("@UserID", SqlDbType.Int).Direction = ParameterDirection.Output;


            command.ExecuteNonQuery();
            string value = command.Parameters["@UserID"].Value.ToString();

            command = new SqlCommand(DALObjectsEnum.SPRegisterProperty, con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@UserID", value));
            command.Parameters.Add(new SqlParameter("@propertyDescription", obj.propertyDescription));
            command.Parameters.Add(new SqlParameter("@type", obj.type.ToString()));
            command.Parameters.Add(new SqlParameter("@rooms", obj.rooms));
            command.Parameters.Add(new SqlParameter("@bathrooms", obj.Bathroom));
            command.Parameters.Add(new SqlParameter("@price", obj.price));
            command.Parameters.Add(new SqlParameter("@tenantPreferred", obj.tenantPreferred.ToString()));
            command.Parameters.Add(new SqlParameter("@availableFor", obj.availableFor.ToString()));

            command.Parameters.Add(new SqlParameter("@address", obj.address));
            command.Parameters.Add(new SqlParameter("@locality", obj.locality));
            command.Parameters.Add(new SqlParameter("@city", obj.city.ToString()));
            command.Parameters.Add(new SqlParameter("@state", obj.state.ToString()));
            command.Parameters.Add(new SqlParameter("@postalCode", obj.postalCode));
            command.Parameters.Add(new SqlParameter("@longitude", obj.longitude));
            command.Parameters.Add(new SqlParameter("@latitude", obj.latitude));

            command.Parameters.Add(new SqlParameter("@isFurnished", obj.isFurnished));
            command.Parameters.Add(new SqlParameter("@isSofa", obj.isSofa));
            command.Parameters.Add(new SqlParameter("@isTelevision", obj.isTelevision));
            command.Parameters.Add(new SqlParameter("@isWashingMachine", obj.isWashingMachine));
            command.Parameters.Add(new SqlParameter("@isFullySetupKitchen", obj.isFullySetupKitchen));
            command.Parameters.Add(new SqlParameter("@isCupboard", obj.isCupboard));
            command.Parameters.Add(new SqlParameter("@isWesternToilet", obj.isWesternToilet));

            command.Parameters.Add("@HouseID", SqlDbType.Int).Direction = ParameterDirection.Output;


            command.ExecuteNonQuery();
            string HouseID = command.Parameters["@HouseID"].Value.ToString();
            return HouseID;

        }
    }
}
