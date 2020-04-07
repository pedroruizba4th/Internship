﻿using Internship.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.API.Services.Interfaces
{
    public interface IInternService
    {
        InternDTO Create(InternDTO intern);
        InternDTO GetInternById(string id);
        InternDTO Update(string id, InternDTO internIn);
        InternDTO GetAll();

    }
}

