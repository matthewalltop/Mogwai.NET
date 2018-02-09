namespace Mogwai.Net
{
	using Mogwai.Net.Common.Query.Abstract;
	using Mogwai.Net.Common.Query;

	public class G : GremlinQueryRoot
	{
		public G()
		{
			this.Query.Append("g.");
		}

		/// <inheritdoc />
		public GremlinAddVertexQuery AddV(string name)
		{
			this.Query.Append($"addV('{name}')");
			return new GremlinAddVertexQuery(this.Query);
		}

		/// <inheritdoc />
		public GremlinQuery V()
		{
			this.Query.Append($"V()");
			return new GremlinQuery(this.Query);
		}

		/// <inheritdoc />
		public GremlinQuery V(string name)
		{
			this.Query.Append($"V('{name}')");
			return new GremlinQuery(this.Query);
		}

		/// <inheritdoc />
		public GremlinQuery V(int itemCount)
		{
			this.Query.Append($"V({itemCount})");
			return new GremlinQuery(this.Query);
		}




	}
}
