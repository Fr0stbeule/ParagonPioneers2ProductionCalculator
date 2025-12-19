namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class FlourWindmill : ColonistsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Flour, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wheat, 2)];
	private protected override string IconName => "FlourWindmill.png";
}