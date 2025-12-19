namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class CaviarFactory : NorthernBuilding
{
	public override double Minutes => 8;
	public override Material? Production { get; } = new(eGood.Caviar, 2);
	public override Material[] Consumption { get; } = [new(eGood.Salt, 1), new(eGood.Sturgeon, 1)];
	private protected override string IconName => "CaviarFactory.png";
}