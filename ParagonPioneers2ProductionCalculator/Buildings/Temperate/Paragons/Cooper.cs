namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Cooper : ParagonsBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Barrel, 2);
	public override Material[] Consumption { get; } = [new(eGood.IronIngot, 1), new(eGood.Plank, 8)];
	private protected override string IconName => "Cooper.png";
}