namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Brewery : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Beer, 2);
	public override Material[] Consumption { get; } = [new(eGood.Hops, 3), new(eGood.Malt, 1)];
	private protected override string IconName => "Brewery.png";
}