namespace Northwind.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Sobrenome = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}
