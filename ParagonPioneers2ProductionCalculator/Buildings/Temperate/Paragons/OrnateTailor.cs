namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class OrnateTailor : ParagonsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.NobleGarment, 1);
	public override Material[] Consumption { get; } = [new(eGood.Pelt, 1), new(eGood.BrocadeFabric, 1)];
	private protected override string IconName => "OrnateTailor.png";
}