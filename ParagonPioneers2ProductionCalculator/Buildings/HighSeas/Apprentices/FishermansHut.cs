using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.HighSeas;

namespace ParagonPioneers2ProductionCalculator.Buildings.HighSeas.Apprentices;

internal class FishermansHut : ApprenticeBuilding
{
	public override double Minutes => 1.5;
	public override Material? Production { get; } = new(eGood.Fish, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(2, new Water());
	private protected override string IconName => "FishermansHut.png";
}