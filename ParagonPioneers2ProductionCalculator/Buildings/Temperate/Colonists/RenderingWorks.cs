namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class RenderingWorks : ColonistsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Tallow, 1);
	public override Material[] Consumption { get; } = [new(eGood.Pig, 1)];
	private protected override string IconName => "RenderingWorks.png";
}