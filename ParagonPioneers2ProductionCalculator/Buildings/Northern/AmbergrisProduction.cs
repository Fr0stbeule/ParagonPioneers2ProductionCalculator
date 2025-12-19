namespace ParagonPioneers2ProductionCalculator.Buildings.Northern;

internal class AmbergrisProduction : NorthernBuilding
{
	public override double Minutes => 32;
	public override Material? Production { get; } = new(eGood.Ambergris, 1);
	public override Material[] Consumption { get; } = [new(eGood.SpermWhale, 2)];
	private protected override string IconName => "AmbergrisProduction.png";
}