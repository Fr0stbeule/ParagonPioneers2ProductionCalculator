namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class LanceMaker : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.TournamentLance, 1);
	public override Material[] Consumption { get; } = [new(eGood.Dye, 2), new(eGood.Wood, 8)];
	private protected override string IconName => "LanceMaker.png";
}