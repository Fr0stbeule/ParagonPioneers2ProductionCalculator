namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Tannery : TownsmenBuilding
{
	public override double Minutes => 18;
	public override Material? Production { get; } = new(eGood.Leather, 3);
	public override Material[] Consumption { get; } = [new(eGood.Salt, 1), new(eGood.Hide, 3)];
	private protected override string IconName => "Tannery.png";
}