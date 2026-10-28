using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YUKSELENISI_1.Models
{
    // İletişim formundan gelen "Ücretsiz Keşif / Teklif Al" talepleri
    [Table("IletisimMesajlari")]
    public class IletisimMesaji
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string AdSoyad { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string Telefon { get; set; } = string.Empty;



        [MaxLength(100)]
        public string? HizmetTuru { get; set; }
        

        [Required]
        public string Mesaj { get; set; } = string.Empty;

        public DateTime GonderimTarihi { get; set; } = DateTime.Now;
    }
}