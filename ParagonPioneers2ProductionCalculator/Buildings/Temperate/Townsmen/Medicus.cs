namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class Medicus : TownsmenBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.FishOil, 1)];
	private protected override string IconName => "Medicus.png";
}