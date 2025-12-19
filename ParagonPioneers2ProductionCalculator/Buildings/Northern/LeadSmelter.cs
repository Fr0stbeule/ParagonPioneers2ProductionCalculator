namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class LeadSmelter : NorthernBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.LeadIngot, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2), new(eGood.LeadOre, 1)];
	private protected override string IconName => "LeadSmelter.png";
}