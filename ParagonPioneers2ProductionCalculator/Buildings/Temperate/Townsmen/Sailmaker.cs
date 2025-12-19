namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Sailmaker : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Sail, 1);
	public override Material[] Consumption { get; } = [new(eGood.Ropes, 1), new(eGood.Yarn, 2)];
	private protected override string IconName => "Sailmaker.png";
}