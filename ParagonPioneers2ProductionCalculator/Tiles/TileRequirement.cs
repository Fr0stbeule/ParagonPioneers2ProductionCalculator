namespace ParagonPioneers2ProductionCalculator.Tiles;

public class TileRequirement(double amount, AbstractTile tile)
{
	public double Amount { get; } = amount;
	public AbstractTile Tile { get; } = tile;
}