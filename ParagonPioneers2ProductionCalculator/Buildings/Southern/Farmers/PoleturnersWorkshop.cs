namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Farmers;

internal class PoleturnersWorkshop : FarmersBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Pike, 1);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.CopperIngot, 1)];
	private protected override string IconName => "PoleturnersWorkshop.png";
}