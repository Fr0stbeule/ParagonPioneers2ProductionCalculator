namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Paragons;

internal class GlaziersWorkshop : ParagonsBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Window, 1);
	public override Material[] Consumption { get; } = [new(eGood.LeadIngot, 1), new(eGood.Glass, 4)];
	private protected override string IconName => "GlaziersWorkshop.png";
}