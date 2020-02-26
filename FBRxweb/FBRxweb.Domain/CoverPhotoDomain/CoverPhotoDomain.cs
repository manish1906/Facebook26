using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.CoverPhotoModule
{
    public class CoverPhotoDomain : ICoverPhotoDomain
    {
        public CoverPhotoDomain(ICoverPhotoUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(CoverPhoto parameters)
        {
            //throw new NotImplementedException();
            return await Uow.Repository<CoverPhoto>().AllAsync();

        }

        public Task<object> GetBy(CoverPhoto parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(CoverPhoto entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(CoverPhoto entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(CoverPhoto entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(CoverPhoto entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(CoverPhoto parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(CoverPhoto parameters)
        {
            throw new NotImplementedException();
        }

        public ICoverPhotoUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface ICoverPhotoDomain : ICoreDomain<CoverPhoto, CoverPhoto> { }
}
