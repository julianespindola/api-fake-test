using api_fake_test.Class;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();



/// <summary>
/// Get - Hello World
/// </summary>
/// <returns>String - Hello World</returns>
app.MapGet("/", () => "Hello World");

/// <summary>
/// GetRecord - Return one record of object (name, code, active)
/// </summary>
/// <returns></returns>
app.MapGet("/getRecord", () => Results.Ok(RecordFake.GetOneRecord()));

/// <summary>
/// GetList - Return 20 records of object (name, code, active)
/// </summary>
/// <returns>20 records of object (name, code, active)</returns>
app.MapGet("/getList", () => Results.Ok(RecordFake.GetAnyRecords(20)));

/// <summary>
/// Post - Receive and return the same data
/// </summary>
/// <value>returns the same data you received</value>
app.MapPost("/post", (dynamic value) =>
{    
    return Results.Ok(value);
});

/// <summary>
/// Pupt - Receive and return the same data
/// </summary>
/// <value>returns the same data you received</value>
app.MapPost("/put", (dynamic value) =>
{    
    return Results.Ok(value);
});

app.Run();
