namespace Mogwai.Net.Common.Query.Abstract
{
    public interface IGremlinQuery
    {
		IGremlinAddEdgeQuery AddE(string label="");

		IGremlinQuery Has(string name);

		IGremlinQuery Out(string edgeLabel);

		IGremlinQuery Values(string value);
    }
}
