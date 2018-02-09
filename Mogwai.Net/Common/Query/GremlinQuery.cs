namespace Mogwai.Net.Common.Query
{
	using System.Text;
	using Abstract;

	public class GremlinQuery : GremlinQueryRoot, IGremlinQuery
	{
		public GremlinQuery(StringBuilder builder)
		{
			this.Query.Append(builder);
		}
		public IGremlinAddEdgeQuery AddE(string label = "")
		{
			this.Query.Append($".addE('{label}')");
			return new GremlinAddEdgeQuery(this.Query);
		}

		public IGremlinQuery Aggregate(string value)
		{
			throw new System.NotImplementedException();
		}

		public string Count()
		{
			this.Query.Append(".count()");
			return this.ToString();
		}

		public IGremlinQuery Has(string name)
		{
			this.Query.Append($".has('{name}')");
			return new GremlinQuery(this.Query);
		}


		public IGremlinQuery Has(string name, string value)
		{
			this.Query.Append($".has('{name}','{value}')");
			return new GremlinQuery(this.Query);
		}

		public IGremlinQuery HasLabel(string label)
		{
			this.Query.Append($".hasLabel('{label}')");
			return new GremlinQuery(this.Query);
		}

		public IGremlinQuery In(string value)
		{
			this.Query.Append($".in({value})");
			return new GremlinQuery(this.Query);
		}

		public IGremlinQuery Out(string edgeLabel)
		{
			this.Query.Append($".out('{edgeLabel}')");
			return new GremlinQuery(this.Query);
		}

		public IGremlinQuery Values(string value)
		{
			this.Query.Append($".values('{value}')");
			return new GremlinQuery(this.Query);
		}

		public IGremlinQuery Where(IGremlinFilterQuery filter)
		{
			this.Query.Append($".where({filter.ToString()})");
			throw new System.NotImplementedException();
		}
	}
}
