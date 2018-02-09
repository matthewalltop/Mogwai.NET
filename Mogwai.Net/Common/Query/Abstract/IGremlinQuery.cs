namespace Mogwai.Net.Common.Query.Abstract
{
    public interface IGremlinQuery
    {
		IGremlinAddEdgeQuery AddE(string label="");
		IGremlinQuery Has(string name);
		IGremlinQuery Has(string name, string value);
		IGremlinQuery HasLabel(string label);
		IGremlinQuery In(string value);
		IGremlinQuery Out(string edgeLabel);
		IGremlinQuery Values(string value);
		IGremlinQuery Aggregate(string value);
		IGremlinQuery Where(IGremlinFilterQuery filter);
		string Count();
    }

}
