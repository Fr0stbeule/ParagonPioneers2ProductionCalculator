namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class RidingArena : TownsmenBuilding
{
	public override double Minutes => 15;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 3), new(eGood.Horse, 1)];
	private protected override string IconName => "RidingArena.png";
}