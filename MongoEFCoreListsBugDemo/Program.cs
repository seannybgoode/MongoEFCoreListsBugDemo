// See https://aka.ms/new-console-template for more information
using MongoDB.Bson;
using MongoDB.Driver;
using MongoEFCoreListBugDemo.Models;
using MongoEFCoreListsBugDemo;



//there is a script in the solution folder for creating the demo document you'll need to reproduce the bug,
//it will create the collection and add one document, we use NoSQLBooster, but this should work in your db frontend tool
//** refer to CalloutTemplate.cs for the offending list **
Console.WriteLine("Entity Framework Lists Bug Demo");
string dbSecret = "username:password";
var connectionStr = string.Format("your connection string", dbSecret);
var client = new MongoClient(connectionStr);
DemoDbContext db = DemoDbContext.Create(client.GetDatabase("you demo database name"));

CalloutTemplate template = db.CalloutTemplates.Where(x => x._id == new ObjectId("your demo document object id")).First();
