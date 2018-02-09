namespace Mogwai.Net.Common.Query.Abstract
{
    public interface IGremlinFilterQuery
    {
		IGremlinFilterQuery Not(IGremlinFilterQuery query);

		IGremlinFilterQuery Within(string value);

		IGremlinFilterQuery Repeat(IGremlinQuery query);

		IGremlinFilterQuery Until(IGremlinQuery query);

    }
}
