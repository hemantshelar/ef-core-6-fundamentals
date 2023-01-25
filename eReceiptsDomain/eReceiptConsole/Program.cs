// See https://aka.ms/new-console-template for more information
using eReceiptData;

Console.WriteLine("Hello, World!");

using ( eReceiptsDbContext dbContext = new eReceiptsDbContext())
{
	bool created = dbContext.Database.EnsureCreated();
	Console.WriteLine($"Data base was created = {created}");
}
