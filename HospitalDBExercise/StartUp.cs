﻿using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            using var db = new HospitalContext();

            db.Database.Migrate();
        }
    }
}
