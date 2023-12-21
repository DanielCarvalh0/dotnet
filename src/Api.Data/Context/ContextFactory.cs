namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeObContextFactory<MyContext> {
        public MyContext CreateDbContext (string[] args) {
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=root123";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext> ();
            optionsBuilder.UseMySql (connectionString);
            return new MyContext (optionsBuilder.Options);
        }
    }
}