using lab4_solid.DAL;
using lab4_solid.Entities;
using lab4_solid.Migrations;
using lab4_solid.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.Entity;

namespace lab4_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new SchoolInitializer());
        }
    }
}