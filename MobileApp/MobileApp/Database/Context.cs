using MobileApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace MobileApp.Database
{
    public abstract class Context<T>
    {
        public string DatabasePath { get; set; }
        public SQLiteConnection connection;
        public Context()
        {
            DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "orders.db");
            connection = new SQLiteConnection(DatabasePath);
            connection.CreateTable<Order>();
        }
        public void Insert(T item) => connection.Insert(item);
        public void Update(T item) => connection.Update(item);
        public void Delete(T item) => connection.Delete(item);
        public abstract List<Order> GetAll();
    }
}
