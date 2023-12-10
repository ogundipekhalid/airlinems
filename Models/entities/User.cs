using System.Data;
using AirLineManagmentApp.models.enums;
using Dapper;
using MySql.Data.MySqlClient;

namespace AirLineManagmentApp.models.entities
{
    public class User : BaseEntity
    {
        public string Name{ get;set;}
        public string Email{ get;set;}
        public int Pin{ get;set;}
        public Gender Gender{ get;set;}
        public string PhoneNumber{ get;set;}
        public string Role{ get;set;}
    }
}