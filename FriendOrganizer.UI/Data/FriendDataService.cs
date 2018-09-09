using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
	public class FriendDataService : IFriendDataService
	{
		public IEnumerable<Friend> GetAll()
		{
			yield return new Friend { FirstName = "John", LastName = "Smith" };
			yield return new Friend { FirstName = "Sara", LastName = "Parker" };
		}
	}
}
