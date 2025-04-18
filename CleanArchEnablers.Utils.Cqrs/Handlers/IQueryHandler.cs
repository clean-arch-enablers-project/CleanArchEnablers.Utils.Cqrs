using CleanArchEnablers.Utils.Cqrs.Abstractions;

namespace CleanArchEnablers.Utils.Cqrs.Handlers;

public interface IQueryHandler<in TQuery, TQueryResult> where TQuery : IQuery
{
    Task<TQueryResult> Handle(TQuery query, CancellationToken cancellationToken);
}