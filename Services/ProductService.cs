using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleNETapp.Domain.Models;
using SampleNETapp.Domain.Repositories;
using SampleNETapp.Domain.Services;
using SampleNETapp.Domain.Services.Communication;

namespace SampleNETapp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }

        public async Task<ProductResponse> SaveAsync(Product product)
        {
            try
            {
                var existingCategory = await _categoryRepository.FindByIdAsync(product.CategoryId);
                if (existingCategory == null)
                    return new ProductResponse("Invalid category.");
                await _productRepository.AddAsync(product);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(product);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }

        public async Task<ProductResponse> UpdateAsync(int id, Product product)
        {
            var existingProduct = await _productRepository.FindByIdAsync(id);
            if (existingProduct == null)
                return new ProductResponse("Product not found.");
            
            existingProduct.Category = product.Category;
            existingProduct.QuantityInPackage = product.QuantityInPackage;
            existingProduct.Name = product.Name;
            existingProduct.UnitOfMeasurement = product.UnitOfMeasurement;

            try
            {
                _productRepository.Update(existingProduct);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(existingProduct);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"An error occurred when updating the product: {ex.Message}");
            }
        }

        public async Task<ProductResponse> DeleteAsync(int id)
        {
            var exisitingProduct = await _productRepository.FindByIdAsync(id);
            if (exisitingProduct == null)
                return new ProductResponse("Product not found.");

            try
            {
                _productRepository.Remove(exisitingProduct);
                await _unitOfWork.CompleteAsync();

                return new ProductResponse(exisitingProduct);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"An error occurred when removing the product: {ex.Message}");
            }
        }
    }
}