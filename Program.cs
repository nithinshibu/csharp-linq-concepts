#region AggregateOperations

using LINQForBeginners.LINQ.AggregateOperations;
using LINQForBeginners.LINQ.Conversions;
using LINQForBeginners.LINQ.ElementOperations;
using LINQForBeginners.LINQ.Generators;
using LINQForBeginners.LINQ.Groupings;

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
groupings.NestedGrouBy();

#endregion