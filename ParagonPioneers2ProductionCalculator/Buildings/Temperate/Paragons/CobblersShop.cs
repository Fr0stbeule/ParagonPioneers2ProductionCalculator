namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class CobblersShop : ParagonsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Shoe, 8);
	public override Material[] Consumption { get; } = [new(eGood.BrassIngot, 1), new(eGood.Leather, 4)];
	private protected override string IconName => "CobblersShop.png";
}