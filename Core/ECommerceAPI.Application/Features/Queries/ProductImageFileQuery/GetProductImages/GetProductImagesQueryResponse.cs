﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Features.Queries.ProductImageFileQuery.GetProductImages
{
    public class GetProductImagesQueryResponse
    {
        public string? Path { get; set; }
        public Guid Id { get; set; }
        public string? FileName { get; set; }
    }
}