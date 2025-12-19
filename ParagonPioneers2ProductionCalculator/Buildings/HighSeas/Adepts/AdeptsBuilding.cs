namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Adepts;

internal abstract class AdeptsBuilding : HighSeasBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Adepts");
}