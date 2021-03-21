using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

         [RegularExpression(@"^[A-Z]+[a-zA-z0-9""'\s-]*$"), StringLength(1)]
     //   [Required]
        public string Rating { get; set; }


        // Første [A-Z] indikerer av forbokstav må være stor, neste [a-zA-Z] betyr av kun bokstaver er tillatt for 'genre'
        // [a-zA-z0-9""'\s-] betyr av det er tillatt med både bokstaver, tall og spesialtegn
        // [StringLenght] kan ta ulike parametere der første er maxlengen og andre (MininumLenght = ..) er min.lengden

        /* Ved å benytte validerringsregler:
            - Helps make the app more robust.
            - Reduce chances of saving invalid data to the database.
         */
    }
}