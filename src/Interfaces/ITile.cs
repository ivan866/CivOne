// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

using CivOne.Enums;

namespace CivOne.Interfaces
{
	public interface ITile : ICivilopedia
	{
		int X { get; }
		int Y { get; }
		Terrain Type { get; }
		bool Special { get; }
		byte Borders { get; }
		ITile GetBorderTile(Direction direction);
		Terrain GetBorderType(Direction direction);
		bool Road { get; set; }
		bool Irrigation { get; set; }
		bool Mine { get; set; }
		bool Hut { get; set; }
	}
}