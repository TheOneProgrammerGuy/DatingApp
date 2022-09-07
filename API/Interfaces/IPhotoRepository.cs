using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using CloudinaryDotNet.Actions;

namespace API.Data
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<PhotoForApprovalDto>> GetUnapprovedPhotos();
        Task<Photo> GetPhotoById(int id);
        void RemovePhoto(Photo photo);
    }
}