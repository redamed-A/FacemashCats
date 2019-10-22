using FacemashModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacemashService
{
    public interface IVote
    {
        Task<IEnumerable<Chat>> ReadAllAsync();
    }
}
