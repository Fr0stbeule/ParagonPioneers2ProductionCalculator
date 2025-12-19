namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class RockSaltMine : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.RockSalt, 1);
	public override Material[] Consumption { get; } = [];
	private protected override string IconName => "RockSaltMine.png";
}