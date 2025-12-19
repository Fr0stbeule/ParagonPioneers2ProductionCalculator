namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class TownSchool : TownsmenBuilding
{
	public override double Minutes => 1;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Chalk, 1)];
	private protected override string IconName => "TownSchool.png";
}