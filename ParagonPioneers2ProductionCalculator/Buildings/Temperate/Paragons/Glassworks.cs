namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Glassworks : ParagonsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Glass, 8);
	public override Material[] Consumption { get; } = [new(eGood.Limestone, 1), new(eGood.Potash, 2), new(eGood.QuartzSand, 5)];
	private protected override string IconName => "Glassworks.png";
}