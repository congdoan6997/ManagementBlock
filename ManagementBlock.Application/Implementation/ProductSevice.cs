using AutoMapper;
using AutoMapper.QueryableExtensions;
using ManagementBlock.Application.Interfaces;
using ManagementBlock.Application.ViewModels;
using ManagementBlock.Data.Entities;
using ManagementBlock.Data.IRepositories;
using ManagementBlock.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagementBlock.Application.Implementation
{
    public class ProductSevice : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _productRepository;
        public ProductSevice(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }
        public ProductViewModel Add(ProductViewModel productViewModel)
        {
            var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
            _productRepository.Add(product);
            return productViewModel;

        }

        public void Delete(int id)
        {
            _productRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll().OrderBy(x => x.DateModified).ProjectTo<ProductViewModel>().ToList();
        }

        public List<ProductViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productRepository.FindAll(x => x.Name.Contains(keyword)
                || x.Description.Contains(keyword))
                    .OrderBy(x => x.DateModified).ProjectTo<ProductViewModel>().ToList();
            else
                return _productRepository.FindAll().OrderBy(x => x.DateModified)
                    .ProjectTo<ProductViewModel>()
                    .ToList();
        }

        public ProductViewModel GetById(int id)
        {
            return Mapper.Map<Product, ProductViewModel>(_productRepository.FindById(id));
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductViewModel productViewModel)
        {
            var product = Mapper.Map<ProductViewModel, Product>(productViewModel);
            _productRepository.Update(product);
        }
    }
}
