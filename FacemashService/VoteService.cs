using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacemashModel;
using FacemashRepository;

namespace FacemashService
{
    public class VoteService : IVoteService
    {
        private IVoteRepository _voteRepository;

        public VoteService(IVoteRepository voteRepository)
        {
            _voteRepository = voteRepository??throw new NullReferenceException();
        }
        public Task<IEnumerable<Chat>> ReadAllAsync()
        {
            return null;
        }
    }
}
