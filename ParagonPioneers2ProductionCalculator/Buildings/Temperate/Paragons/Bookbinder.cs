namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Bookbinder : ParagonsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Book, 2);
	public override Material[] Consumption { get; } = [new(eGood.Dye, 1), new(eGood.Paper, 8)];
	private protected override string IconName => "Bookbinder.png";
}