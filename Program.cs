using Algoritm;

User user1 = new User("Cut", "Max", false);
User user2 = new User("Ger", "Nic", true);
User user3 = new User("Nau", "Toni", true);
User user4 = new User("Pon", "Andre", false);

List<User> users = new List<User>();
users.Add(user1);
users.Add(user2);   
users.Add(user3);
users.Add(user4);

foreach (User user in users)
{
    Console.WriteLine("Добро пожаловать " + user.Name);
    if (user.IsPremium == false) user.ShowAds();
}