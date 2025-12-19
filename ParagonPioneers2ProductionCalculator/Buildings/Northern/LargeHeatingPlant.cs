namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class LargeHeatingPlant : NorthernBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1)];
	private protected override string IconName => "LargeHeatingPlant.png";
}