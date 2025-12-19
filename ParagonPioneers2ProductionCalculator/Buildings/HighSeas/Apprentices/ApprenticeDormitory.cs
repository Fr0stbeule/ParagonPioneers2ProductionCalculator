namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class ApprenticeDormitory : ApprenticeBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Fish, 10d / 3780 * 3600), new(eGood.Schnapps, 10d / 9450 * 3600), new(eGood.RoughCloak, 10d / 10800 * 3600)];
	private protected override string IconName => "ApprenticeDormitory.png";
}