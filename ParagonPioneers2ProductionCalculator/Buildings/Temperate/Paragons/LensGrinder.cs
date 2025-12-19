namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class LensGrinder : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Glasses, 8);
	public override Material[] Consumption { get; } = [new(eGood.BrassIngot, 1), new(eGood.Glass, 4)];
	private protected override string IconName => "LensGrinder.png";
}