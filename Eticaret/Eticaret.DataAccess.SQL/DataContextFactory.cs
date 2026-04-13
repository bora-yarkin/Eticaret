// SPDX-FileCopyrightText: 2026 Bora Yarkın
// SPDX-License-Identifier: GPL-3.0-only

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Eticaret.DataAccess.SQL
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            var connectionString = Environment.GetEnvironmentVariable("ETICARET_CONNECTION_STRING")
                ?? "Server=localhost;Database=Eticaret;User Id=sa;Password=Str0ng_Passw0rd!;TrustServerCertificate=True;";

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString);

            return new DataContext(optionsBuilder.Options);
        }
    }
}
