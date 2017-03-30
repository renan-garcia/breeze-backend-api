namespace Northwind.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailEmClientes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Email", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "Email");
        }
    }
}
