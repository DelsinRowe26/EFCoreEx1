// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EFCoreEx1;

using (ApplicationContext db = new ApplicationContext())
{
	User tom = new User { Name = "Tom", Age = 33 };
	User alice = new User { Name = "Alice", Age = 26 };

	db.Users.Add(tom);
	db.Users.Add(alice);
	db.SaveChanges();
	Console.WriteLine("Объекты успешно сохранены");

	var users = db.Users.ToList();
	Console.WriteLine("Спсиок объектов:");
	foreach (User user in users)
	{
		Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
	}
}