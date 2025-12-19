namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class JamMaker : TownsmenBuilding
{
	public override double Minutes => 12;
	public override Material? Production { get; } = new(eGood.Jam, 4);
	public override Material[] Consumption { get; } = [new(eGood.Sugar, 1), new(eGood.Strawberries, 4)];
	private protected override string IconName => "JamMaker.png";
}