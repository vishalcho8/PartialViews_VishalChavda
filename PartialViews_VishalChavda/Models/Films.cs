using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViews_VishalChavda.Models
{
    public class Films
    {
        [StringLength(20, MinimumLength = 3)]
        public String Title { get; set; }
        public String Duration { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public String Description { get; set; }

    }
}
