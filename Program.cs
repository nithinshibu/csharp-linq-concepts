#region AggregateOperations

using LINQForBeginners.LINQ.AggregateOperations;
using LINQForBeginners.LINQ.Conversions;
using LINQForBeginners.LINQ.ElementOperations;
using LINQForBeginners.LINQ.Generators;
using LINQForBeginners.LINQ.Groupings;
using LINQForBeginners.LINQ.JoinOperations;
using LINQForBeginners.LINQ.Orderings;
using LINQForBeginners.LINQ.Partitions;

AggregateOperators aggregateOperators = new AggregateOperators();
//aggregateOperators.SeededAggregate();

#endregion

#region Conversions

Conversions conversions = new Conversions();
//conversions.ConvertSelectedItems();

#endregion


#region ElementOperations

ElementOperations elementOperations = new ElementOperations();
//elementOperations.ElementAtPosition();

#endregion

#region Generators

Generators generators = new Generators();
//generators.RepeatNumber();

#endregion

#region Groupings

Groupings groupings = new Groupings();
//groupings.NestedGrouBy();

#endregion

#region JoinOperations

JoinOperations joinOperations = new JoinOperations();
//joinOperations.CrossGroupJoin();

#endregion

#region Orderings

Orderings orderings = new Orderings();
//orderings.OrderByProductsDescending();

#endregion

#region Partitions

Partitions partitions = new Partitions();
partitions.NestedTake();
#endregion