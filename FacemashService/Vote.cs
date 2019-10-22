using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacemashModel;

namespace FacemashService
{
    public class Vote : IVote
    {
        public Task<IEnumerable<Chat>> ReadAllAsync()
        {
            return null;
        }
    }
}
