namespace _25dh110771_LETHANHBINH.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Product
    {
        [NotMapped]
        public HttpPostedFileBase UploadImg { get; set; }
    }
}