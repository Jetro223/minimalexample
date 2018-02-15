using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TestContext : DbContext
    {
        public DbSet<MyEntity> MyEntities { get; set; }

        public TestContext(string connectionString) : base(connectionString)
        {
        }
    }

//    USE[master]
//    GO
///****** Object:  Database [deleteme]    Script Date: 15.02.2018 09:29:01 ******/
//    CREATE DATABASE[deleteme]


//    USE[deleteme]
//    GO
///****** Object:  Table [dbo].[myentities]    Script Date: 15.02.2018 09:29:01 ******/
//    SET ANSI_NULLS ON
//    GO
//    SET QUOTED_IDENTIFIER ON
//    GO
//    CREATE TABLE[dbo].[myentities]
//    (

//    [Id][int] NOT NULL,

//    [Name] [varchar] (50) NULL,
//    CONSTRAINT[PK_myentities] PRIMARY KEY CLUSTERED
//    (
//    [Id] ASC
//    )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//    ) ON[PRIMARY]
//    GO
//    INSERT[dbo].[myentities]
//    ([Id], [Name]) VALUES(1, N'ssfsd')
//    GO
//    INSERT[dbo].[myentities]
//    ([Id], [Name]) VALUES(2, N'sdfsdfsdfs')
//    GO
//    USE[master]
//    GO
//    ALTER DATABASE[deleteme] SET  READ_WRITE
//    GO

}
