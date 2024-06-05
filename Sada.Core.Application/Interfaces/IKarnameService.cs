using Sada.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Application.Interfaces
{
    public interface IKarnameService
    {
        KarnameModel GenerateKarnameByStudentId(int studentId);
    }
}
