using ParagonPioneers2ProductionCalculator.Tiles;
using ParagonPioneers2ProductionCalculator.Tiles.Southern;

namespace ParagonPioneers2ProductionCalculator.Buildings.Southern.Workers;

internal class CacaoPlantation : WorkersBuilding
{
	public override double Minutes => 4;
	public override Material? Production { get; } = new(eGood.Cacao, 1);
	public override Material[] Consumption { get; } = [];
	public override TileRequirement? TileRequirement { get; } = new(5, new CacaoForest());
	private protected override string IconName => "CacaoPlantation.png";
}