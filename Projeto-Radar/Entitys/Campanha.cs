﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Radar.Entitys
{
    [Table("tb_campanhas")]
    public record Campanha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("nome", TypeName = "varchar(45)")]
        public string Nome { get; set; }

        [Required]
        [Column("descricao", TypeName = "varchar(100)")]
        public string Descricao { get; set; }

        [Required]
        [Column("data")]
        public DateOnly Data { get; set; }

        [Required]
        [Column("url_foto_prateleira", TypeName = "varchar(255)")]
        public string UrlFotoPrateleira { get; set; }

    }
}
