namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class AshHouse : ColonistsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Potash, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 2)];
	private protected override string IconName => "AshHouse.png";
}