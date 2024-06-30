using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Project.Application.Configurations.Commands.Common
{
    public interface ICommandBase: IRequest
    {
        Guid Id { get; }
    }
    public interface ICommandBase<out TResult>: IRequest<TResult> 
    {
        Guid Id { get; }
    }
}
