using Microsoft.EntityFrameworkCore;

namespace _03._22.Models
{

    public partial class schemaContext : DbContext
    {
        public schemaContext()
        {
        }
        public schemaContext(DbContextOptions<schemaContext> options)
                : base(options)
        {
        }
        public virtual DbSet<Employee> Employees { get;set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                */
                optionsBuilder.UseMySQL("server=localhost;database=myschema;user=root;password=;SSL mode=none;");
            }
        }
    }



}
