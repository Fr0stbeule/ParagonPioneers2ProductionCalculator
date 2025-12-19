namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class BrassSmelter : NorthernBuilding
{
	public override double Minutes => 6;
	public override Material? Production { get; } = new(eGood.BrassIngot, 5);
	public override Material[] Consumption { get; } = [new(eGood.ZincIngot, 2), new(eGood.CopperIngot, 3)];
	private protected override string IconName => "BrassSmelter.png";
}