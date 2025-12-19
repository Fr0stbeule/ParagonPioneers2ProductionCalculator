namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal class TournamentArena : AdeptsBuilding
{
	public override double Minutes => 3;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Trophy, 1)];
	private protected override string IconName => "TournamentArena.png";
}