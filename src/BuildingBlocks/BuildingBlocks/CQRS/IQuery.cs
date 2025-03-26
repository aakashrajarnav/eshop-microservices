using MediatR;

namespace BuildingBlocks.CQRS
{
    //design for read operation
    public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull
    {
    }
}
