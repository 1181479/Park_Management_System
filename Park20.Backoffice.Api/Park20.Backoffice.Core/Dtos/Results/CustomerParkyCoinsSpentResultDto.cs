﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park20.Backoffice.Core.Dtos.Results
{
    public record CustomerParkyCoinsSpentResultDto(string Username, double ParkyCoinsSpent);
}
