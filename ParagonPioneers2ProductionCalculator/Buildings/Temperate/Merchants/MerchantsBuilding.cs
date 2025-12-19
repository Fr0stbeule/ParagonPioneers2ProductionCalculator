namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Merchants;

internal abstract class MerchantsBuilding : TemperateBuilding
{
	private protected override string Region => Path.Combine(base.Region, "Merchants");
}