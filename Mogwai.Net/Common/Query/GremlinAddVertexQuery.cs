namespace Mogwai.Net.Common.Query
{
	using System.Text;

	using Mogwai.Net.Common.Query.Abstract;
    public class GremlinAddVertexQuery : GremlinQueryRoot, IGremlinAddVertexQuery
    {
	    public GremlinAddVertexQuery(StringBuilder builder)
	    {
		    this.Query.Append(builder);
	    }

	    public IGremlinAddVertexQuery Property(string name, string value)
	    {
		    this.Query.Append($".property('{name}','{value}')");
		    return new GremlinAddVertexQuery(this.Query);
	    }
    }
}
