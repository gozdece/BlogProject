using BlogProject.Application.Interfaces.Repository;
using BlogProject.Application.Parameters;
using BlogProject.Application.Services;
using BlogProject.Application.UnitOfWorks;
using BlogProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Service.Services
{
    public class PostService : Service<Post>, IPostService
    {
        private readonly IPostRepository _repository;
        public PostService(IRepository<Post> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public PagingResultModel<Post> GetAllPosts(PageRequestParameter requestParameter)
        {
            requestParameter = new PageRequestParameter();
            return  _repository.GetAllPosts(requestParameter);
        }
    }
}
