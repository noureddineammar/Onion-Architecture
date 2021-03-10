using Application.Helpers;
using Application.IServices;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Queries
{
    public class GetAllProductsQuery : IRequest<PagedResponse<List<Product>>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<PaginationFilter, PagedResponse<List<Product>>>
        {
            private readonly IApplicationContext _context;
            private readonly IUriService _uriService;

            public GetAllProductsQueryHandler(IApplicationContext context, IUriService uriService)
            {
                _context = context;
                _uriService = uriService;
            }

            public async Task<PagedResponse<List<Product>>> Handle(PaginationFilter request, CancellationToken cancellationToken)
            {
                var validFilter = new PaginationFilter(request.PageNumber, request.PageSize, request.route);
                List<Product> pagedData = await _context.Products
                    .Skip((validFilter.PageNumber - 1) * request.PageSize)
                    .Take(validFilter.PageSize)
                    .ToListAsync();
                var totalRecords = await _context.Products.CountAsync();
               return PaginationHelper.CreatePagedReponse(pagedData, validFilter, totalRecords, _uriService, validFilter.route);
            }
        }
    }
}
