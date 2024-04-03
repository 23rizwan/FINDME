using Blazorise;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "The field Display Order must be between 1-100.")]
        public int DisplayOrder { get; set; }
    }
}
//< body style = "background-color: purple;" >



    //< div class= "container mt-5 d-flex justify-content-center align-items-center" style = "height: calc(100vh - 56px);" >
    //    < !--56px is the height of the navbar -->
    //    <div class= "row justify-content-center" >
    //        < div class= "col-md-6" >
    //            < div class= "input-group" >
    //                < input type = "text" class= "form-control rounded-start" placeholder = "Search..." >
    //                < button type = "submit" class= "btn btn-primary rounded-end" > Search </ button >
    //            </ div >
    //        </ div >
    //    </ div >
    //</ div >
//</ body >