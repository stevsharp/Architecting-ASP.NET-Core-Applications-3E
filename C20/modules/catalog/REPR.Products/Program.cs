//using Microsoft.EntityFrameworkCore;
//using REPR.Products;

//var builder = WebApplication.CreateBuilder(args);
//builder.AddExceptionMapper(builder =>
//{
//    builder
//        .Map<DbUpdateException>()
//        .ToStatusCode(StatusCodes.Status409Conflict)
//    ;
//    builder
//        .Map<DbUpdateConcurrencyException>()
//        .ToStatusCode(StatusCodes.Status409Conflict)
//    ;
//});
//builder.AddFeatures();

//var app = builder.Build();
//app.UseExceptionMapper();
//app.MapFeatures();

//await app.SeedFeaturesAsync();

//app.Run();

//// Workaround that makes the autogenerated program public so tests can
//// access it without granting internal visibility.
//#pragma warning disable CA1050 // Declare types in namespaces
//public partial class Program { }
