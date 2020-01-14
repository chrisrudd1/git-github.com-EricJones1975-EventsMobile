using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventsMobile.Database
{
   public class Database
   {
       readonly SQLiteAsyncConnection _database;

       public Database(string dbPath)
       {
           _database = new SQLiteAsyncConnection(dbPath);
           _database.CreateTableAsync<Fbo>().Wait();
       }

       public Task<List<Fbo>> GetFboAsync()
       {
           return _database.Table<Fbo>().ToListAsync();
       }

       public Task<int> SavePersonAsync(Fbo fbo)
       {
           return _database.InsertAsync(fbo);
       }
   }
}
