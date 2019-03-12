using System.ComponentModel.DataAnnotations;

namespace MVCDemoApp.Models
{
    public class Review
    {

        public int Id { get; set; }
        public string Comment { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }

        //Navigation  prop
        public Restaurant Restaurant { get; set; }

    }
}