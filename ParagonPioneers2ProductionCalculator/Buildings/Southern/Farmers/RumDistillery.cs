namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class RumDistillery : FarmersBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Rum, 1);
	public override Material[] Consumption { get; } = [new(eGood.SugarCane, 2)];
	private protected override string IconName => "RumDistillery.png";
}