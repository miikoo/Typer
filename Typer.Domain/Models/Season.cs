using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Season
    {
        public long SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
