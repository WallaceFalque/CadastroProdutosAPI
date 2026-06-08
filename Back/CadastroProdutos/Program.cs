using CadastroProdutos.Database;
using CadastroProdutos.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ProdutoService>();
builder.Services.AddScoped<IProdutosServices, ProdutosDbServices>();
builder.Services.AddDbContext<ApplicationDbContext>(c => c.UseSqlite("Data Source=Produtos.db"));

var app = builder.Build();
app.MapControllers();
 
// Configure the HTTP request pipeline. 
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapSwagger();
    app.MapSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();

public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
}