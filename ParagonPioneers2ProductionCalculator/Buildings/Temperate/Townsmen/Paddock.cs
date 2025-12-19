namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Paddock : TownsmenBuilding
{
	public override double Minutes => 6;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Horse, 1)];
	private protected override string IconName => "Paddock.png";
}