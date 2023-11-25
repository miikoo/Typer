using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Seasons.IsNextSeasonExist
{
    public class SeasonDto
    {
        public SeasonDto()
        {
            
        }
        public bool IsExist { get; set; }

        public SeasonDto(bool isExist)
        {
            IsExist = isExist;
        }
    }
}
