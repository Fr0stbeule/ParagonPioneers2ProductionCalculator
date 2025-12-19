namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Malthouse : TownsmenBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Malt, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wheat, 2)];
	private protected override string IconName => "Malthouse.png";
}