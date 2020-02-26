using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.ProfilePhotoModule
{
    public class ProfilePhotoDomain : IProfilePhotoDomain
    {
        public ProfilePhotoDomain(IProfilePhotoUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(ProfilePhoto parameters)
        {
            // throw new NotImplementedException();
            return await Uow.Repository<ProfilePhoto>().AllAsync();
        }

        public Task<object> GetBy(ProfilePhoto parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(ProfilePhoto entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(ProfilePhoto entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(ProfilePhoto entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(ProfilePhoto entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(ProfilePhoto parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(ProfilePhoto parameters)
        {
            throw new NotImplementedException();
        }

        public IProfilePhotoUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IProfilePhotoDomain : ICoreDomain<ProfilePhoto, ProfilePhoto> { }
}
