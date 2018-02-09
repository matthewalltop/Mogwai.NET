namespace Mogwai.Net.Test.Common.Query
{
	using System;

	using FluentAssertions;
	using Xunit;

	using Mogwai.Net;

    public class GremlinQueryTest
    {
		public GremlinQueryTest()
		{

		}

		[Fact]
		public void GremlinQueryCorrectlyFormats()
		{
			// Arrange
			var g = new G();
			var id = Guid.NewGuid();


			// Act
			var result = g.AddV("Person").Property("id", $"{id}").Property("name", "Matthew").ToString();


			// Assert
			result.Should().BeEquivalentTo($"g.AddV('Person').property('id', '{id}').property('name', 'matthew')");
		}

    }
}
