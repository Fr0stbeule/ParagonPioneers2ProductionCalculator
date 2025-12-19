namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Townsmen;

internal class TownsmensHouse : TownsmenBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Soap, 20d / 12600 * 3600), new(eGood.Fabric, 20d / 20160 * 3600), new(eGood.Bread, 20d / 16800 * 3600), new(eGood.Cauldron, 20d / 45400 * 3600), new(eGood.Beer, 20d / 17900 * 3600), new(eGood.Leather, 20d / 22100 * 3600), new(eGood.Coffee, 20d / 20900 * 3600), new(eGood.Jam, 20d / 13400 * 3600)];
	private protected override string IconName => "TownsmensHouse.png";
}