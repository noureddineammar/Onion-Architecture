using Application.Wrappers;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers
{
    public class PaginationFilter : IRequest<PagedResponse<List<Product>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string route { get; set; }

        public PaginationFilter(int pageNumber, int pageSize, string route)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = (pageSize > 10 | pageSize < 1) ? 10 : pageSize;
            this.route = route;
        }
    }
}
