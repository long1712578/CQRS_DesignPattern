using MediatR;

namespace CQRS_Project.Application.Configurations.Commands.Common
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand> where TCommand : ICommandBase
    {
    }

    public interface ICommandHandler<in TCommand, TResult> :
       IRequestHandler<TCommand, TResult> where TCommand : ICommandBase<TResult>
    {

    }
}
