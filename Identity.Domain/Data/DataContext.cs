using Microsoft.EntityFrameworkCore;
using System;

namespace Identity.Domain.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
           => options.UseNpgsql("Host=pgsql10-farm76.kinghost.net;Port=5432;Database=acheidoc;User Id=acheidoc;Password=qazwsx2596;");

    }
}