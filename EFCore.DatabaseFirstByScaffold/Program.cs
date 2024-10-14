﻿// See https://aka.ms/new-console-template for more information
using EFCore.DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using(var context = new EfcoreDatabaseFirstDbContext())
{
    var products = await context.Products.ToListAsync();
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id} - {p.Name} - {p.Price}");
    });
}