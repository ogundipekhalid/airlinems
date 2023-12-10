// See https://aka.ms/new-console-template for more information
using System.Data;
using AirLineManagmentApp.models.entities;
using AirlineMS.Context;
using Dapper;
using MySql.Data.MySqlClient;

var dtb = new DbContext();
dtb.CreateSchema();
