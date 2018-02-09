namespace Mogwai.Net.Common.Query.Abstract
{
	using System.Text;

	public abstract class GremlinQueryRoot
    {
	    protected StringBuilder Query { get; set; }

	    public override string ToString() 
		    => this.Query.ToString();

    }
}
