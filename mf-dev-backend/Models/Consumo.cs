using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models;

[Table("Consumos")]
public class Consumo
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage ="Obrigatório informar descrição!")]
    public string Descricao { get; set; }

    [Required(ErrorMessage ="Obrigatório informar a data!")]
    public DateTime Data { get; set; }

    [Required(ErrorMessage ="Obrigatório informar valor!")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage ="Obrigatório informar a quilometragem")]
    public int Km { get; set; }

    [Required(ErrorMessage ="Obrigatório informar tipo de combustível")]
    public TipoCombustivel Tipo { get; set; }

    [Required(ErrorMessage ="Obrigatório informar ID do veículo!")]
    public int VeiculoId {get; set; }

    [ForeignKey("VeiculoId")]
    public Veiculo Veiculo {get; set; }

}

public enum TipoCombustivel
{
    Gasolina,
    Etanol
}