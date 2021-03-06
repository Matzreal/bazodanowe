﻿using System;
using System.Collections.Generic;
using System.Linq;
using Store.Domain.Model.Product;
using Store.Domain.Repositories;

namespace Store.Application
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(Guid id)
        {
            _productRepository.Delete(id);
        }

        public IList<Product> GetAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public IList<Product> GetByCategory(string categorySub)
        {
            return _productRepository.GetByCategory(categorySub).ToList();
        }

        public Product GetById(Guid id)
        {
            return _productRepository.GetById(id);
        }

        public void Insert(Product obj)
        {
            _productRepository.Insert(obj);
        }
    }
}
