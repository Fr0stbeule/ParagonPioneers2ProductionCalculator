namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal abstract class ArchmagesBuilding : HighSeasBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Archmages");
}