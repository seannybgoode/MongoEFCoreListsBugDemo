
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;
using MongoEFCoreListBugDemo.Models;



namespace MongoEFCoreListsBugDemo
{
    public class DemoDbContext : DbContext
    {
        public DbSet<CalloutTemplate> CalloutTemplates { get; init; }
        public static DemoDbContext Create(IMongoDatabase database) =>
            new(new DbContextOptionsBuilder<DemoDbContext>()
                .UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName)
                .Options);
        public DemoDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CalloutTemplate>().ToCollection("CalloutTemplate")
                                                    .OwnsMany<CallRound>("callRounds")
                                                    .OwnsMany<CollectionReference>("jobQualifiers").WithOwner();
        }
    }
}
