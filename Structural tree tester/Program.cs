// See https://aka.ms/new-console-template for more information
using Structural_tree_tester;
using StructuralTree;

Console.WriteLine("Testing structural data tree");

var column1 = new StructuralMember() { Name = "Column 1"};
column1.AddStructuralData(new SteelData(60, "S355"));
var column2 = new StructuralMember() { Name = "Column 2" };
column2.AddStructuralData(new SteelData(new InheritableValue<int>(90) { isInHerited = false }, new InheritableValue<string>("S355")));
var column3 = new StructuralMember() { Name = "Column 3" };
column3.AddStructuralData(new SteelData(90, "S355"));
column3.AddStructuralData(new ConcreteData(40));
var column4 = new StructuralMember() { Name = "Column 4" };
column4.AddStructuralData(new ConcreteData(35));


var columnGroup = new StructuralCollection() { Name = "Column group"};
columnGroup.AddStructuralData(new SteelData(new InheritableValue<int>(120) { isInHerited = false }, new InheritableValue<string>("S355")));
columnGroup.AddStructuralData(new ConcreteData(30));
columnGroup.AddChildren(column1);
columnGroup.AddChildren(column2);
columnGroup.AddChildren(column3);

var columnGroup2 = new StructuralCollection() { Name = "Column group 2" };
columnGroup2.AddStructuralData(new SteelData(new InheritableValue<int>(120) { isInHerited = false }, new InheritableValue<string>("S355")));
columnGroup2.AddStructuralData(new ConcreteData(30));

columnGroup2.AddChildren(column4);

var frame = new StructuralCollection() { Name = "The frame"};
frame.AddChildren(columnGroup);
frame.AddChildren(columnGroup2);
var data = new SteelData(60, "S275");
frame.AddStructuralData(data);

frame.UpdateChildren();

Utilities.writeChildData(frame,1);


