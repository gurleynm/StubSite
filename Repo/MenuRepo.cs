using StubSite.Data;

namespace StubSite.Repo
{
    public class MenuRepo
    {
        public static List<Item> Items = new List<Item>();
        public static async Task<Dictionary<string,List<Item>>> GetMenuItemsAsDictionary()
        {
            Dictionary<string,List<Item>> dictItems = new Dictionary<string,List<Item>>();

            if (Items.Count == 0)
                await GetMenuItems();

            foreach(var item in Items)
            {
                if(!dictItems.ContainsKey(item.Category))
                    dictItems[item.Category] = new List<Item>() { item };
                else
                    dictItems[item.Category].Add(item);
            }

            return dictItems;
        }
        public static async Task<List<Item>> GetMenuItems()
        {
            Items.Clear();

            Items.Add(new Item("Hummus and Pita", "Chickpea hummus with paprika, olive oil, and warm pita bread.", "Starters", "$10.25"));
            Items.Add(new Item("Glass Noodle Summer Rolls", "2 per order. Carrot, cucumber, bean sprouts, enoki mushrooms, jalapeno, and Thai chilli sauce.", "Starters","$10.25"));
            
            Items.Add(new Item("Beyond Burger", "Tempeh bacon, lettuce, tomato, corn, scallion relish, chiptole mayonnaise, and hallah bun.","Entrees","$14.50"));
            Items.Add(new Item("Greek Gyro - Seitan or Lamb", "Seitan gyro roast or shaved lamb, served on pita bread with lettuce, red onion, feta cheese, and cucumber tzatziki sauce.", "Entrees", "$13.75"));
            Items.Add(new Item("Caprese Sandwich", "Heirloom tomato, fresh mozzarella, basil, cashew pesto, and focaccia bread.", "Entrees", "$12.50"));
            
            Items.Add(new Item("Latte", "","Drinks","$6.25"));
            Items.Add(new Item("Dirty Chai", "","Drinks","$7.25"));
            Items.Add(new Item("Iced Coffee (16 oz)", "Smooth and refreshing coffee brewed to perfection, served over ice.", "Drinks","$2.50"));
            Items.Add(new Item("London Fog", "Earl Grey Tea w/ steamed milk & vanilla", "Drinks", "$6.75"));

            return Items;
        }

        public static async Task<List<string>> GetCategories()
        {
            if (Items.Count == 0)
                await GetMenuItems();

            return Items.Select(it => it.Category).ToList();
        }
    }
}
