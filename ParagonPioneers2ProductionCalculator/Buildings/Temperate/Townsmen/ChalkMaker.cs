namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class ChalkMaker : TownsmenBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.Chalk, 1);
	public override Material[] Consumption { get; } = [new(eGood.Limestone, 1)];
	private protected override string IconName => "ChalkMaker.png";
}