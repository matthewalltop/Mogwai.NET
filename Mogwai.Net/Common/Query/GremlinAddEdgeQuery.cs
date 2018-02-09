namespace Mogwai.Net.Common.Query
{
	using System.Text;
	using Abstract;

	public class GremlinAddEdgeQuery : GremlinQueryRoot, IGremlinAddEdgeQuery
	{
		public GremlinAddEdgeQuery(StringBuilder builder)
		{
			this.Query.Append(builder);
		}

		public string To(string toNode)
		{
			this.Query.Append($".to(g.V('{toNode}'))");
			return this.ToString();
		}

		public string To(IGremlinQuery query)
		{
			this.Query.Append($".to({query.ToString()})");
			return this.ToString();
		}
	}
}
