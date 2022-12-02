namespace Jooom_Online
{
	public partial class UserLibrary
	{
		public enum UserType
		{
			Student,
			Teacher
		}

		public interface IUser
		{
			int? Id { get; set; }
			string Name { get; set; }
			UserType? UserType { get; set; }
			IUser CreateNewUser();
			IUser CreateNewUser(int id, string name, UserType userType);
			void ChangeUserId(int id);
			void ChangeUserName(string name);
			void ChangeUserType(UserType userType);
			void ChangeUserData(int? id, string name, UserType userType);
			void ResetUserData();
			void WriteData();
		}

		public class User : IUser
		{
			public int? Id { get; set; }
			public string Name { get; set; }
			public UserType? UserType { get; set; }

			public User() { Id = null; Name = null;  UserType = null; }
			public User(int id) : this()
			{
				Id = id;
			}
			public User(int id, string name) : this(id)
			{
				Name = name;
			}
			public User(int id, string name, UserType userType) : this(id, name)
			{
				UserType = userType;
			}

			public IUser CreateNewUser()
			{
				return new User();
			}
			public IUser CreateNewUser(int id, string name, UserType userType)
			{
				return new User(id, name, userType);
			}

			public void ChangeUserId(int id)
			{
				Id = id;
			}
			public void ChangeUserName(string name)
			{
				Name = name;
			}
			public void ChangeUserType(UserType userType)
			{
				UserType = userType;
			}
			public void ChangeUserData(int? id, string name, UserType userType)
			{
				Id = id;
				Name = name;
				UserType = userType;
			}

			public void ResetUserData()
			{
				Id = null;
				Name = null;
				UserType = null;
			}
			public void WriteData()
			{
				string data = string.Format("Идентификатор: {2}\nИмя: {0} \nТип: {1}", this.Name, this.UserType.ToString(), this.Id.ToString());

				ShowMessage(data, "Информация");
			}
		}
	}
}
