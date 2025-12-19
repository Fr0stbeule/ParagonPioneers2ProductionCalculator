namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal abstract class ApprenticeBuilding : HighSeasBuilding
{
	private protected override string Region => Path.Combine(base.Region,"Apprentices");
}