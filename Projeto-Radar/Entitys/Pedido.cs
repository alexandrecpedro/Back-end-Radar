﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Radar.Entitys
{

    [Table("tb_pedidos")]
    public record Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("valor_total", TypeName = "DOUBLE")]
        public double ValorTotal { get; set; }

        [Required]
        [Column("data", TypeName = "DATE")]
        public DateOnly Data { get; set; }

        [ForeignKey("Categoria")]
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = default!;

    }
}
