using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SH.HMAngular.Models;

namespace SH.HMAngular.Services
{
    public class DashboardService : IDashboardService
    {
        public List<Candidate> GetCandidate()
        {
            IList<Candidate> candidates = new List<Candidate>
            {
                new Candidate { CandidateId = 1, CandidateName = "Soumendra", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 2, CandidateName = "Asim", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 3, CandidateName = "Anil", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 4, CandidateName = "Abhinav", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 5, CandidateName = "Asutosasis", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 6, CandidateName = "Sakti", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 7, CandidateName = "Vidharva", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 8, CandidateName = "Rakesh", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 9, CandidateName = "Abhijit", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 10, CandidateName = "Om", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 11, CandidateName = "Kunal", Phone = "9999999999", CandidateStatus =  CandidateStatus.L3},
                new Candidate { CandidateId = 12, CandidateName = "Soumendra", Phone = "9999999999", CandidateStatus =  CandidateStatus.L2},
                new Candidate { CandidateId = 13, CandidateName = "Om", Phone = "9999999999", CandidateStatus =  CandidateStatus.L2},
                new Candidate { CandidateId = 14, CandidateName = "Vidharva", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 15, CandidateName = "Pravat", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 16, CandidateName = "Vidharva", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 17, CandidateName = "Vidharva", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 18, CandidateName = "Vidharva", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 19, CandidateName = "Asutosasis", Phone = "9999999999", CandidateStatus =  CandidateStatus.L1},
                new Candidate { CandidateId = 20, CandidateName = "Anil", Phone = "9999999999", CandidateStatus =  CandidateStatus.L2}
            };

            return candidates.ToList();
        }
    }
}
