namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class HeatingPlant : NorthernBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Wood, 1)];
	private protected override string IconName => "HeatingPlant.png";
}