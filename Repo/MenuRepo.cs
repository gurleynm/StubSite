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

            Items.Add(new Item("The Classic Start", "Sausage or bacon, egg and cheddar on a croissant", "Sandwiches", "$7.00"));
            Items.Add(new Item("The B.E.A.S.T.", "Bacon, egg, avocado, spinach and tomato on an everything bagel", "Sandwiches", "$8.00"));
            Items.Add(new Item("The GOAT", "Egg, spinach, tomato and goat cheese on an everything bagel", "Sandwiches", "$8.00"));
            
            
            Items.Add(new Item("The Cozy Bowl", "Bacon, spinach, egg, roasted sweet potatoes and apples with maple drizzle", "Bowls", "$8.00"));
            Items.Add(new Item("The Breakfast Bowl", "Roasted potatoes, bacon or sausage, eggs, sourdough toast", "Bowls", "$8.00"));
            Items.Add(new Item("The Goetta Bowl", "Goetta, spinach, egg, roasted potatoes & onions with rosemary", "Bowls", "$8.00"));
            Items.Add(new Item("The Rancheros Bowl", "Egg, sausage, roasted potatoes with onions, bell peppers, avocado and chipotle sauce", "Bowls", "$8.00"));
            Items.Add(new Item("The Oats De Jour", "Steel cut oats prepared with almond milk and served with seasonal toppings", "Bowls", "$6.00"));
            
            Items.Add(new Item("The Garden", "Sourdough, avocado, tomato, fresh basil, pickled onions and balsamic drizzle", "Toasts", "$8.00"));
            Items.Add(new Item("The Southwest", "Sourdough, avocado, tomato, red bell pepper, pickled onions, bacon and chipotle sauce", "Toasts", "$8.00"));
            Items.Add(new Item("The Hot Honey", "Sourdough, avocado, cucumber, goat cheese, red pepper flakes and honey", "Toasts", "$8.00"));
            Items.Add(new Item("The Fusion", "Sourdough, avocado, cucumber, carrot, red bell pepper, sesame ginger crunch and sesame oil", "Toasts", "$8.00"));
            Items.Add(new Item("The Loaded Bagel", "Everything bagel, herb caper cream cheese, smoked salmon, tomato, dill", "Toasts", "$13.00"));
            
            Items.Add(new Item("Tropical Trailside", "Pineapple, banana, coconut milk, orange puree", "Smoothies", "$7.00"));
            Items.Add(new Item("Strawberry Banana", "Strawberry, banana, honey", "Smoothies", "$7.00"));
            Items.Add(new Item("Monkey Moo", "Banana, chocolate, milk", "Smoothies", "$7.00"));
            Items.Add(new Item("Frogman", "Kale, spinach, pineapple, banana, avocado", "Smoothies", "$7.00"));
            Items.Add(new Item("Protein Powder", "", "Smoothies", "+ $2.00"));

            Items.Add(new Item("Drip Coffee", "Fresh brewed coffee", "Coffee", "$3.00"));
            Items.Add(new Item("Tea", "Hot or iced tea", "Coffee", "$3.50"));
            Items.Add(new Item("Espresso", "Single shot espresso", "Coffee", "$3.00"));
            Items.Add(new Item("Cappuccino", "Espresso with steamed milk and foam", "Coffee", "$5.00"));
            Items.Add(new Item("Latte", "Espresso with steamed milk", "Coffee", "$5.25"));
            Items.Add(new Item("Mocha", "Espresso with chocolate and milk", "Coffee", "$5.75"));
            Items.Add(new Item("Cortado", "Equal parts espresso and steamed milk", "Coffee", "$3.00"));
            Items.Add(new Item("Hot Chocolate", "Chocolate drink with steamed milk", "Coffee", "$3.50"));
            Items.Add(new Item("Flavor Syrup Add-On", "Add flavored syrup to any drink", "Add-Ons", "$0.50"));
            Items.Add(new Item("Milk Alternative", "Oat, coconut, or almond milk", "Add-Ons", "$0.75"));

            Items.Add(new Item("Bottled Water", "Chilled bottled water", "Other Beverages", "$2.00"));
            Items.Add(new Item("Honest Kids Juice", "Organic juice box", "Other Beverages", "$1.50"));
            Items.Add(new Item("Horizon Milk Carton", "Single-serve milk carton", "Other Beverages", "$1.75"));
            Items.Add(new Item("Wellness Smoothie", "Blended fruit smoothie", "Other Beverages", "$6.00"));
            Items.Add(new Item("Coke / Diet Coke / Sprite", "Assorted soft drinks", "Other Beverages", "$2.00"));
            Items.Add(new Item("Waterloo", "Sparkling water", "Other Beverages", "$2.00"));
            Items.Add(new Item("Ocean Spray", "Juice drink", "Other Beverages", "$2.00"));
            Items.Add(new Item("Orange Juice", "Classic orange juice", "Other Beverages", "$2.00"));

            Items.Add(new Item("Cup of Soup", "Daily selection soup", "A La Carte", "$3.00"));
            Items.Add(new Item("Salad", "Fresh daily salad", "A La Carte", "$7.00"));
            Items.Add(new Item("Fruit Cup", "Fresh cut fruit", "A La Carte", "$4.00"));
            Items.Add(new Item("Yogurt Parfait", "Yogurt with toppings", "A La Carte", "$3.00"));
            Items.Add(new Item("Hard Boiled Eggs", "Two hard boiled eggs", "A La Carte", "$2.00"));
            Items.Add(new Item("Muffin", "Fresh baked muffin", "A La Carte", "$1.50"));
            Items.Add(new Item("Croissant", "Buttery flaky pastry", "A La Carte", "$5.00"));
            Items.Add(new Item("Mini Danish", "Small sweet pastry", "A La Carte", "$1.00"));
            Items.Add(new Item("Bagel", "Plain bagel", "A La Carte", "$3.00"));
            Items.Add(new Item("Sweet Potato Chips", "Crispy sweet potato chips", "A La Carte", "$3.00"));
            Items.Add(new Item("Simply Chips", "Classic potato chips", "A La Carte", "$1.75"));
            Items.Add(new Item("Fruit Jerky", "Dried fruit snack", "A La Carte", "$2.75"));
            Items.Add(new Item("Dots Pretzels", "Seasoned pretzels", "A La Carte", "$1.50"));
            Items.Add(new Item("Trail Mix", "Mixed nuts and snacks", "A La Carte", "$2.00"));

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
