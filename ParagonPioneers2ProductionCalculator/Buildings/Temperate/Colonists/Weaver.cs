namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class Weaver : ColonistsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Fabric, 1);
	public override Material[] Consumption { get; } = [new(eGood.Yarn, 2)];
	private protected override string IconName => "Weaver.png";
}