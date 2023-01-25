﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Projeto_Radar.Entitys
{
    [Table("tb_posicoesProdutos")]
    public class PosicoesProduto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("posicao_x", TypeName = "INT")]
        public int PosicaoX { get; set; }
        [Column("posicao_y", TypeName = "INT")]
        public int PosicaoY { get; set; }


        [ForeignKey("Campanha")]
        [Column("campanha_id")]
        [JsonPropertyName("campanha_id")]
        public int CampanhaId { get; set; }
        public Campanha Campanha { get; set; } = default!;


    }
}
