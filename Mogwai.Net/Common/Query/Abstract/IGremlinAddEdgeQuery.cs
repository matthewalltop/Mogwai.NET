﻿namespace Mogwai.Net.Common.Query.Abstract
{
    public interface IGremlinAddEdgeQuery
    {
		string To(string toNode);

		string To(IGremlinQuery query);
	}
}
