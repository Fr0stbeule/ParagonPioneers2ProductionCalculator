namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class PikemenBarracks : FarmersBuilding
{
	public override double Minutes => 15;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Slinger, 3), new(eGood.Pike, 1)];
	private protected override string IconName => "PikemenBarracks.png";
}