﻿namespace Mogwai.Net.Test.Common.Query
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
		public void GremlinAddVertexQueryCorrectlyFormats()
		{
			// Arrange
			var g = new G();
			var id = Guid.NewGuid();


			// Act
			var result = g.AddV("Person").Property("id", $"{id}").Property("name", "Matthew").ToString();


			// Assert
			result.Should().BeEquivalentTo($"g.AddV('Person').property('id','{id}').property('name','matthew')");
		}

		[Fact]
		public void GremlinAddEdgeQueryCorrectlyFormats()
		{
			// Arrange
			const string VERTEX_LABEL = "knows";
			var g = new G();
			var vertexOneId = Guid.NewGuid();
			var vertexTwoId = Guid.NewGuid();


			// Act
			var result = g.V($"{vertexOneId}").AddE($"{VERTEX_LABEL}").To($"{vertexTwoId}");


			// Assert
			result.Should().BeEquivalentTo($"g.V('{vertexOneId}').addE('{VERTEX_LABEL}').to(g.V('{vertexTwoId}'))");
		}


		[Fact]
		public void GremlinComplexAddEdgeQueryCorrectlyFormats()
		{
			// Arrange
			var g = new G();
			var g2 = new G();

			// Act
			var result = g.V().HasLabel("Person").Has("firstName", "Matthew").AddE("knows").To(g2.V().HasLabel("Person").Has("firstName", "Corene"));


			// Assert
			result.Should().BeEquivalentTo("g.V().hasLabel('Person').has('firstName','Matthew').addE('knows').to(g.V().hasLabel('Person').has('firstName','Corene'))");
		}


    }
}
