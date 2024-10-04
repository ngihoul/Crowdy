﻿using Crowdy.BLL.Services;
using Crowdy.BLL.Services.Interfaces;
using Crowdy.DAL.Entities;
using Microsoft.AspNetCore.Http;

namespace Crowdy.BLL.Services
{
    public class FileService
    {
        private const string DEFAULT_AVATAR = "default.jpg";
        public string SaveFile(string path, IFormFile file)
        {
            if(file == null)
            {
                return DEFAULT_AVATAR;
            }

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string filePath = Path.Combine(path + @"\img\avatars");

            using (var fileStream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return fileName;
        }
    }
}
