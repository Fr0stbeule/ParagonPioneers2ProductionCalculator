namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class BoilingHouse : TownsmenBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.FishOil, 2);
	public override Material[] Consumption { get; } = [new(eGood.Coal, 1), new(eGood.Fish, 6)];
	private protected override string IconName => "BoilingHouse.png";
}