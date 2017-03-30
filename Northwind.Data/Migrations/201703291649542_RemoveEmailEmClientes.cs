namespace Northwind.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveEmailEmClientes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cliente", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "Email", c => c.String(maxLength: 100));
        }
    }
}
