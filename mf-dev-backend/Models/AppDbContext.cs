using System;
using Microsoft.EntityFrameworkCore;

//responsável por pegar todas as classe criadas e gerar tabelas banco de dados
namespace mf_dev_backend.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<Veiculo> Veiculos { get; set; }

    public DbSet<Consumo> Consumos { get; set; }

    public DbSet<Usuario> Usuarios {get; set;}
}
