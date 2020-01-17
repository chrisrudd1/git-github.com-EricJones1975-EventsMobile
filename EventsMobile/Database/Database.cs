using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EventsMobile.Models;

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

       public Task<int> SaveFboAsync(Fbo fbo)
       {
           return _database.InsertAsync(fbo);
       }
        
    }
}
