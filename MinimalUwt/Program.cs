using MinimalUwt.Models;
using MinimalUwt.Services;
using System.Data;
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IMovieService, MovieService>();
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/create", (Movie movie, IMovieService service) => Create(movie, service));

app.MapGet("/get", (int id, IMovieService service) => Get(id, service));

app.MapGet("/list", (IMovieService service) => List(service));

app.MapPut("/update", (Movie newMovie, IMovieService service) => UpdateRowSource(newMovie, service));

app.MapDelete("/delete", (int id, IMovieService service) => Delete(id, service));

app.Run();
