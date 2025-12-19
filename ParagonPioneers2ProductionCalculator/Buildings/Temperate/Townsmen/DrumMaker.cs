namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class DrumMaker : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.WarDrum, 1);
	public override Material[] Consumption { get; } = [new(eGood.Leather, 1)];
	private protected override string IconName => "DrumMaker.png";
}