using System.ComponentModel.DataAnnotations;

namespace Eterna_Template.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [StringLength(maximumLength:35)]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Button { get; set; }




    }
}
