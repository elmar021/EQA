using EQA.Business.Services.Interfaces;
using EQA.Core.Models;
using EQA.Core.Repositories.Interfaces;
using EQA.Data.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQA.Business.Services.Implementations
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _portfolioRepository;
        public PortfolioService(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository= portfolioRepository;
        }
        public async Task CreateAsync(Portfolio entity)
        {
            if (!_portfolioRepository.Table.Any(x => x.Id == entity.PortfolioId))
            {
                throw new NullReferenceException("PortfolioId", "Portfolio not found!");
            }
            bool check = false;

            if (entity.PortfolioIds != null)
            {
                foreach (var PortfolioId in entity.PortfolioId)
                {
                    if (!_portfolioRepository.Table.Any(x => x.Id == PortfolioId))
                    {
                        check = true;
                        break;
                    }
                }
            }

            if (check)
            {
                throw new NullReferenceException("TagId", "Portfolio not found!");
            }
            else
            {}

            if (entity.ImageFile != null)
            {
                if (entity.ImageFile.ContentType != "image/jpeg" && entity.ImageFile.ContentType != "image/png")
                {
                    throw new NullReferenceException("BookPosterImageFile", "ImageFile must be .png or .jpeg (.jpg)");
                }
                if (entity.ImageFile.Length > 2097152)
                {
                    throw new NullReferenceException("BookPosterImageFile", "File size must be lower than 2mb!");
                }
                await _portfolioRepository.CreateAsync(Image);
            }

            if (entity.ImageFile != null)
            {
                if (entity.ImageFile.ContentType != "image/jpeg" && entity.ImageFile.ContentType != "image/png")
                {
                    throw new NullReferenceException("BookHoverImageFile", "File must be .png or .jpeg (.jpg)");
                }
                if (entity.ImageFile.Length > 2097152)
                {
                    throw new NullReferenceException("BookHoverImageFile", "File size must be lower than 2mb)");
                }     
            }
            await _portfolioRepository.CreateAsync(entity);
            await _portfolioRepository.CommitAsync();
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Portfolio>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Portfolio> GetByIdAsync(int id)
        {
            var entity = await _portfolioRepository.GetByIdAsync(x => x.Id == id && x.IsDeleted == false, "Portfolio", "Images");

            if (entity is null) throw new NullReferenceException();

            return entity;
        }

        public async Task SoftDelete(int id)
        {
            var entity = await _portfolioRepository.GetByIdAsync(x => x.Id == id && x.IsDeleted == false);

            if (entity is null) throw new NullReferenceException();

            entity.IsDeleted = true;
            await _portfolioRepository.CommitAsync();
        }

        public Task UpdateAsync(Portfolio entity)
        {
            throw new NotImplementedException();
        }
    }
}
