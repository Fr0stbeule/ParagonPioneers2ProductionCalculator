namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class DrummersSchool : TownsmenBuilding
{
	public override double Minutes => 15;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Militia, 3), new(eGood.WarDrum, 1)];
	private protected override string IconName => "DrummersSchool.png";
}