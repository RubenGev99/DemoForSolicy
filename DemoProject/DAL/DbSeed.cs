using DemoProject.Models;

namespace DemoProject.DAL
{
    public class DbSeed
    {
        public static void Initialize(AccountsContext context)
        {
            context.Database.EnsureCreated();

            
            if (context.Accounts.Any())
            {
                return;
            }
            var owners = new Owner[]
           {
                new Owner{Name="Test1"},
                new Owner{Name="Test2"},
                new Owner{Name="Test3"},
                new Owner{Name="Test4"},
                new Owner{Name="Test5"},
           };
            foreach (Owner o in owners)
            {
                context.Owners.Add(o);
            }
            context.SaveChanges();

            var accounts = new Account[]
            {
                new Account{Name="Test1",CreatedDate= DateTime.UtcNow ,UpdatedDate=DateTime.Parse("2005-09-01"), Owner = owners[0] },
                new Account{Name="Test2",CreatedDate= DateTime.MinValue ,UpdatedDate=DateTime.Parse("2006-09-01"), Owner = owners[1] },
                new Account{Name="Test3",CreatedDate= DateTime.MaxValue ,UpdatedDate=DateTime.Parse("2007-09-01"), Owner = owners[2] },
                new Account{Name="Test4",CreatedDate= DateTime.Now ,UpdatedDate=DateTime.Parse("2008-09-01"), Owner = owners[3] },
                new Account{Name="Test5",CreatedDate= DateTime.UtcNow ,UpdatedDate=DateTime.Parse("2009-09-01"), Owner = owners[4] },
            };
            foreach (Account a in accounts)
            {
                context.Accounts.Add(a);
            }
            context.SaveChanges();
        }
    }
}
