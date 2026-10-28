using System.ComponentModel.DataAnnotations;

namespace YUKSELENISI_1.Models
{
    public class Hizmet
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Baslik { get; set; } = string.Empty;

        [Required, MaxLength(500)]
        public string Aciklama { get; set; } = string.Empty;

        [MaxLength(50)]
        public string IkonSinifi { get; set; } = string.Empty;

        public bool AktifMi { get; set; } = true;

        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}