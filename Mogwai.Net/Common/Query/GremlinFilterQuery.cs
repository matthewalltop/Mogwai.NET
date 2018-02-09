namespace Mogwai.Net.Common.Query
{
	using Abstract;
	public class GremlinFilterQuery : GremlinQueryRoot, IGremlinFilterQuery
	{
		public IGremlinFilterQuery Not(IGremlinFilterQuery query)
		{
			throw new System.NotImplementedException();
		}

		public IGremlinFilterQuery Repeat(IGremlinQuery query)
		{
			throw new System.NotImplementedException();
		}

		public IGremlinFilterQuery Until(IGremlinQuery query)
		{
			throw new System.NotImplementedException();
		}

		public IGremlinFilterQuery Within(string value)
		{
			throw new System.NotImplementedException();
		}
	}
}
