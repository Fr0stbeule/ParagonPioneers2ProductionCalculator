using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Temperate;

namespace ParagonPioneers2ProductionCalculator.Buildings.Temperate.Pioneers;

internal class SawWorks : PioneersBuilding
{
	public override double Minutes => 0.5;
	public override Material? Production { get; } = new(eGood.Plank, 1);
	public override Material[] Consumption { get; } = [new(eGood.Wood, 1)];
	private protected override string IconName => "SawWorks.png";
}