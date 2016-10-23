using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{
		public IPackOfCards Create()
		{
            PackOfCards packOfCards = new PackOfCards();
            packOfCards.Create();
            return packOfCards;
		}
	}
}
