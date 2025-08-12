using Infrastructure.Entities.Documents;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Infrastructure.Context
{
	public interface IMongoRepository<TDocument> where TDocument : BaseDocument
	{
		Task<IEnumerable<TDocument>> FindAllAsync();

		Task<IEnumerable<TDocument>> FindAllAsync(Expression<Func<TDocument, bool>> filterExpression, SortDefinition<TDocument> sorterExpression = null, int? limit = 1);


		Task<IEnumerable<TDocument>> FilterByAsync(Expression<Func<TDocument, bool>> filterExpression);

		Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression, SortDefinition<TDocument> sorterExpression = null);

		Task<TDocument> FindByIdAsync(Guid id);

		Task InsertOneAsync(TDocument document);

		Task InsertManyAsync(ICollection<TDocument> documents);

		Task ReplaceOneAsync(TDocument document);

		Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression);

		Task DeleteByIdAsync(Guid id);
		Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression);

		Task UpdateOneAsync(FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> updateDefinition);
	}
}
