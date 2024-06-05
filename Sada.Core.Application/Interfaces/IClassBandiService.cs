﻿using Sada.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Interfaces
{
    public interface IClassBandiService : IDisposable, IAsyncDisposable
    {
        Task<bool> CreateClassAsync(SchoolClass schoolClass);
        Task<bool> UpdateClassAsync(SchoolClass schoolClass);
        Task<bool> DeleteClassAsync(int classId);
        Task<bool> RegisterStudentForClassAsync(int classId, Student student);
        Task<bool> RemoveStudentForClassAsync(int classId, Student student);
        void CreateClassStudentCapacity(int classId, int capacity);

    }
}
