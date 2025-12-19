namespace ParagonPioneers2ProductionCalculator.Tiles;

public abstract class AbstractTile
{
	public double Amount { get; set; }
	public string IconLocation => Path.Combine("Tiles", this.Region, this.IconName);
	private protected abstract string Region { get; }
	private protected abstract string IconName { get; }
}

internal abstract class TemperateTile : AbstractTile
{
	private protected override string Region => "Temperate";
}

internal abstract class SouthernTile : AbstractTile
{
	private protected override string Region => "Southern";
}

internal abstract class NorthernTile : AbstractTile
{
	private protected override string Region => "Northern";
}

internal abstract class HighSeasTile : AbstractTile
{
	private protected override string Region => "HighSeas";
}