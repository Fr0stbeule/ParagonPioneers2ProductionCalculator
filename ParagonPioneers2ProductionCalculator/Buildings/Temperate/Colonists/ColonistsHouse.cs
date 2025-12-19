namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Colonists;

internal class ColonistsHouse : ColonistsBuilding, IPopulationBuilding
{
	public override double Minutes => 60;
	public override Material? Production { get; } = null;
	public override Material[] Consumption { get; } = [new(eGood.Fish, 15d / 3780 * 3600), new(eGood.Sausage, 15d / 10800 * 3600), new(eGood.Cider, 15d / 9450 * 3600), new(eGood.Soap, 15d / 12600 * 3600), new(eGood.Fabric, 15d / 20160 * 3600), new(eGood.Bread, 15d / 16800 * 3600)];
	private protected override string IconName => "ColonistsHouse.png";
}