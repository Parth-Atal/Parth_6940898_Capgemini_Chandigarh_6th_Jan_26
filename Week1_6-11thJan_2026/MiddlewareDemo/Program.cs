var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthorization();

var app = builder.Build();


app.UseExceptionHandler("/error");
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();


app.MapGet("/", () => "Hello from Middleware App");
app.MapGet("/error", () => "An error occurred");

app.Run();
