using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class Adress : IEntity

    {
        public int Id { get; set; }
        public string YukselenIsı { get; set; }
        public string İzmir { get; set; }
        public string KARŞIYAKA { get; set; }
        public string MAHALLE { get; set; }
        public string Açıkadres { get; set; }
        public string PostaKodu { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public double? Enlem { get; set; }
        public double? Boylam { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate {  get; set; }
        
           

        }
    }

    

