using MauiApp1.Model.Item;

namespace MauiApp1.Services
{
    public class ItemsService
    {
        private readonly Random RandomGenerator = new();

        List<Item> itemsList = new();

        public async Task<List<Item>> GetItems()
        {
            itemsList.Add(new Item { Name = "Item 1", Date = DateTime.Now, Score = RandomGenerator.Next(0, 5), Availability = RandomGenerator.Next(0, 100), ImageURL = "https://picsum.photos/200", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });
            itemsList.Add(new Item { Name = "Item 2", Date = DateTime.Now, Score = RandomGenerator.Next(0, 5), Availability = RandomGenerator.Next(0, 100), ImageURL = "https://picsum.photos/200", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });
            itemsList.Add(new Item { Name = "Item 3", Date = DateTime.Now, Score = RandomGenerator.Next(0, 5), Availability = RandomGenerator.Next(0, 100), ImageURL = "https://picsum.photos/200", Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });

            return itemsList;

        }

        // REST calls to retreive items can be done here
    }
}
