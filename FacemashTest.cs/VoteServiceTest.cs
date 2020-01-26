using System;
using System.Collections.Generic;
using System.Text;
using FacemashRepository;
using FacemashService;
using Moq;

namespace FacemashTest.cs
{
    public class VoteServiceTest
    {
        protected VoteService ServiceUnderTest { get; }
        protected Mock<IVoteRepository> VoteRepositoryMock { get; }

        public VoteServiceTest()
        {
            VoteRepositoryMock = new Mock<IVoteRepository>();
                ServiceUnderTest = new VoteService(VoteRepositoryMock.Object);
        }
    }
}
