using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SH.HMAngular.Models;

namespace SH.HMAngular.Services
{
    public interface IDashboardService
    {
         List<Candidate> GetCandidate();
    }
}
