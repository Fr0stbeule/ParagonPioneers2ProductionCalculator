namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Archmages;

internal class FineForge : ArchmagesBuilding
{
	public override double Minutes => 2;
	public override Material? Production { get; } = new(eGood.CandleHolder, 1);
	public override Material[] Consumption { get; } = [new(eGood.Candle, 1), new(eGood.CopperIngot, 1)];
	private protected override string IconName => "FineForge.png";
}