namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class Tiltyard : ParagonsBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.TournamentLance, 1), new(eGood.Horse, 1)];
	private protected override string IconName => "Tiltyard.png";
}