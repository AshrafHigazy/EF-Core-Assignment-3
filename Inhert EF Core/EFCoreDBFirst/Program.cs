using EFCoreDBFirst.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Scaffold (Package tools)
            //GUI Extention (VS) (EF Core Power Tools)

            #region How to Write SQL Query...
            //using NorthwindContext context = new NorthwindContext();

            ////var Cats = context.Categories;

            ////foreach( var cat in Cats )
            ////{
            ////    Console.WriteLine(cat.CategoryName);
            ////}

            //// var Products = context.Products.FromSqlRaw("Select * From Products Where CategorId = 1");


            ////Interpolated $ 

            ////var CatId = 1;

            ////var Products = context.Products.FromSqlInterpolated($"Select * From Products Where CategoryId = {CatId}");

            ////if(Products.Any())
            ////{
            ////    foreach(var product in Products)
            ////    {
            ////        Console.WriteLine(product.ProductName);
            ////    }
            ////}

            ////-----DML
            ////Multiple Transcations 
            //// var Result = context.Database.ExecuteSqlRaw("Update Products Set ProductName = 'Tea' where ProductId = 1");

            ////var Id = 1;
            ////var Result = context.Database.ExecuteSqlInterpolated($"Update Products Set ProductName = 'Coffe' where ProductId = {Id}");
            ////if(Result >  0) Console.WriteLine("Success");
            ////else Console.WriteLine("Faild"); 
            #endregion

        }
    }
}
