using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epo_2
{
    public class Bill
    {
        private List<Item> _items;
        private Customer _customer;
        public Bill(Customer customer)
        {
            this._customer = customer;
            this._items = new List<Item>();
        }
        public void addGoods(Item arg)
        {
            _items.Add(arg);
        }
        public string Statement()
        {
            double totalAmount = 0;
            int totalBonus = 0;
            String Print = "Счет для " + _customer.getName() + "\n";
            Print += GetHeader();
            //foreach (Item item in _items) // Formula in paragraph 2.10-9
            //{
            //    double itemPrice = Total_Price(item);
            //    int bonus = item.GetBonus();
            //    double discount = item.GetDiscount();
            //    double PriceWithDiscount = itemPrice - discount;
            //    double usedBonus = UseBonus(item, PriceWithDiscount);
            //    double thisAmount = PriceWithDiscount - usedBonus;
            //    totalAmount = totalAmount + thisAmount;
            //    totalBonus = totalBonus + bonus;
            //    Print += GetItemString(discount, bonus, thisAmount, item); // show the item string

            //}

         
                
                foreach (Item item in _items)
                {
                int bonus = item.GetBonus();
                double discount = item.GetDiscount();
                double totalPrice = item.getQuantity() * item.getPrice();
                double PriceWithDiscount = totalPrice - discount;
                double usedBonus = UseBonus(item, PriceWithDiscount);
                double thisAmount = PriceWithDiscount - usedBonus;
                totalAmount =+ thisAmount;
                totalBonus =+ totalBonus + bonus;

                Print += GetItemString(discount, bonus, thisAmount, item);
                }

            
            Print += GetFooter(totalAmount, totalBonus); //display the footer
            _customer.receiveBonus(totalBonus);
            return Print;



        }


        //The Header
        public string GetHeader()
        {
            return "\t" + "Название" + "\t" + "Цена" +
            "\t" + "Кол-во" + "Стоимость" + "\t" + "Скидка" +
            "\t" + "Сумма" + "\t" + "Бонус" + "\n";


            //string result = "\t" + "Название" + "\t" + "Цена" +
            //"\t" + "Кол-во" + "Стоимость" + "\t" + "Скидка" +
            //"\t" + "Сумма" + "\t" + "Бонус" + "\n";
            //return result;

        }

        //The Footer
        private string GetFooter(double totalAmount, int totalBonus)
        {
            return "Сумма счета составляет " + totalAmount.ToString() + "\nВы заработали " + totalBonus.ToString() + " бонусных баллов";
        }


        //String of Items
        private string GetItemString(double discount, int bonus, double thisAmount, Item item)
        {
            return "\t" + item.getGoods().getTitle() + "\t" + // or item
                "\t" + item.getPrice() + "\t" + item.getQuantity() +
                "\t" + (item.getQuantity() * item.getPrice()).ToString() +
                "\t" + discount.ToString() + "\t" + thisAmount.ToString() +
                "\t" + bonus.ToString() + "\n";


            /////////// or ////////////


            //string result = "\t" + item.getGoods().getTitle() + "\t" + 
            //    "\t" + item.getPrice() + "\t" + item.getQuantity() +
            //   "\t" + (item.getQuantity() * item.getPrice()).ToString() +
            //   "\t" + discount.ToString() + "\t" + thisAmount.ToString() +
            //   "\t" + bonus.ToString() + "\n";
            //return result;
        }


        //Formula Of Total Cost
        private double Total_Price(Item item)
        {
            return item.getQuantity() * item.getPrice();
        }



        //using Bonuses 
        private double UseBonus(Item item, double PriceWithDiscount)
        {
            double bonus = 0.0;
            if ((item.getGoods().getPriceCode() == Goods.REGULAR) && item.getQuantity() > 5)
                bonus = _customer.useBonus((int)PriceWithDiscount);
            else if ((item.getGoods().getPriceCode() == Goods.SPECIAL_OFFER) && item.getQuantity() > 1)
                bonus = _customer.useBonus((int)PriceWithDiscount);
            return bonus;
        }









    }
}










    
